using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Asset_Tracking_System
{
    public partial class AddA : Form
    {
        private Asset asset;
        private int aid = -1;

        private dbConManagement dbConManager;
        private Employee emp;

        public AddA()
        {
            InitializeComponent();

            // Initialize the DbConnectionManager with your connection string
            dbConManager = new dbConManagement("Data Source = lochnagar.abertay.ac.uk; Initial Catalog = sql2102230; User ID = sql2102230; Password = v8Fksm9zWUEm");
            dbConManager.OpenConnection(); // Open the connection when the main form starts


            emp = new Employee(dbConManager);
            asset = new Asset(dbConManager);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddA_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = emp.ViewEmp();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //
            ManagementObjectSearcher search = new("SELECT * FROM Win32_ComputerSystem");


            foreach (var item in search.Get())
            {
                txtName.Text = item["Name"].ToString();
                txtMan.Text = item["Manufacturer"].ToString();
                txtModel.Text = item["Model"].ToString();
                txtType.Text = item["Type"].ToString();
                //txtIp.Text
            }

            //saves the data in the variable
            asset.Name = txtName.Text.ToString();
            asset.Manufacturer = txtMan.Text;
            asset.Model = txtModel.Text;
            asset.Type = txtType.Text;
            asset.IPAddress = txtIp.Text;

            if (checkBox1.Checked)
            {
                asset.PurchaseDate = dtpPdate.Value;
            }
            else
            {
                asset.PurchaseDate = default(DateTime);
            }

            asset.Note = txtNote.Text;


            if (dataGridView1.SelectedRows.Count > 0)
            {

                //gets employee id
                int eID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value);

                MySqlConnection conn = asset.dbManager.GetConnection(); // set a connection variable
                DataTable dt = new DataTable();

                try // try executing this block
                {
                    //Adds asset
                    aid = asset.AddAsset(asset, eID);

                    /*
                    //added placeholder so that it protect against sql injection attack
                    string query = "INSERT INTO Assign(Asset_id,Employee_id) VALUES (@AID, @EID)";

                    MySqlCommand command = new MySqlCommand(query, conn);

                    // Adding the values in the placeholder
                    command.Parameters.AddWithValue("@AID", aid);
                    command.Parameters.AddWithValue("@EID", eID);


                    int rowsAffected = command.ExecuteNonQuery();



                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data Inserted Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Insertion Failed");
                    }
                    */

                }
                catch (Exception ex) // catch any error from above block
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Please Select an Employee to assign");
            }



        }

        private void dtpPdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dtpPdate.Visible = true;
            }
            else
            {
                dtpPdate.Visible = false;
            }
        }
    }
}
