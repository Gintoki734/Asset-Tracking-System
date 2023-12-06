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
        private string connStr = "Data Source = lochnagar.abertay.ac.uk; Initial Catalog = sql2102230; User ID = sql2102230; Password = v8Fksm9zWUEm";

        public dbConManagement()
        {
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
