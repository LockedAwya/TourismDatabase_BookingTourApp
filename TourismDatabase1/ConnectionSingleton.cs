using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TourismDatabase1
{
    class ConnectionSingleton
    {
        private const string connectionString = "datasource = localhost; username=root; password=; database=tourismdatabase";
        private static MySqlConnection connectionInstance = new MySqlConnection(connectionString);
        private ConnectionSingleton()
        {

        }

        public static MySqlConnection getInstance()
        {
            if (connectionInstance == null)
            {
                connectionInstance = new MySqlConnection(connectionString);
            }
            return connectionInstance;
        }
    }
}
