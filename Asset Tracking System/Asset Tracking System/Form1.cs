using MySql.Data.MySqlClient; // when accessing the database
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Asset_Tracking_System
{
    public partial class Form1 : Form
    {
        private dbConManagement dbConManager;
        private Asset asset;
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

            //Displays the asset - I learned to code to work with sql in this website "https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html".
            dataGridView2.DataSource = asset.ViewAsset();

            //dbConManager.CloseConnection();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {

                asset.Name = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Name"].Value);
                asset.Manufacturer = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Manufacturer"].Value);
                asset.Model = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Model"].Value);
                asset.Type = Convert.ToString(dataGridView2.SelectedRows[0].Cells["Type"].Value);
                asset.IPAddress = Convert.ToString(dataGridView2.SelectedRows[0].Cells["IP_Address"].Value);
                asset.PurchaseDate = dataGridView2.SelectedRows[0].Cells["Purchase_Date"].Value as DateTime? ?? default(DateTime);
                asset.Note = dataGridView2.SelectedRows[0].Cells["Text_Note"].Value?.ToString() ?? "";
                asset.EmployeeID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Employee_ID"].Value);

                int aID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["A_Id"].Value);

                // Takes the user to the next form
                this.Hide();
                EditA A = new EditA(asset, aID);
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
            if (dataGridView2.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["A_Id"].Value);

                asset.DeleteAsset(id);

                dataGridView2.DataSource = asset.ViewAsset();

            }
            else
            {
                MessageBox.Show("Please, Select an Asset to delete");
            }
        }
    }
}