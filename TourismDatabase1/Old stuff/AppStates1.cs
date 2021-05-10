using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TourismDatabase1
{
    public partial class AppStates1 : UserControl
    {
        public static bool isLogin = false;
        public static string userName = "";
        public static string userId = "";
        public static string TourID = "";
        public static int No_of_adults = 0;
        public static string children_price = "";
        public static string adult_price = "";
        public static string money_sum = "";

        public static string Tourname = "";

        public static MySqlConnection connection = null;
        public static MySqlDataAdapter adapter = null;
        public static DataTable dtb = null;
        public static MySqlCommand cmd = null;
        public static MySqlDataReader dataReader = null;
        public static FillingChildrenInfo childrenInfo = null;
        public static FillingAdultInfo adultInfo = null;
        public static LoginForm loginForm = null;
        public static Profile profile = null;
        public static RegisterForm registerForm = null;
        public static UserMainFrame userMainFrame = null;


        public MySqlConnection getConnectionInstance()
        {
            //return connection;
            return ConnectionSingleton.getInstance();
        }

        public MySqlDataAdapter getAdapter(string query, MySqlConnection connection)
        {
            return new MySqlDataAdapter(query, connection);
        }

        public MySqlCommand getCmd(string query, MySqlConnection connection)
        {
            return new MySqlCommand(query, connection);
        }
        public AppStates1()
        {
            InitializeComponent();
        }

        private void AppStates1_Load(object sender, EventArgs e)
        {
                
        }
    }
}
