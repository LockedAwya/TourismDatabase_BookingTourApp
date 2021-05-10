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
    public partial class Form1 : Form
    {
        string connectionString = "datasource = localhost; username=root; password=; database=tourismdatabase";
        string query1 = "Select * from tour";
        string query2 = "Select * from account";
        DataTable dtb = null;
        DataTable dtb2 = null;
        MySqlConnection connection = null;
        MySqlDataAdapter adapter = null;
        public Form1()
        {
            InitializeComponent();
            dtb = new DataTable();
            dtb2 = new DataTable();
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database_connection("tour");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database_connection("account");
        }

        private void database_connection(string connection_type)
        {
            try
            {
                if (connection_type.Equals("tour"))
                {
                    adapter = new MySqlDataAdapter(query1, connection);
                    adapter.Fill(dtb);
                    dataGridView1.DataSource = dtb;
                    MessageBox.Show("You are now connected");
                } else if (connection_type.Equals("account"))
                {
                    adapter = new MySqlDataAdapter(query2, connection);
                    adapter.Fill(dtb2);
                    dataGridView2.DataSource = dtb2;
                    MessageBox.Show("You are now connected");
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
