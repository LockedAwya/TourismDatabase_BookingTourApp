using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace TourismDatabase1
{
    class AppStates
    {
        public static bool isLogin = false;
        public static string userName = "";
        public static string userId = "";
        public static string TourID = "";
        public static int No_of_adults = 0;
        public static string children_price = "";
        public static string adult_price = "";
        public static string money_sum = "";
        public static string hashedPass = "";
        public static string paymentMethod = "";

        public static string Tourname = "";

        public static MySqlConnection connection = null;
        public static MySqlDataAdapter adapter = null;
        public static DataTable dtb = null;
        public static MySqlCommand cmd = null;
        public static FillingChildrenInfo childrenInfo = null;
        public static FillingAdultInfo adultInfo = null;
        public static LoginForm loginForm = null;
        public static Profile profile = null;
        public static RegisterForm registerForm = null;
        public static UserMainFrame userMainFrame = null;
        

        public static MySqlConnection getConnectionInstance()
        {
            //return connection;
            return ConnectionSingleton.getInstance();
        }

        public static MySqlDataAdapter getAdapter(string query, MySqlConnection connection)
        {
            return new MySqlDataAdapter(query, connection);
        }

        public static MySqlCommand getCmd(string query, MySqlConnection connection)
        {
            return new MySqlCommand(query, connection);
        }
    }
}
