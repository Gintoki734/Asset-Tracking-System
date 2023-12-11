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
using System.Net;
using System.Net.Sockets;

namespace Asset_Tracking_System
{
    public partial class AddA : Form
    {
        private Asset asset;
        private dbConManagement dbConManager;
        private Employee emp;
        private SoftwareAsset soft;

        // Get current date without the time component
        DateTime currentDateOnly = DateTime.Today;

        public AddA()
        {
            InitializeComponent();

            // Initialize the DbConnectionManager with your connection string
            dbConManager = new dbConManagement();
            dbConManager.OpenConnection(); // Open the connection when the main form starts


            emp = new Employee(dbConManager);
            asset = new Asset(dbConManager);
            soft = new SoftwareAsset(dbConManager);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddA_Load(object sender, EventArgs e)
        {
            //get the data from the system, learned from this website "https://csharp.hotexamples.com/examples/System.Management/ManagementObjectSearcher/-/php-managementobjectsearcher-class-examples.html"
            ManagementObjectSearcher search = new("SELECT * FROM Win32_ComputerSystem");

            //displays the data to the user
            foreach (ManagementObject item in search.Get())
            {
                //Hardware
                txtName.Text = item["Name"].ToString();
                txtMan.Text = item["Manufacturer"].ToString();
                txtModel.Text = item["Model"].ToString();
                txtType.Text = item["SystemType"].ToString();
                break;
            }

            //get the data from the system, learned from this website "https://csharp.hotexamples.com/examples/System.Management/ManagementObjectSearcher/-/php-managementobjectsearcher-class-examples.html"
            search = new("SELECT * FROM Win32_OperatingSystem");

            //displays the data to the user
            foreach (ManagementObject item in search.Get())
            {
                //Software
                txtOn.Text = item["Caption"].ToString();
                txtOv.Text = item["Version"].ToString();
                txtOm.Text = item["Manufacturer"].ToString();
                txtIns.Text = currentDateOnly.ToString("yyyy-MM-dd");
                break;
            }



            //gets the ip adress and displays it to the user, leanred from this website "https://stackoverflow.com/questions/6803073/get-local-ip-address"
            IPHostEntry host;
            string localIp = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    txtIp.Text = ip.ToString();
                }
            }

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

            //saves the data in the variable
            asset.Name = txtName.Text;
            asset.Manufacturer = txtMan.Text;
            asset.Model = txtModel.Text;
            asset.Type = txtType.Text;
            asset.IPAddress = txtIp.Text;

            //checks if the asset has purchase date or not
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
                asset.EmployeeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["EmployeeID"].Value);

                // Assign values from TextBox controls to SoftwareAsset properties
                soft.OSName = txtOn.Text;
                soft.OSVersion = txtOv.Text;
                soft.Manufacturer = txtOm.Text;
                soft.InstallationDate = currentDateOnly;

                try // try executing this block
                {
                    //Adds software
                    int s = soft.AddSoftwareAsset(soft);

                    if (s > 0)
                    {
                        //Adds asset
                        asset.AddAsset(asset, s);
                    }

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
            //Cheks if the user wants to add purchase date or not
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
