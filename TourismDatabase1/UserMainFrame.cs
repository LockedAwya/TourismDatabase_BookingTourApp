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
    public partial class UserMainFrame : Form
    {
        private LoginForm login = null;
        private string query1 = "select t.*, fm.flight_name from tour t join flight_manager fm on t.flight_id = fm.flight_id order by t.id";
        private static UserMainFrame userMainFrame = new UserMainFrame();
        private BookingTourSection userControl1 = null;
        private Profile profile = null;
        public UserMainFrame()
        {
            InitializeComponent();
        }

        public static UserMainFrame getInstance()
        {
            if (userMainFrame == null)
            {
                userMainFrame = new UserMainFrame();
            }
            return userMainFrame;
        }

        private void UserMainFrame_Load(object sender, EventArgs e)
        {
            label1.Text += " " + AppStates.userName;
            IDLabel.Text += " " + AppStates.userId;
        }
        /**
         * logout to login
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //return to the login
            AppStates.isLogin = false;
            this.Hide();
            this.Parent = null;
            login = new LoginForm();
            login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3.Text = login.getUserName();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //label3.Text = login.getUserName();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displayData();
        }

        private void displayAllData()
        {
            AppStates.dtb = new DataTable();
            AppStates.connection = ConnectionSingleton.getInstance();
            if (AppStates.isLogin == true)
            {
                AppStates.adapter = new MySqlDataAdapter(query1, AppStates.connection);
                AppStates.adapter.Fill(AppStates.dtb);
                dataGridView1.DataSource = AppStates.dtb;
                MessageBox.Show("You are now connected");
                //BookTourButton.Enabled = false;
                AppStates.connection.Close();
            }
        }

        private void displaySearchData()
        {
            AppStates.dtb = new DataTable();
            AppStates.connection = ConnectionSingleton.getInstance();
            string search = "select t.*, fm.flight_name from tour t join flight_manager fm on t.flight_id = fm.flight_id " + "and id like '%" + SearchBox.Text + "%'" + " or name like '%" + SearchBox.Text + "%'";
            //string searchPrefixTourID = "select * from tour where id like '%" + SearchBox.Text + "%'" + " or name like '%" + SearchBox.Text + "%'";
            if (AppStates.isLogin == true)
            {
                MySqlCommand cmd = new MySqlCommand(search, AppStates.connection);
                cmd.Parameters.AddWithValue("@data", SearchBox.Text);
                AppStates.adapter = new MySqlDataAdapter(search, AppStates.connection);
                AppStates.adapter.Fill(AppStates.dtb);
                dataGridView1.DataSource = AppStates.dtb;
                MessageBox.Show("You are now connected");
                //BookTourButton.Enabled = false;
                AppStates.connection.Close();
            }
            //SearchBox.Text
            //dtb = new DataTable();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_TourBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            AppStates.TourID = ID_TourBox.Text;
            TourNameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            AppStates.Tourname = TourNameBox.Text;
            Country_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            DescriptionBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            PolicyBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            StartDateBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            EndDateBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            StartDestBox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            EndDestBox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            ChildrenPriceBox.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            AppStates.children_price = ChildrenPriceBox.Text;
            AdultPriceBox.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            AppStates.adult_price = AdultPriceBox.Text;
            FlightBrandBox.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID_TourBox.Text != "")
            {
                userControl1 = new BookingTourSection();
                panel1.Controls.Add(userControl1);
                userControl1.Dock = DockStyle.Fill;
                userControl1.BringToFront();
            } else
            {
                MessageBox.Show("Please book a tour!!!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TourNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Country_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PolicyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartDateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndDateBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartDestBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            displayAllData();
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            displaySearchData();
        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {
            profile = Profile.getInstance();
            panel1.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.BringToFront();
        }
    }
}
