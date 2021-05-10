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
    public partial class Profile : AppStates1
    {
        private static Profile profile = new Profile();
        private string query = "select id, name, username, phone_number, email, address from account where id = '" + AppStates1.userId + "'";

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

        private bool isEdited()
        {
            return NameBox.ReadOnly && PhoneNumberBox.ReadOnly && 
                EmailBox.ReadOnly && AddressBox.ReadOnly;
        }

        private void LoginBox_Click(object sender, EventArgs e)
        {
            connection = base.getConnectionInstance();
            try
            {
                string updateQuery = "update account set " +
                    "name='" + NameBox.Text + "'," + 
                    "phone_number='" + PhoneNumberBox.Text + "'," + 
                    "email='" + EmailBox.Text + "'," + 
                    "address='" + AddressBox.Text + "'" +
                    "where id=" + AppStates1.userId;
                connection.Open();
                cmd = base.getCmd(updateQuery, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Update info successfully!");
                NameBox.ReadOnly = true;
                PhoneNumberBox.ReadOnly = true;
                EmailBox.ReadOnly = true;
                AddressBox.ReadOnly = true;
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userMainFrame = UserMainFrame.getInstance();
            //this.Hide();
            //userMainFrame.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            //dtb = base.getAdapter();
            connection = base.getConnectionInstance();
            connection.Open();
            adapter = base.getAdapter(query, connection);
            cmd = base.getCmd(query, connection);
            AccIDBox.Text = AppStates1.userId;
            UsernameBox.Text = AppStates1.userName;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader["ID"].ToString() == AppStates1.userId)
                {
                    UsernameBox.Text = dataReader["username"].ToString();
                    NameBox.Text = dataReader["name"].ToString();
                    PhoneNumberBox.Text = dataReader["phone_number"].ToString();
                    EmailBox.Text = dataReader["email"].ToString();
                    AddressBox.Text = dataReader["address"].ToString();
                } 
            }
            connection.Close();
            /*ID_TourBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
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
            FlightBrandBox.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();*/
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now you can edit your profile");
            NameBox.ReadOnly = false;
            PhoneNumberBox.ReadOnly = false;
            EmailBox.ReadOnly = false;
            AddressBox.ReadOnly = false;
        }
    }
}
