
namespace TourismDatabase1
{
    partial class UserMainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.BookTourButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PolicyBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.FlightBrandBox = new System.Windows.Forms.TextBox();
            this.AdultPriceBox = new System.Windows.Forms.TextBox();
            this.ChildrenPriceBox = new System.Windows.Forms.TextBox();
            this.EndDestBox = new System.Windows.Forms.TextBox();
            this.StartDateBox = new System.Windows.Forms.TextBox();
            this.StartDestBox = new System.Windows.Forms.TextBox();
            this.EndDateBox = new System.Windows.Forms.TextBox();
            this.TourNameBox = new System.Windows.Forms.TextBox();
            this.Country_Box = new System.Windows.Forms.TextBox();
            this.ID_TourBox = new System.Windows.Forms.TextBox();
            this.TA_Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.Profile_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1325, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 479);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1397, 371);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hello user:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(191, 72);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(95, 24);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // BookTourButton
            // 
            this.BookTourButton.Location = new System.Drawing.Point(760, 449);
            this.BookTourButton.Name = "BookTourButton";
            this.BookTourButton.Size = new System.Drawing.Size(95, 24);
            this.BookTourButton.TabIndex = 38;
            this.BookTourButton.Text = "Book tour";
            this.BookTourButton.UseVisualStyleBackColor = true;
            this.BookTourButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PolicyBox);
            this.panel1.Controls.Add(this.BookTourButton);
            this.panel1.Controls.Add(this.DescriptionBox);
            this.panel1.Controls.Add(this.FlightBrandBox);
            this.panel1.Controls.Add(this.AdultPriceBox);
            this.panel1.Controls.Add(this.ChildrenPriceBox);
            this.panel1.Controls.Add(this.EndDestBox);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.StartDateBox);
            this.panel1.Controls.Add(this.StartDestBox);
            this.panel1.Controls.Add(this.EndDateBox);
            this.panel1.Controls.Add(this.TourNameBox);
            this.panel1.Controls.Add(this.Country_Box);
            this.panel1.Controls.Add(this.ID_TourBox);
            this.panel1.Controls.Add(this.TA_Box);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 865);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PolicyBox
            // 
            this.PolicyBox.Location = new System.Drawing.Point(188, 326);
            this.PolicyBox.Name = "PolicyBox";
            this.PolicyBox.ReadOnly = true;
            this.PolicyBox.Size = new System.Drawing.Size(556, 87);
            this.PolicyBox.TabIndex = 37;
            this.PolicyBox.Text = "";
            this.PolicyBox.TextChanged += new System.EventHandler(this.PolicyBox_TextChanged);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(188, 208);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(556, 110);
            this.DescriptionBox.TabIndex = 36;
            this.DescriptionBox.Text = "";
            this.DescriptionBox.TextChanged += new System.EventHandler(this.DescriptionBox_TextChanged);
            // 
            // FlightBrandBox
            // 
            this.FlightBrandBox.Location = new System.Drawing.Point(922, 322);
            this.FlightBrandBox.Name = "FlightBrandBox";
            this.FlightBrandBox.ReadOnly = true;
            this.FlightBrandBox.Size = new System.Drawing.Size(156, 22);
            this.FlightBrandBox.TabIndex = 35;
            // 
            // AdultPriceBox
            // 
            this.AdultPriceBox.Location = new System.Drawing.Point(922, 268);
            this.AdultPriceBox.Name = "AdultPriceBox";
            this.AdultPriceBox.ReadOnly = true;
            this.AdultPriceBox.Size = new System.Drawing.Size(156, 22);
            this.AdultPriceBox.TabIndex = 34;
            // 
            // ChildrenPriceBox
            // 
            this.ChildrenPriceBox.Location = new System.Drawing.Point(922, 211);
            this.ChildrenPriceBox.Name = "ChildrenPriceBox";
            this.ChildrenPriceBox.ReadOnly = true;
            this.ChildrenPriceBox.Size = new System.Drawing.Size(156, 22);
            this.ChildrenPriceBox.TabIndex = 33;
            // 
            // EndDestBox
            // 
            this.EndDestBox.Location = new System.Drawing.Point(922, 145);
            this.EndDestBox.Name = "EndDestBox";
            this.EndDestBox.ReadOnly = true;
            this.EndDestBox.Size = new System.Drawing.Size(156, 22);
            this.EndDestBox.TabIndex = 32;
            // 
            // StartDateBox
            // 
            this.StartDateBox.Location = new System.Drawing.Point(188, 419);
            this.StartDateBox.Name = "StartDateBox";
            this.StartDateBox.ReadOnly = true;
            this.StartDateBox.Size = new System.Drawing.Size(222, 22);
            this.StartDateBox.TabIndex = 31;
            this.StartDateBox.TextChanged += new System.EventHandler(this.StartDateBox_TextChanged);
            // 
            // StartDestBox
            // 
            this.StartDestBox.Location = new System.Drawing.Point(922, 86);
            this.StartDestBox.Name = "StartDestBox";
            this.StartDestBox.ReadOnly = true;
            this.StartDestBox.Size = new System.Drawing.Size(156, 22);
            this.StartDestBox.TabIndex = 30;
            this.StartDestBox.TextChanged += new System.EventHandler(this.StartDestBox_TextChanged);
            // 
            // EndDateBox
            // 
            this.EndDateBox.Location = new System.Drawing.Point(922, 19);
            this.EndDateBox.Name = "EndDateBox";
            this.EndDateBox.ReadOnly = true;
            this.EndDateBox.Size = new System.Drawing.Size(156, 22);
            this.EndDateBox.TabIndex = 29;
            this.EndDateBox.TextChanged += new System.EventHandler(this.EndDateBox_TextChanged);
            // 
            // TourNameBox
            // 
            this.TourNameBox.Location = new System.Drawing.Point(188, 121);
            this.TourNameBox.Name = "TourNameBox";
            this.TourNameBox.ReadOnly = true;
            this.TourNameBox.Size = new System.Drawing.Size(275, 22);
            this.TourNameBox.TabIndex = 27;
            this.TourNameBox.TextChanged += new System.EventHandler(this.TourNameBox_TextChanged);
            // 
            // Country_Box
            // 
            this.Country_Box.Location = new System.Drawing.Point(188, 170);
            this.Country_Box.Name = "Country_Box";
            this.Country_Box.ReadOnly = true;
            this.Country_Box.Size = new System.Drawing.Size(275, 22);
            this.Country_Box.TabIndex = 26;
            this.Country_Box.TextChanged += new System.EventHandler(this.Country_Box_TextChanged);
            // 
            // ID_TourBox
            // 
            this.ID_TourBox.Location = new System.Drawing.Point(188, 67);
            this.ID_TourBox.Name = "ID_TourBox";
            this.ID_TourBox.ReadOnly = true;
            this.ID_TourBox.Size = new System.Drawing.Size(275, 22);
            this.ID_TourBox.TabIndex = 25;
            // 
            // TA_Box
            // 
            this.TA_Box.Location = new System.Drawing.Point(188, 24);
            this.TA_Box.Name = "TA_Box";
            this.TA_Box.Size = new System.Drawing.Size(98, 22);
            this.TA_Box.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "TourPolicy";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "TourDescription";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(803, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 21;
            this.label14.Text = "FlightBrand";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(803, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "ChildrenPrice";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(803, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "AdultPrice";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(803, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "EndDestination";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(803, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "StartDestination";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(803, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "EndDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "StartDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "TourID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "TravelAgencySSN";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(683, 72);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(275, 22);
            this.SearchBox.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(581, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Search tour";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(983, 68);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(95, 24);
            this.SearchButton.TabIndex = 42;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(940, 41);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 17);
            this.IDLabel.TabIndex = 43;
            this.IDLabel.Text = "ID";
            // 
            // Profile_Button
            // 
            this.Profile_Button.Location = new System.Drawing.Point(55, 19);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Size = new System.Drawing.Size(95, 24);
            this.Profile_Button.TabIndex = 44;
            this.Profile_Button.Text = "Your Profile";
            this.Profile_Button.UseVisualStyleBackColor = true;
            this.Profile_Button.Click += new System.EventHandler(this.Profile_Button_Click);
            // 
            // UserMainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 984);
            this.Controls.Add(this.Profile_Button);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "UserMainFrame";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UserMainFrame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button BookTourButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox PolicyBox;
        private System.Windows.Forms.RichTextBox DescriptionBox;
        private System.Windows.Forms.TextBox FlightBrandBox;
        private System.Windows.Forms.TextBox AdultPriceBox;
        private System.Windows.Forms.TextBox ChildrenPriceBox;
        private System.Windows.Forms.TextBox EndDestBox;
        private System.Windows.Forms.TextBox StartDateBox;
        private System.Windows.Forms.TextBox StartDestBox;
        private System.Windows.Forms.TextBox EndDateBox;
        private System.Windows.Forms.TextBox TourNameBox;
        private System.Windows.Forms.TextBox Country_Box;
        private System.Windows.Forms.TextBox ID_TourBox;
        private System.Windows.Forms.TextBox TA_Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button Profile_Button;
    }
}