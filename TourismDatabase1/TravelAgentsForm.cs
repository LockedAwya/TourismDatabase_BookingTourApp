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
    public partial class TravelAgentsForm : Class1
    {
        private string query = "Insert into travel_agent(name, birthdate, gender, country, phonenumber, age) " +
                    "values(@name, @birthdate, @gender, @country, @phonenumber, @age)";
        private int age = 0;
        public TravelAgentsForm()
        {
            InitializeComponent();
        }

        private void AddTourButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = base.getConnectionInstance();
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                //cmd.Parameters.AddWithValue("@aid", userId);
                cmd.Parameters.AddWithValue("@name", NameBox.Text);
                cmd.Parameters.AddWithValue("@birthdate", BirthDatePicker.Value.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@gender", GenderSelection.Text);
                cmd.Parameters.AddWithValue("@country", NationalityComboBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PhoneNumber", PNumberBox.Text);
                cmd.Parameters.AddWithValue("@age", this.age);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add Travel Agents info successfully!!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void BirthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = BirthDatePicker.Value;
            DateTime currentTime = DateTime.Now;
            TimeSpan Tspan = currentTime - from;
            double days = Tspan.TotalDays;
            this.age = ((int)days / 365);
        }
    }
}
