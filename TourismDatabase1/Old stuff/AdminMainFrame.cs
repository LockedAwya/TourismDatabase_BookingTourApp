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
    public partial class AdminMainFrame : Form
    {
        private static AdminMainFrame adminMainFrame = new AdminMainFrame();
        public AdminMainFrame()
        {
            InitializeComponent();
        }

        public static AdminMainFrame getInstance()
        {
            if (adminMainFrame == null)
            {
                adminMainFrame = new AdminMainFrame();
            }
            return adminMainFrame;
        }

        private void showtravelagentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
