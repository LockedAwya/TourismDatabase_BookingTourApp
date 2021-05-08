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
    public partial class LoginForm : Form
    {
        private RegisterForm register = null;
        private UserMainFrame mainFrame = null;
        //private MySqlConnection connection = null;
        //private MySqlCommand cmd = null;
        private string getInfoQueryWithUsername = "Select * from account where username = @username and password = @password";
        private bool isLogin = false;
        private static LoginForm loginForm = new LoginForm();

        public bool getisLogin()
        {
            return isLogin;
        }
        public LoginForm()
        {
            InitializeComponent();
            //connection = ConnectionSingleton.getInstance();
            AppStates.connection = ConnectionSingleton.getInstance();
        }

        public static LoginForm getInstance()
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
            }
            return loginForm;
        }

        private string isLoggedIn()
        {

            return "";
        }

        private void LoginBox_Click(object sender, EventArgs e)
        {
            //if logged in successfully, direct to the main frame
            if (UsernameBox1.Equals("") || passwordTextBox.Equals(""))
            {
                //loggedSuccess = false;
                AppStates.isLogin = false;
            } else
            {
                try
                {
                    //connection = ConnectionSingleton.getInstance();
                    //connection.Open();
                    AppStates.connection.Open();
                    AppStates.cmd = new MySqlCommand(getInfoQueryWithUsername, AppStates.connection);
                    AppStates.cmd.Parameters.AddWithValue("@username", UsernameBox1.Text);
                    AppStates.cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                    //connection.Open();
                    MySqlDataReader dataReader = AppStates.cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        AppStates.isLogin = true;
                        MessageBox.Show("Login successfully");
                        while(dataReader.Read())
                        {
                            if (dataReader["username"].ToString() == UsernameBox1.Text)
                            {
                                AppStates.userName = UsernameBox1.Text;
                                Console.WriteLine("Account name is " + AppStates.userName);
                                AppStates.userId = dataReader["id"].ToString();
                                Console.WriteLine("Account id is " + AppStates.userId);
                            }
                        }
                        AppStates.connection.Close();
                        this.Hide();
                        mainFrame = new UserMainFrame();
                        mainFrame.Show();
                    } else
                    {
                        MessageBox.Show("Invalid Username or password");
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
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
    }
}
