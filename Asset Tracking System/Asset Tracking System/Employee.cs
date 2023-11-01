using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_System
{
    internal class Employee
    { 
        private string Fname { get; set; }
        private string Lname { get; set; }
        private string Email { get; set; }
        private string Department { get; set; }

        private dbConManagement dbManager;

        public Employee(dbConManagement conn)
        {
            dbManager = conn;
        }


        public void AddEmployee(Employee newEmp)
        {
            MySqlConnection conn = dbManager.GetConnection(); // set a connection variable
            DataTable dt = new DataTable();

            try // try executing this block
            {
                //added placeholder so that it protect against sql injection attack
                string query = "INSERT INTO Employee(FirstName,LastName,Email,Department) VALUES (@Name, @Model, @Manufacturer, @Type, @IPAddress, @PurchaseDate, @Note)";

                MySqlCommand command = new MySqlCommand(query, conn);

                // Adding the values in the placeholder
                command.Parameters.AddWithValue("@Name", newEmp.Fname);
                command.Parameters.AddWithValue("@Model", newEmp.Lname);
                command.Parameters.AddWithValue("@Manufacturer", newEmp.Email);
                command.Parameters.AddWithValue("@Type", newEmp.Department);


                int rowsAffected = command.ExecuteNonQuery();

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

        public DataTable ViewEmp()
        {
            MySqlConnection conn = dbManager.GetConnection(); // set a connection variable
            DataTable dt = new DataTable();

            try // try executing this block
            {

                string query = "SELECT * FROM Employee";

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
