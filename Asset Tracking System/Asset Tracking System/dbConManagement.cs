using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_System
{
    public class dbConManagement
    {
        private MySqlConnection connection;
        private string connStr = Environment.GetEnvironmentVariable("DatabaseConn");

        public dbConManagement()
        {
            connection = new MySqlConnection(connStr);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
                
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception c)
                {
                    MessageBox.Show(c.Message);
                }
                
            }
        }
    }
}
