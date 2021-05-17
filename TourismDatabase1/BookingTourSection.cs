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
    public partial class BookingTourSection : AppStates1
    {
        private static BookingTourSection userControl1 = new BookingTourSection();
        private FillingAdultInfo[] listAdult = new FillingAdultInfo[50];
        private FillingChildrenInfo[] listChildren = new FillingChildrenInfo[50];
        string query = "Insert into tourismdatabase.paymenttype(aid, tid, paymentmethod) " +
                    "values(@aid, @tid, @paymentmethod)";
        //System.Windows.Forms.Button b = new Button();
        public BookingTourSection()
        {
            InitializeComponent();
        }

        public static BookingTourSection getInstance()
        {
            if (userControl1 == null)
            {
                userControl1 = new BookingTourSection();
            }
            return userControl1;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            TournameBox.Text = AppStates1.Tourname;
            TourIDBox.Text = AppStates1.TourID;
            ChildrenPriceBox.Text = AppStates1.children_price;
            AdultPriceBox.Text = AppStates1.adult_price;
        }

        //Back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMainFrame.getInstance();
            /*try
            {
                connection = base.getConnectionInstance();
                connection.Open();
                string query = "delete from paymenttype where aid ='" + userId + "' and tid ='" + TourID + "';";
                cmd = base.getCmd(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception err)
            {
                
            }
            finally
            {
                this.Hide();
                UserMainFrame.getInstance();
            }*/
        }
        
        private void moneyChanged()
        {
            long money = Convert.ToInt64(adult_price) * (long)no_of_Adults.Value +
                Convert.ToInt64(children_price) * (long)no_of_Children.Value;
            Amount_Money.Text = money.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Payment.Text))
            {
                MessageBox.Show("You need to choose your payment type first!");
            }
            else
            {
                AppStates1.payment = Payment.SelectedItem.ToString();
                moneyChanged();
                int initY = 0;
                no_of_adults = (int)no_of_Adults.Value;
                for (int i = 0; i < no_of_adults; i++)
                {
                    this.listAdult[i] = new FillingAdultInfo();
                    if (i == 0)
                    {
                        AppStates1.info_num = 1.ToString();
                        this.listAdult[i].Location = new Point(0, 0);
                        LeftPanel.Controls.Add(listAdult[i]);
                        this.listAdult[i].BringToFront();
                    }
                    else
                    {
                        AppStates1.info_num = (i + 1).ToString();
                        this.listAdult[i].Location = new Point(0, initY += 625);
                        LeftPanel.Controls.Add(listAdult[i]);
                        this.listAdult[i].BringToFront();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Travellers_info.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Payment.Text))
            {
                MessageBox.Show("You need to choose your payment type first!");
            }
            else
            {
                AppStates1.payment = Payment.SelectedItem.ToString();
                moneyChanged();
                int initY = 0;
                no_of_children = (int)no_of_Children.Value;
                for (int i = 0; i < no_of_children; i++)
                {
                    this.listChildren[i] = new FillingChildrenInfo();
                    if (i == 0)
                    {
                        //AppStates1.info_num = 1.ToString();
                        this.listChildren[i].Location = new Point(0, 0);
                        rightPanel.Controls.Add(listChildren[i]);
                        this.listChildren[i].BringToFront();
                    }
                    else
                    {
                        AppStates1.info_num = (i + 1).ToString();
                        this.listChildren[i].Location = new Point(0, initY += 555);
                        rightPanel.Controls.Add(listChildren[i]);
                        this.listChildren[i].BringToFront();
                    }
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            /*try
            {
                AppStates1.payment = Payment.SelectedItem.ToString();
                connection = base.getConnectionInstance();
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@aid", userId);
                cmd.Parameters.AddWithValue("@tid", TourID);
                cmd.Parameters.AddWithValue("@paymentmethod", Payment.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Choose payment method successfully!");
            } catch (Exception err)
            {
                //MessageBox.Show(err.Message);
                //connection = base.getConnectionInstance();
                //connection.Open();
                string query = "update paymenttype set paymentmethod = '" + Payment.Text + "' where aid ='" + userId + "' and tid ='" + TourID + "';";
                cmd = base.getCmd(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }*/
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            try
            {
                AppStates1.payment = Payment.SelectedItem.ToString();
                connection = base.getConnectionInstance();
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@aid", userId);
                cmd.Parameters.AddWithValue("@tid", TourID);
                cmd.Parameters.AddWithValue("@paymentmethod", Payment.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Choose payment method successfully!");
                button4.Visible = false;
            } catch (Exception err)
            {
                string query = "update paymenttype set paymentmethod = '" + Payment.Text + "' where aid ='" + userId + "' and tid ='" + TourID + "';";
                cmd = base.getCmd(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
