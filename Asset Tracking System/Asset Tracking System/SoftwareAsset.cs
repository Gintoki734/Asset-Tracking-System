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

        public dbConManagement dbManager;

        public SoftwareAsset(dbConManagement conn)
        {
            dbManager = conn;
        }

        public int AddSoftwareAsset(SoftwareAsset newSoftwareAsset)
        {
            MySqlConnection conn = dbManager.GetConnection();

            try
            {
                string query = "INSERT INTO SoftwareAsset(OSName, OSVersion, Software_Manufacturer, InstallationDate) VALUES (@OSName, @OSVersion, @Manufacturer, @InstallationDate)";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@OSName", newSoftwareAsset.OSName);
                command.Parameters.AddWithValue("@OSVersion", newSoftwareAsset.OSVersion);
                command.Parameters.AddWithValue("@Manufacturer", newSoftwareAsset.Manufacturer);
                command.Parameters.AddWithValue("@InstallationDate", newSoftwareAsset.InstallationDate);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Retrieve the auto-generated SoftwareID
                    MySqlCommand selectLastInsertIdCommand = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
                    int softwareId = Convert.ToInt32(selectLastInsertIdCommand.ExecuteScalar());


                    MessageBox.Show("Software Data Inserted Successfully");
                    return softwareId;
                }
                else
                {
                    MessageBox.Show("Insertion Failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Soft" + ex.Message);
            }

            return 0;
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
                               "Software_Manufacturer = @Manufacturer, InstallationDate = @InstallationDate, " +
                               "WHERE OS_ID = @ID";

                MySqlCommand command = new MySqlCommand(query, conn);

                command.Parameters.AddWithValue("@OSName", newSoftwareAsset.OSName);
                command.Parameters.AddWithValue("@OSVersion", newSoftwareAsset.OSVersion);
                command.Parameters.AddWithValue("@Manufacturer", newSoftwareAsset.Manufacturer);
                command.Parameters.AddWithValue("@InstallationDate", newSoftwareAsset.InstallationDate);

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
