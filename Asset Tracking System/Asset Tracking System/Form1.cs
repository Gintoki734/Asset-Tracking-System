using MySql.Data.MySqlClient; // when accessing the database
using System.Data;
using System.Reflection.Metadata.Ecma335;
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
            dbConManager = new dbConManagement("Data Source = lochnagar.abertay.ac.uk; Initial Catalog = sql2102230; User ID = sql2102230; Password = v8Fksm9zWUEm");
            dbConManager.OpenConnection(); // Open the connection when the main form starts

            asset = new Asset(dbConManager);

            //Displays the asset - I learned to code to work with sql in this website "https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html".
            dataGridView2.DataSource = asset.ViewAsset();


        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}