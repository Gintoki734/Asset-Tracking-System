using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_System
{
    public class SoftwareAsset
    {
        // Declaring Variables
        public string OSName { get; set; }
        public string OSVersion { get; set; }
        public string Manufacturer { get; set; }
        public DateTime InstallationDate { get; set; }
        public int HardwareAssetID { get; set; }

        public dbConManagement dbManager;

        public SoftwareAsset(dbConManagement conn)
        {
            dbManager = conn;
        }

        public void AddSoftwareAsset(SoftwareAsset newSoftwareAsset)
        {
            MySqlConnection conn = dbManager.GetConnection();

            try
            {
                string query = "INSERT INTO SoftwareAsset(OSName, OSVersion, Manufacturer, InstallationDate, HardwareAssetID) " +
                               "VALUES (@OSName, @OSVersion, @Manufacturer, @InstallationDate, @HardwareAssetID)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@OSName", newSoftwareAsset.OSName);
                command.Parameters.AddWithValue("@OSVersion", newSoftwareAsset.OSVersion);
                command.Parameters.AddWithValue("@Manufacturer", newSoftwareAsset.Manufacturer);

                // Checks if the installation date has a default value
                if (newSoftwareAsset.InstallationDate == default(DateTime))
                {
                    command.Parameters.AddWithValue("@InstallationDate", null);
                }
                else
                {
                    command.Parameters.AddWithValue("@InstallationDate", newSoftwareAsset.InstallationDate);
                }

                command.Parameters.AddWithValue("@HardwareAssetID", newSoftwareAsset.HardwareAssetID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Inserted Successfully");
                }
                else
                {
                    MessageBox.Show("Insertion Failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable ViewSoftwareAsset()
        {
            MySqlConnection conn = dbManager.GetConnection();
            DataTable dt = new DataTable();

            try
            {
                string query = "SELECT * FROM SoftwareAsset";

                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlDataReader data = command.ExecuteReader();

                dt.Load(data);

                data.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }

        public void EditSoftwareAsset(SoftwareAsset newSoftwareAsset, int ID)
        {
            MySqlConnection conn = dbManager.GetConnection();

            try
            {
                string query = "UPDATE SoftwareAsset SET OSName = @OSName, OSVersion = @OSVersion, " +
                               "Manufacturer = @Manufacturer, InstallationDate = @InstallationDate, " +
                               "HardwareAssetID = @HardwareAssetID WHERE AssetID = @ID";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@OSName", newSoftwareAsset.OSName);
                command.Parameters.AddWithValue("@OSVersion", newSoftwareAsset.OSVersion);
                command.Parameters.AddWithValue("@Manufacturer", newSoftwareAsset.Manufacturer);

                if (newSoftwareAsset.InstallationDate == default(DateTime))
                {
                    command.Parameters.AddWithValue("@InstallationDate", null);
                }
                else
                {
                    command.Parameters.AddWithValue("@InstallationDate", newSoftwareAsset.InstallationDate);
                }

                command.Parameters.AddWithValue("@HardwareAssetID", newSoftwareAsset.HardwareAssetID);
                command.Parameters.AddWithValue("@ID", ID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }




}
