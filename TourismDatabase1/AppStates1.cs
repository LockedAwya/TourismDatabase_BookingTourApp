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
        protected int no_of_children = 0;

        public static string Tourname = "";
        public static int no_of_adults = 0;
        public static DateTime getCurrentTime = DateTime.Now;
        public static string info_num = "";
        protected int age = 0;

        protected MySqlConnection connection = null;
        protected MySqlDataAdapter adapter = null;
        protected DataTable dtb = null;
        protected MySqlCommand cmd = null;
        protected MySqlCommand cmd2 = null;
        protected MySqlDataReader dataReader = null;
        protected FillingChildrenInfo childrenInfo = null;
        protected FillingAdultInfo adultInfo = null;
        protected LoginForm loginForm = null;
        protected Profile profile = null;
        protected RegisterForm registerForm = null;
        protected UserMainFrame userMainFrame = null;
        public static bool adultsAdded = false;
        public static bool childrenAdded = false;
        public static string payment = "";


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
