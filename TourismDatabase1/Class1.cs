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

        public static void getSQLInstance(string name)
        {
            
        }
    }
}
