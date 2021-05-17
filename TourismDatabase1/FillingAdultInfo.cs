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
        private string AddTravellersInfo = "Insert into tourismdatabase.travellers_info(aid, tid, ssn, name, PassportNumber, PhoneNumber, Country, BirthDate, Gender, age) " +
                    "values(@aid, @tid, @ssn, @name, @PassportNumber, @PhoneNumber, @Country, @BirthDate, @Gender, @age)";
        private int age = 0;
        string query = "Insert into tourismdatabase.paymenttype(aid, tid, paymentmethod) " +
                    "values(@aid, @tid, @paymentmethod)";
        public FillingAdultInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            Info.Text += " " + AppStates1.info_num;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection = ConnectionSingleton.getInstance();
                connection.Open();
                if (string.IsNullOrEmpty(SSNTextBox.Text) || string.IsNullOrEmpty(PassportTextBox.Text)) 
                {
                    MessageBox.Show("Your SSN or PassportNumber is missing.");
                    connection.Close();
                }
                if (base.age < 14)
                {
                    MessageBox.Show("This section is for filling out people over 14 only!");
                    connection.Close();
                }
                else
                {
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
                    cmd.Parameters.AddWithValue("@age", base.age);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Add adults info successfully!!!");
                    NameTextBox.ReadOnly = true;
                    PnumberTextBox.ReadOnly = true;
                    PassportTextBox.ReadOnly = true;
                    BirthDatePicker.Refresh();
                    button1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void BirthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            base.age = age;
            DateTime from = BirthDatePicker.Value;
            DateTime currentTime = DateTime.Now;
            TimeSpan Tspan = currentTime - from;
            double days = Tspan.TotalDays;
            base.age = ((int)days / 365);
            Console.WriteLine("Age is: " + base.age);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = base.getConnectionInstance();
                connection.Open();
                string query = "delete from travellers_info where passportnumber = '" + PassportTextBox.Text + "'";
                cmd = base.getCmd(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully!");
                connection.Close();
                SSNTextBox.ReadOnly = false;
                NameTextBox.ReadOnly = false;
                PassportTextBox.ReadOnly = false;
                PnumberTextBox.ReadOnly = false;
                BirthDatePicker.Refresh();
                button1.Visible = true;
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
