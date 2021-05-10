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
    public partial class FillingChildrenInfo : UserControl
    {
        private string AddTravellersInfo = "Insert into tourismdatabase.travellers_info(aid, tid, ssn, name, PassportNumber, PhoneNumber, Country, BirthDate, Gender) " +
                    "values(@aid, @tid, @ssn, @name, @PassportNumber, @PhoneNumber, @Country, @BirthDate, @Gender)";
        public FillingChildrenInfo()
        {
            InitializeComponent();
            AppStates.connection = ConnectionSingleton.getInstance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AppStates.connection = ConnectionSingleton.getInstance();
                //AppStates.connection = new MySqlConnection();
                AppStates.connection.Open();
                AppStates.cmd = new MySqlCommand(AddTravellersInfo, AppStates.connection);
                AppStates.cmd.Parameters.AddWithValue("@aid", AppStates.userId);
                AppStates.cmd.Parameters.AddWithValue("@tid", AppStates.TourID);
                AppStates.cmd.Parameters.AddWithValue("@ssn", DBNull.Value);
                AppStates.cmd.Parameters.AddWithValue("@name", NameTextBox.Text);
                AppStates.cmd.Parameters.AddWithValue("@PassportNumber", DBNull.Value);
                AppStates.cmd.Parameters.AddWithValue("@PhoneNumber", PnumberTextBox.Text);
                AppStates.cmd.Parameters.AddWithValue("@Country", NationalityComboBox.SelectedItem.ToString());
                AppStates.cmd.Parameters.AddWithValue("@Birthdate", BirthDatePicker.Value.Date.ToString("yyyy-MM-dd"));
                AppStates.cmd.Parameters.AddWithValue("@Gender", GenderSelection.SelectedItem.ToString());
                AppStates.cmd.ExecuteNonQuery();
                AppStates.connection.Close();
                MessageBox.Show("Add children info successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
