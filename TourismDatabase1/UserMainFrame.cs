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
    public partial class UserMainFrame : Class1
    {
        private LoginForm login = null;
        private string query3 = "call getTourRecords();";
        private static UserMainFrame userMainFrame = new UserMainFrame();
        private BookingTourSection userControl1 = null;
        private Profile profile = null;
        private BookingHistory bookingHistory = null;
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
            label1.Text += " " + AppStates1.userName;
            IDLabel.Text += " " + AppStates1.userId;
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
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displayData();
        }

        private void displayAllData()
        {
            dtb = base.getDataTable();
            connection = base.getConnectionInstance();
            if (AppStates.isLogin == true)
            {
                adapter = new MySqlDataAdapter(query3, connection);
                adapter.Fill(dtb);
                dataGridView1.DataSource = dtb;
                connection.Close();
            }
        }

        private void displaySearchData()
        {
            dtb = base.getDataTable();
            connection = base.getConnectionInstance();
            string search = "call get_records('" + SearchBox.Text + "')";
            if (AppStates.isLogin == true)
            {
                //cmd = new MySqlCommand(search, connection);
                cmd = base.getCmd(search, connection);
                cmd.Parameters.AddWithValue("@data", SearchBox.Text);
                //adapter = new MySqlDataAdapter(search, connection);
                adapter = base.getAdapter(search, connection);
                adapter.Fill(dtb);
                dataGridView1.DataSource = dtb;
                connection.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_TourBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            AppStates1.TourID = ID_TourBox.Text;
            TourNameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            AppStates1.Tourname = TourNameBox.Text;
            Country_Box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            DescriptionBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            PolicyBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            StartDateBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            EndDateBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            StartDestBox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            EndDestBox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            ChildrenPriceBox.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            AppStates1.children_price = ChildrenPriceBox.Text;
            AdultPriceBox.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            AppStates1.adult_price = AdultPriceBox.Text;
            FlightBrandBox.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            TA_NameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            TA_PNumberBox.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
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
            profile = new Profile();
            panel1.Controls.Add(profile);
            profile.Dock = DockStyle.Fill;
            profile.BringToFront();
        }

        private void UserMainFrame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bookingHistory = new BookingHistory();
            bookingHistory.Show();
        }
    }
}
