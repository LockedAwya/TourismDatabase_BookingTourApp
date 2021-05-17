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
    public partial class RegisterForm : Class1
    {
        //aes_decrypt(@password, @password);
        string query3 = "Insert into tourismdatabase.account(name, username, password, phone_number, email, address) " +
                    "values(@name, @username, @password, @phone_number, @email, @address)";
        //MySqlConnection connection = null;
        LoginForm loginForm = null;
        public RegisterForm()
        {
            InitializeComponent();
            try
            {
                //connection = ConnectionSingleton.getInstance();
                connection = base.getConnectionInstance();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //string encryptedPassword = Hashing.ComputeSha256Hash(PasswordBox.Text);
                //AppStates.hashedPass = Hashing.ComputeSha256Hash(PasswordBox.Text);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query3, connection);
                cmd.Parameters.AddWithValue("@name", NameBox.Text);
                cmd.Parameters.AddWithValue("@username", UsernameBox.Text);
                cmd.Parameters.AddWithValue("@password", Hashing.ComputeSha256Hash(PasswordBox.Text)); 
                cmd.Parameters.AddWithValue("@phone_number", PhoneNumberBox.Text);
                cmd.Parameters.AddWithValue("@email", EmailBox.Text);
                cmd.Parameters.AddWithValue("@address", AddressBox.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Register successfully!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private static RegisterForm RegisterInstance = new RegisterForm();
        public static RegisterForm getInstance()
        {
            if (RegisterInstance == null)
            {
                RegisterInstance = new RegisterForm();
            }
            return RegisterInstance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInSection_Click(object sender, EventArgs e)
        {
            loginForm = LoginForm.getInstance();
            this.Hide();
            loginForm.Show();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
