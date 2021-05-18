using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismDatabase1
{
    public partial class BookingHistory : Class1
    {
        public BookingHistory()
        {
            InitializeComponent();
        }

        private void BookingHistory_Load(object sender, EventArgs e)
        {

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                dtb = base.getDataTable();
                connection = base.getConnectionInstance();
                dataGridView1.Refresh();
                dataGridView1.Update();
                string query = "select * from travellers_info where aid = '" + AppStates1.userId + "'";
                cmd = base.getCmd(query, connection);
                adapter = base.getAdapter(query, connection);
                adapter.Fill(dtb);
                dataGridView1.DataSource = dtb;
                connection.Close();
            }
            else
            {
                dtb = base.getDataTable();
                connection = base.getConnectionInstance();
                dataGridView1.Refresh();
                dataGridView1.Update();
                string query = "call ViewBookingActivity" + "('" + AppStates1.userId + "','" + SearchBox.Text + "');";
                cmd = base.getCmd(query, connection);
                adapter = base.getAdapter(query, connection);
                adapter.Fill(dtb);
                dataGridView1.DataSource = dtb;
                connection.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                dtb = base.getDataTable();
                connection = base.getConnectionInstance();
                MessageBox.Show("That tour is not available in your booking list. Please book it.");
                connection.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to cancel your tour?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dtb = base.getDataTable();
                        connection = base.getConnectionInstance();
                        string query = "call DeleteABookingActivity" + "('" + AppStates1.userId + "','" + SearchBox.Text + "');";
                        cmd = base.getCmd(query, connection);
                        adapter = base.getAdapter(query, connection);
                        adapter.Fill(dtb);
                        dataGridView1.DataSource = dtb;
                        dataGridView1.Refresh();
                        dataGridView1.Update();
                        connection.Close();
                    }
                    catch (Exception err)
                    {

                    }
                    finally
                    {
                        connection = base.getConnectionInstance();
                        connection.Open();
                        string query = "delete from paymenttype where aid = " + AppStates1.userId + " and tid = '" + SearchBox.Text + "';";
                        cmd = base.getCmd(query, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
        }
    }
}

