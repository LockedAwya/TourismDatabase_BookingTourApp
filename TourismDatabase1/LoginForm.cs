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
using System.Security.Cryptography;

namespace TourismDatabase1
{
    public partial class LoginForm : Class1
    {
        private RegisterForm register = null;
        private UserMainFrame mainFrame = null;
        private string getInfoQueryWithUsername = "Select * from account where username = @username and password = @password";
        //private string getInfoQueryWithUsername = "Select * from account where username = @username and password = aes_encrypt(@password, @password)";
        //aes_encrypt(@password, @password);
        private bool isLogin = false;
        private static LoginForm loginForm = new LoginForm();
        private AdminMainFrame adminMainFrame = null;

        public bool getisLogin()
        {
            return isLogin;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        public static LoginForm getInstance()
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
            }
            return loginForm;
        }
        private void LoginBox_Click(object sender, EventArgs e)
        {
            connection = base.getConnectionInstance();
            //if logged in successfully, direct to the main frame
            if (UsernameBox1.Text == "" || passwordTextBox.Text == "")
            {
                //loggedSuccess = false;
                AppStates1.isLogin = false;
                connection.Close();

            }
            else
            {
                try
                {
                    connection.Open();
                    cmd = base.getCmd(getInfoQueryWithUsername, connection);
                    cmd.Parameters.AddWithValue("@username", UsernameBox1.Text);
                    //cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", Hashing.ComputeSha256Hash(passwordTextBox.Text));
                    //connection.Open();
                    //admin login
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        AppStates.isLogin = true;
                        MessageBox.Show("Login successfully");
                        while(dataReader.Read())
                        {
                            if (dataReader["username"].ToString() == UsernameBox1.Text)
                            {
                                AppStates1.userName = UsernameBox1.Text;
                                Console.WriteLine("Account name is " + userName);
                                AppStates1.userId = dataReader["id"].ToString();
                                Console.WriteLine("Account id is " + userId);
                            }
                        }
                        connection.Close();
                        this.Hide();
                        mainFrame = new UserMainFrame();
                        mainFrame.Show();
                    } else
                    {
                        MessageBox.Show("Invalid Username or password");
                        connection.Close();
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    connection.Close();
                }
            }
        }

        private void RegisterBox_Click(object sender, EventArgs e)
        {
            //when you click this, it will open up a register tab
            register = RegisterForm.getInstance();
            this.Hide();
            register.Show();
        }

        private void EmailOrUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
