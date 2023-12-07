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
    public class Asset
    {
        //Declaring Variables
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Type { get; set; }
        public string IPAddress { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Note { get; set; }
        public int EmployeeID { get; set; }

        public dbConManagement dbManager;

        public Asset(dbConManagement conn)
        {
            dbManager = conn;
        }


        public void AddAsset(Asset newAsset) 
        {
            MySqlConnection conn = dbManager.GetConnection(); // set a connection variable
            //DataTable dt = new DataTable();

            try // try executing this block
            {
                //added placeholder so that it protect against sql injection attack, i learned this approach here "https://stackoverflow.com/questions/14376473/what-are-good-ways-to-prevent-sql-injection"
                string query = "INSERT INTO Asset(Name,Model,Manufacturer,Type,IP_Address,Purchase_Date,Text_Note,Employee_ID) VALUES (@Name, @Model, @Manufacturer, @Type, @IPAddress, @PurchaseDate, @Note, @EmpID)";

                MySqlCommand command = new MySqlCommand(query, conn);

                // Adding the values in the placeholder
                command.Parameters.AddWithValue("@Name", newAsset.Name);
                command.Parameters.AddWithValue("@Model", newAsset.Model);
                command.Parameters.AddWithValue("@Manufacturer", newAsset.Manufacturer);
                command.Parameters.AddWithValue("@Type", newAsset.Type);
                command.Parameters.AddWithValue("@IPAddress", newAsset.IPAddress);
                
                //checks if the purchase date has a default value or not so it can input null value in the database
                if (newAsset.PurchaseDate == default(DateTime))
                {
                    command.Parameters.AddWithValue("@PurchaseDate", null);
                }
                else
                {
                    command.Parameters.AddWithValue("@PurchaseDate", newAsset.PurchaseDate);
                }

                command.Parameters.AddWithValue("@Note", newAsset.Note);
                command.Parameters.AddWithValue("@EmpID", newAsset.EmployeeID);

                //Executes the query
                int rowsAffected = command.ExecuteNonQuery();
                
                //Displays if the user data has been inserted or not
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Inserted Sucessfully");
                }
                else
                {
                    MessageBox.Show("Insertion Failed");
                }

            }
            catch (Exception ex) // catch any error from above block
            {
                MessageBox.Show(ex.Message);

            } 
        }

        public DataTable ViewAsset() 
        {
            MySqlConnection conn = dbManager.GetConnection(); // set a connection variable
            DataTable dt = new DataTable();

            try // try executing this block
            {

                string query = "SELECT * FROM Asset";

                MySqlCommand command = new MySqlCommand(query, conn);

                //Executes
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
        public void EditAsset(Asset newAsset, int ID) {

            MySqlConnection conn = dbManager.GetConnection(); // set a connection variable
            //DataTable dt = new DataTable();

            try // try executing this block
            {
                //added placeholder so that it protect against sql injection attack, i learned this approach here "https://stackoverflow.com/questions/14376473/what-are-good-ways-to-prevent-sql-injection"
                string query = "UPDATE Asset SET Name = @Name, Model = @Model, Manufacturer = @Manufacturer, Type = @Type, IP_Address = @IPAddress, Purchase_Date = @PurchaseDate, Text_Note = @Note, Employee_ID = @EmpID WHERE A_ID = @ID";

                MySqlCommand command = new MySqlCommand(query, conn);

                // Adding the values in the placeholder
                command.Parameters.AddWithValue("@Name", newAsset.Name);
                command.Parameters.AddWithValue("@Model", newAsset.Model);
                command.Parameters.AddWithValue("@Manufacturer", newAsset.Manufacturer);
                command.Parameters.AddWithValue("@Type", newAsset.Type);
                command.Parameters.AddWithValue("@IPAddress", newAsset.IPAddress);

                //checks if the purchase date has a default value or not so it can input null value in the database
                if (newAsset.PurchaseDate == default(DateTime))
                {
                    command.Parameters.AddWithValue("@PurchaseDate", null);
                }
                else
                {
                    command.Parameters.AddWithValue("@PurchaseDate", newAsset.PurchaseDate);
                }

                command.Parameters.AddWithValue("@Note", newAsset.Note);
                command.Parameters.AddWithValue("@EmpID", newAsset.EmployeeID);
                command.Parameters.AddWithValue("@ID", ID);

                //Executes the query
                int rowsAffected = command.ExecuteNonQuery();

                //Displays if the user data has been inserted or not
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Updated Sucessfully");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }

            }
            catch (Exception ex) // catch any error from above block
            {
                MessageBox.Show(ex.Message);

            }

        }
        public void DeleteAsset() { /* Implementation */ }
    }
}
