using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismDatabase1
{
    public partial class Profile : UserControl
    {
        private static Profile profile = new Profile();
        UserMainFrame userMainFrame = null;

        public static Profile getInstance()
        {
            if (profile == null)
            {
                profile = new Profile();
            }
            return profile;
        }
        public Profile()
        {
            InitializeComponent();
        }

        private void LoginBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userMainFrame = UserMainFrame.getInstance();
            //this.Hide();
            //userMainFrame.Show();
        }
    }
}
