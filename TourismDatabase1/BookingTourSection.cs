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
    public partial class BookingTourSection : UserControl
    {
        private static BookingTourSection userControl1 = new BookingTourSection();
        private FillingAdultInfo[] listAdult = new FillingAdultInfo[50];
        private FillingChildrenInfo[] listChildren = new FillingChildrenInfo[50];
        private MySqlConnection connection = null;
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
            TournameBox.Text = AppStates.Tourname;
            TourIDBox.Text = AppStates.TourID;
            ChildrenPriceBox.Text = AppStates.children_price;
            AdultPriceBox.Text = AppStates.adult_price;
        }

        //Back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMainFrame.getInstance();
        }
        
        private void moneyChanged()
        {
            long money = Convert.ToInt64(AppStates.adult_price) * (long)no_of_Adults.Value +
                Convert.ToInt64(AppStates.children_price) * (long)no_of_Children.Value;
            Amount_Money.Text = money.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moneyChanged();
            int initY = 0;
            for (int i = 0; i < no_of_Adults.Value; i++)
            {
                this.listAdult[i] = new FillingAdultInfo();
                if (i == 0)
                {
                    this.listAdult[i].Location = new Point(0, 0);
                    LeftPanel.Controls.Add(listAdult[i]);
                    this.listAdult[i].BringToFront();
                } else
                {
                    this.listAdult[i].Location = new Point(0, initY += 625);
                    LeftPanel.Controls.Add(listAdult[i]);
                    this.listAdult[i].BringToFront();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Travellers_info.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            moneyChanged();
            int initY = 0;
            for (int i = 0; i < no_of_Children.Value; i++)
            {
                this.listChildren[i] = new FillingChildrenInfo();
                if (i == 0)
                {
                    this.listChildren[i].Location = new Point(0, 0);
                    rightPanel.Controls.Add(listChildren[i]);
                    this.listChildren[i].BringToFront();
                }
                else
                {
                    this.listChildren[i].Location = new Point(0, initY += 555);
                    rightPanel.Controls.Add(listChildren[i]);
                    this.listChildren[i].BringToFront();
                }
            }
        }
    }
}
