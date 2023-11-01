using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Tracking_System
{
    internal class Asset
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string IPAddress { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Note { get; set; }

        public dbConManagement dbManager;

        public Asset(dbConManagement conn)
        {
            dbManager = conn;
        }


        public int AddAsset(Asset newAsset, int empID) 
        {
            MySqlConnection conn = dbManager.GetConnection(); // set a connection variable
            DataTable dt = new DataTable();

            try // try executing this block
            {
                //added placeholder so that it protect against sql injection attack
                string query = "INSERT INTO Asset(Name,Model,Manufacturer,Type,IP_Address,Purchase_Date,Text_Note,Employee_ID) VALUES (@Name, @Model, @Manufacturer, @Type, @IPAddress, @PurchaseDate, @Note, @EmpID)";

                MySqlCommand command = new MySqlCommand(query, conn);

                // Adding the values in the placeholder
                command.Parameters.AddWithValue("@Name", newAsset.Name);
                command.Parameters.AddWithValue("@Model", newAsset.Model);
                command.Parameters.AddWithValue("@Manufacturer", newAsset.Manufacturer);
                command.Parameters.AddWithValue("@Type", newAsset.Type);
                command.Parameters.AddWithValue("@IPAddress", newAsset.IPAddress);

                if (newAsset.PurchaseDate == default(DateTime))
                {
                    command.Parameters.AddWithValue("@IPAddress", null);
                }
                else
                {
                    command.Parameters.AddWithValue("@IPAddress", newAsset.PurchaseDate);
                }

                command.Parameters.AddWithValue("@Note", newAsset.Note);
                command.Parameters.AddWithValue("@NoEmpIDte", empID);


                int rowsAffected = command.ExecuteNonQuery();
                

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Inserted Sucessfully");
                }
                else
                {
                    MessageBox.Show("Insertion Failed");
                }

                return id;

            }
            catch (Exception ex) // catch any error from above block
            {
                MessageBox.Show(ex.Message);

            } 
            return 0;
        }

        public DataTable ViewAsset() 
        {
            MySqlConnection conn = dbManager.GetConnection(); // set a connection variable
            DataTable dt = new DataTable();

            try // try executing this block
            {

                string query = "SELECT * FROM Asset";

                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlDataReader data = command.ExecuteReader();

                dt.Load(data);

                data.Close();

            }
            catch (Exception ex) // catch any error from above block
            {
                MessageBox.Show(ex.Message);
               
            }

            return dt;

        }
        public void EditAsset() { /* Implementation */ }
        public void DeleteAsset() { /* Implementation */ }
    }
}
