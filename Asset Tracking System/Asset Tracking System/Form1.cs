//DONE DATE: 15/12/2023

using MySql.Data.MySqlClient; // when accessing the database
using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
//using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;



namespace Asset_Tracking_System
{

    public partial class Form1 : Form
    {
        private dbConManagement dbConManager;
        private Asset asset;
        private SoftwareAsset soft;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Initialize the DbConnectionManager with your connection string
            dbConManager = new dbConManagement();
            dbConManager.OpenConnection(); // Open the connection when the main form starts

            asset = new Asset(dbConManager);
            soft = new SoftwareAsset(dbConManager);

            //Displays the asset - I learned to code to work with sql in this website "https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html".
            dataGridView2.DataSource = asset.ViewAsset();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {
                //Hardware
                asset.Name = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Name"].Value);
                asset.Manufacturer = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Manufacturer"].Value);
                asset.Model = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Model"].Value);
                asset.Type = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Type"].Value);
                asset.IPAddress = Convert.ToString(dataGridView2.SelectedRows[0].Cells["IP_Address"].Value);
                asset.PurchaseDate = dataGridView2.SelectedRows[0].Cells["Purchase_Date"].Value as DateTime? ?? default(DateTime);
                asset.Note = dataGridView2.SelectedRows[0].Cells["Text_Note"].Value?.ToString() ?? "";
                asset.EmployeeID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Employee_ID"].Value);
                //Software
                soft.OSName = Convert.ToString(dataGridView2.SelectedRows[0].Cells["OSName"].Value);
                soft.OSVersion = Convert.ToString(dataGridView2.SelectedRows[0].Cells["OSVersion"].Value);
                soft.Manufacturer = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Software_Manufacturer"].Value);
                soft.InstallationDate = Convert.ToDateTime(dataGridView2.SelectedRows[0].Cells["InstallationDate"].Value);

                int aID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["A_ID"].Value);
                int SID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["S_ID"].Value);

                // Takes the user to the next form
                this.Hide();
                EditA A = new EditA(asset, soft, aID, SID);
                A.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Please, Select an Asset to edit");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddAsset_Click(object sender, EventArgs e)
        {
            //Takes the user to the next form
            this.Hide();
            AddA sistema = new AddA();
            sistema.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //DELETE ThE ROW OF SELECTED DATA
            if (dataGridView2.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["A_ID"].Value);
                int sid = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["S_ID"].Value);

                try
                {
                    asset.DeleteAsset(id);
                    soft.DeleteSasset(sid);

                }
                catch (Exception no)
                {

                    MessageBox.Show(no.Message);
                }

                dataGridView2.DataSource = asset.ViewAsset();

            }
            else
            {
                MessageBox.Show("Please, Select an Asset to delete");
            }
        }

        private async void btnV_Click(object sender, EventArgs e)
        {
            //Clears the richtextbox
            richTextBox1.Clear();
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    string version = Convert.ToString(dataGridView2.SelectedRows[0].Cells["OSVersion"].Value);

                    // Extracting Windows version and build
                    string[] versionParts = version.Split('.');

                    // Extracting major version directly
                    string majorVersion = versionParts[0];

                    // Constructing the link
                    string windowsVersion = $"windows_{majorVersion}:{versionParts[2]}";
                    string link = $"https://services.nvd.nist.gov/rest/json/cves/2.0?cpeName=cpe:2.3:o:microsoft:{windowsVersion}&cvssV3Severity=CRITICAL";

                    using (var client = new HttpClient())
                    {
                        var response = await client.GetStringAsync(link);

                        // Deserialize the JSON response
                        var result = JsonConvert.DeserializeObject<dynamic>(response);

                        // Access the vulnerabilities array
                        var vulnerabilities = result.vulnerabilities;

                        // Display values for each vulnerability
                        foreach (var vulnerability in vulnerabilities)
                        {
                            string cveId = vulnerability.cve.id;
                            string publishedDate = vulnerability.cve.published;
                            string description = vulnerability.cve.descriptions[0].value;

                            richTextBox1.AppendText($"CVE ID: {cveId}\nPublished Date: {publishedDate}\nDescription: {description}\n\n");
                        }

                        //wait for 6 seconds before continuing with the code.
                        MessageBox.Show("Please wait for 6 seconds before continuing with the application");
                        Thread.Sleep(6000);
                        MessageBox.Show("Thanks for the wait, you can continue with the application now");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please, Select an Asset to check vulnerability");
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            dbConManager.CloseConnection();
            Application.Exit();

        }
    }
}