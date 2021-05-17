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
    public partial class AdminMainFrame : Class1
    {
        private static AdminMainFrame adminMainFrame = new AdminMainFrame();
        TravelAgentsForm travelAgentsForm = null;
        LoginForm login = null;
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

        private void AdminMainFrame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            travelAgentsForm = new TravelAgentsForm();
            travelAgentsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dtb = base.getDataTable();
                connection = base.getConnectionInstance();
                cmd = base.getCmd(QueryBox.Text, connection);
                adapter = base.getAdapter(QueryBox.Text, connection);
                adapter.Fill(dtb);
                dataGridView1.DataSource = dtb;
                MessageBox.Show("You are now connected");
                connection.Close();
                QueryHistory.Text += QueryBox.Text + "\n";
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void AdminMainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            QueryBox.Text = "DELETE FROM `table_name` WHERE condition;";
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            QueryBox.Text = "INSERT INTO table_name (column1, column2, column3, ...)" + 
            "VALUES(value1, value2, value3, ...);";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            QueryBox.Text = "UPDATE table_name " +
            "SET column1 = value1, column2 = value2, ... , " +
            "WHERE condition;";
        }
    }
}
