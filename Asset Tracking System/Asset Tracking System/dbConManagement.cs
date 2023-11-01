using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Tracking_System
{
    internal class dbConManagement
    {
        private MySqlConnection connection;
        private string connStr;

        public dbConManagement(string connectionString)
        {
            connStr = connectionString;
            connection = new MySqlConnection(connStr);
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
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
                connection.Close();
            }
        }
    }
}
