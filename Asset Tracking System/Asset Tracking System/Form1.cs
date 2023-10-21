using System.Data.SqlClient; // when accessing the database
using System.Data.SqlTypes; // when retrieving from database
using System.Data; // for different data containers


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
            SqlConnection conn; // set a connection variable
                                
            // information about the server and database to connect to
            string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = sql2102230; User ID = sql2102230; Password = v8Fksm9zWUEm";

            // initialize the connection variable with this information
            conn = new SqlConnection(connString);

            try // try executing this block
            {
                conn.Open(); // open the connection
                MessageBox.Show("Connection");
                // DO WHATEVER
                
                conn.Close(); // close the connection
                Console.WriteLine("\nConnection successfully terminated.");
            }
            catch (Exception ex) // catch any error from above block
            {
                 Console.WriteLine(ex.Message);
            }

        }
    }
}