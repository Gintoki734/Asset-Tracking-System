using MySql.Data.MySqlClient; // when accessing the database
using System.Data;

namespace Asset_Tracking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn; // set a connection variable

            // information about the server and database to connect to
            string connString = "Data Source = lochnagar.abertay.ac.uk; Initial Catalog = sql2102230; User ID = sql2102230; Password = v8Fksm9zWUEm";

            // initialize the connection variable with this information
            conn = new MySqlConnection(connString);

            try // try executing this block
            {
                conn.Open(); // open the connection
                MessageBox.Show("Connection");

                string query = "SELECT * FROM Asset";

                MySqlCommand command = new MySqlCommand(query, conn);

                MySqlDataReader data = command.ExecuteReader();

                if (data.HasRows)
                {
                    DataTable dt = new DataTable();

                    dt.Load(data);
                    dataGridView1.DataSource = dt;
                }

                data.Close();

            }
            catch (Exception ex) // catch any error from above block
            {
                MessageBox.Show("Here");
                MessageBox.Show(ex.Message);
            }

        }
    }
}