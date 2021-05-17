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
    public partial class changePasswordForm : Class1
    {
        private string query = "select id, username, password from account where id ='" + AppStates1.userId + "'";
        protected MySqlCommand cmd1 = null;
        public changePasswordForm()
        {
            InitializeComponent();
        }

        private void SaveBox_Click(object sender, EventArgs e)
        {
            connection = base.getConnectionInstance();
            connection.Open();
            //change password successfully
            //string hashPassword = VerifyPasswordBox.GetHashCode().ToString();
            //Hashing.ComputeSha256Hash(VerifyPasswordBox.Text)
            //Hashing.ComputeSha256Hash(newPassword.Text)
            //if (VerifyPasswordBox.Text != newPassword.Text)
            if (VerifyPasswordBox.Text != newPassword.Text)
            {
                MessageBox.Show("Please do again");
                connection.Close();
            } else
            {
                string query1 = "update account set password ='" + Hashing.ComputeSha256Hash(VerifyPasswordBox.Text) + "'" + "where id ='" + AppStates1.userId + "'";
                cmd1 = base.getCmd(query1, connection);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Update password successfully!");
                connection.Close();
            }
            connection.Close();
        }

        private void changePasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
