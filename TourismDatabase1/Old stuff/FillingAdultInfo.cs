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
    public partial class FillingAdultInfo : AppStates1
    {
        private string AddTravellersInfo = "Insert into tourismdatabase.travellers_info(aid, tid, ssn, name, PassportNumber, PhoneNumber, Country, BirthDate, Gender) " +
                    "values(@aid, @tid, @ssn, @name, @PassportNumber, @PhoneNumber, @Country, @BirthDate, @Gender)";
        //private MySqlConnection connection = null;
        //private MySqlCommand cmd = null;
        public FillingAdultInfo()
        {
            InitializeComponent();
            AppStates.connection = ConnectionSingleton.getInstance();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //do the query here
            try
            {
                //AppStates.connection = ConnectionSingleton.getInstance();
                AppStates.getConnectionInstance();
                //AppStates.connection = new MySqlConnection();
                //AppStates.connection.Open();
                AppStates.getConnectionInstance().Open();
                AppStates.cmd = new MySqlCommand(AddTravellersInfo, AppStates.connection);
                AppStates.cmd.Parameters.AddWithValue("@aid", AppStates.userId);
                AppStates.cmd.Parameters.AddWithValue("@tid", AppStates.TourID);
                AppStates.cmd.Parameters.AddWithValue("@ssn", SSNTextBox.Text);
                AppStates.cmd.Parameters.AddWithValue("@name", NameTextBox.Text);
                AppStates.cmd.Parameters.AddWithValue("@PassportNumber", PassportTextBox.Text);
                AppStates.cmd.Parameters.AddWithValue("@PhoneNumber", PnumberTextBox.Text);
                AppStates.cmd.Parameters.AddWithValue("@Country", NationalityComboBox.SelectedItem.ToString());
                AppStates.cmd.Parameters.AddWithValue("@Birthdate", BirthDatePicker.Value.Date.ToString("yyyy-MM-dd"));
                AppStates.cmd.Parameters.AddWithValue("@Gender", GenderSelection.SelectedItem.ToString());
                AppStates.cmd.ExecuteNonQuery();
                //AppStates.connection.Close();
                AppStates.getConnectionInstance().Clone();
                MessageBox.Show("Add travellers info successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
