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
using System.Data;

namespace TourismDatabase1
{
    public partial class FillingChildrenInfo : AppStates1
    {
        private string AddTravellersInfo = "Insert into tourismdatabase.travellers_info(aid, tid, ssn, name, PassportNumber, PhoneNumber, Country, BirthDate, Gender) " +
                    "values(@aid, @tid, @ssn, @name, @PassportNumber, @PhoneNumber, @Country, @BirthDate, @Gender)";
        public FillingChildrenInfo()
        {
            InitializeComponent();
            connection = ConnectionSingleton.getInstance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection = ConnectionSingleton.getInstance();
                //AppStates.connection = new MySqlConnection();
                connection.Open();
                cmd = new MySqlCommand(AddTravellersInfo, connection);
                cmd.Parameters.AddWithValue("@aid", userId);
                cmd.Parameters.AddWithValue("@tid", TourID);
                cmd.Parameters.AddWithValue("@ssn", DBNull.Value);
                cmd.Parameters.AddWithValue("@name", NameTextBox.Text);
                cmd.Parameters.AddWithValue("@PassportNumber", DBNull.Value);
                cmd.Parameters.AddWithValue("@PhoneNumber", PnumberTextBox.Text);
                cmd.Parameters.AddWithValue("@Country", NationalityComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Birthdate", BirthDatePicker.Value.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Gender", GenderSelection.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Add children info successfully!!!");
                NameTextBox.ReadOnly = true;
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
