using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

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
            if (txtName.Text == "" || txtPass.Text == "")
            {
                lblError.Text = "Please complete all the fields";
            }
            else
            {
                string username = txtName.Text;
                string pass = txtPass.Text;

                try
                {
                    // Initialize the DbConnectionManager with your connection string
                    dbConManager = new dbConManagement();
                    dbConManager.OpenConnection(); // Open the connection when the main form starts

                    MySqlConnection conn = dbConManager.GetConnection(); // set a connection variable

                    string query = "SELECT password FROM User WHERE email = @Username";

                    MySqlCommand command = new MySqlCommand(query, conn);

                    // Adding the values in the placeholder
                    command.Parameters.AddWithValue("@Username", username);

                    //Executes
                    MySqlDataReader data = command.ExecuteReader();

                    if (data.Read())
                    {
                        // Retrieve the hashed password from the reader
                        string hashedPasswordFromDB = data["password"].ToString();


                        // Verify the hashed password using BCrypt
                        if (BCrypt.Net.BCrypt.Verify(pass, hashedPasswordFromDB))
                        {
                            // Authentication successful
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            // Incorrect password
                            lblError.Text = "2sThe credentials are not correct.";
                        }

                    }
                    else
                    {
                        // Couldnt find username
                        lblError.Text = "The credentials are not correct.";
                    }


                }
                catch (Exception ex)
                {

                    lblError.Text = ex.Message;
                }
            }
        }

        private void cbs_CheckedChanged(object sender, EventArgs e)
        {
            if (cbs.Checked)
            {
                // If the CheckBox is checked, show the password
                txtPass.PasswordChar = '\0'; // Set to '\0' (null character) to show the password
            }
            else
            {
                // If the CheckBox is not checked, hide the password
                txtPass.PasswordChar = '*'; // Set to any character you prefer for password hiding
            }
        }
    }
}
