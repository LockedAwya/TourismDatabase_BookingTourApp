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
            connection = ConnectionSingleton.getInstance();
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
                base.getConnectionInstance().Open();
                cmd = new MySqlCommand(AddTravellersInfo, connection);
                cmd.Parameters.AddWithValue("@aid", userId);
                cmd.Parameters.AddWithValue("@tid", TourID);
                cmd.Parameters.AddWithValue("@ssn", SSNTextBox.Text);
                cmd.Parameters.AddWithValue("@name", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@PassportNumber", PassportTextBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", PnumberTextBox.Text);
                cmd.Parameters.AddWithValue("@Country", NationalityComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Birthdate", BirthDatePicker.Value.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Gender", GenderSelection.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                //AppStates.connection.Close();
                base.getConnectionInstance().Close();
                MessageBox.Show("Add travellers info successfully!!");
                SSNTextBox.ReadOnly = true;
                NameTextBox.ReadOnly = true;
                PassportTextBox.ReadOnly = true;
                PnumberTextBox.ReadOnly = true;
                BirthDatePicker.Refresh();
                button1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
