using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace TourismDatabase1
{
    public class Class1 : Form
    {
        protected MySqlConnection connection = null;
        protected MySqlDataAdapter adapter = null;
        protected DataTable dtb = null;
        protected MySqlCommand cmd = null;

        public static bool isLogin = false;
        public static string userName = "";
        public static string userId = "";
        public static string TourID = "";
        public static int No_of_adults = 0;
        public static string children_price = "";
        public static string adult_price = "";
        public static string money_sum = "";
        public static string info_num = "";

        public static string Tourname = "";
        public static MySqlDataReader dataReader = null;

       
        /*public static FillingChildrenInfo childrenInfo = null;
        public static FillingAdultInfo adultInfo = null;
        public static LoginForm loginForm = null;
        public static Profile profile = null;
        public static RegisterForm registerForm = null;
        public static UserMainFrame userMainFrame = null;*/

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

        public DataTable getDataTable()
        {
            return new DataTable();
        }

        public void getSQLInstance(string name)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Class1
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "Class1";
            this.Load += new System.EventHandler(this.Class1_Load);
            this.ResumeLayout(false);

        }

        private void Class1_Load(object sender, EventArgs e)
        {

        }
    }
}
