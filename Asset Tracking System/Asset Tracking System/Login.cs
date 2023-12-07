using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Tracking_System
{
    public partial class Login : Form
    {
        private dbConManagement dbConManager;

        public Login()
        {
            InitializeComponent();


        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize the DbConnectionManager with your connection string
                dbConManager = new dbConManagement();
                dbConManager.OpenConnection(); // Open the connection when the main form starts



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
