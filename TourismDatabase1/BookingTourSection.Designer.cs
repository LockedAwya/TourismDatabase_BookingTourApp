
namespace TourismDatabase1
{
    partial class BookingTourSection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.no_of_Adults = new System.Windows.Forms.NumericUpDown();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.TourIDBox = new System.Windows.Forms.TextBox();
            this.TournameBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.no_of_Children = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChildrenPriceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdultPriceBox = new System.Windows.Forms.TextBox();
            this.Money_sum = new System.Windows.Forms.Label();
            this.Amount_Money = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_Adults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_Children)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the number of adults here";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // no_of_Adults
            // 
            this.no_of_Adults.Location = new System.Drawing.Point(313, 84);
            this.no_of_Adults.Name = "no_of_Adults";
            this.no_of_Adults.Size = new System.Drawing.Size(175, 22);
            this.no_of_Adults.TabIndex = 5;
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.LeftPanel.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.LeftPanel.Location = new System.Drawing.Point(24, 195);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(555, 550);
            this.LeftPanel.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AccessibleName = "Databinding1";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(148, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 29;
            this.label9.Text = "TourID";
            // 
            // TourIDBox
            // 
            this.TourIDBox.AccessibleName = "Databinding1";
            this.TourIDBox.Location = new System.Drawing.Point(236, 27);
            this.TourIDBox.Name = "TourIDBox";
            this.TourIDBox.ReadOnly = true;
            this.TourIDBox.Size = new System.Drawing.Size(175, 22);
            this.TourIDBox.TabIndex = 28;
            // 
            // TournameBox
            // 
            this.TournameBox.AccessibleName = "Databinding1";
            this.TournameBox.Location = new System.Drawing.Point(529, 29);
            this.TournameBox.Name = "TournameBox";
            this.TournameBox.ReadOnly = true;
            this.TournameBox.Size = new System.Drawing.Size(262, 22);
            this.TournameBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AccessibleName = "Databinding1";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tour name:";
            // 
            // no_of_Children
            // 
            this.no_of_Children.Location = new System.Drawing.Point(313, 111);
            this.no_of_Children.Name = "no_of_Children";
            this.no_of_Children.Size = new System.Drawing.Size(175, 22);
            this.no_of_Children.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Enter the number of children here";
            // 
            // label3
            // 
            this.label3.AccessibleName = "Databinding1";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(817, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Children Price (in VND)";
            // 
            // ChildrenPriceBox
            // 
            this.ChildrenPriceBox.AccessibleName = "Databinding1";
            this.ChildrenPriceBox.Location = new System.Drawing.Point(979, 27);
            this.ChildrenPriceBox.Name = "ChildrenPriceBox";
            this.ChildrenPriceBox.ReadOnly = true;
            this.ChildrenPriceBox.Size = new System.Drawing.Size(125, 22);
            this.ChildrenPriceBox.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AccessibleName = "Databinding1";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(817, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Adult Price (in VND)";
            // 
            // AdultPriceBox
            // 
            this.AdultPriceBox.AccessibleName = "Databinding1";
            this.AdultPriceBox.Location = new System.Drawing.Point(979, 64);
            this.AdultPriceBox.Name = "AdultPriceBox";
            this.AdultPriceBox.ReadOnly = true;
            this.AdultPriceBox.Size = new System.Drawing.Size(125, 22);
            this.AdultPriceBox.TabIndex = 34;
            // 
            // Money_sum
            // 
            this.Money_sum.AutoSize = true;
            this.Money_sum.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money_sum.Location = new System.Drawing.Point(623, 99);
            this.Money_sum.Name = "Money_sum";
            this.Money_sum.Size = new System.Drawing.Size(206, 17);
            this.Money_sum.TabIndex = 36;
            this.Money_sum.Text = "Total amout of money (in VND):";
            // 
            // Amount_Money
            // 
            this.Amount_Money.AutoSize = true;
            this.Amount_Money.Location = new System.Drawing.Point(839, 99);
            this.Amount_Money.Name = "Amount_Money";
            this.Amount_Money.Size = new System.Drawing.Size(15, 17);
            this.Amount_Money.TabIndex = 37;
            this.Amount_Money.Text = "0";
            // 
            // rightPanel
            // 
            this.rightPanel.AutoScroll = true;
            this.rightPanel.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.rightPanel.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.rightPanel.Location = new System.Drawing.Point(656, 195);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(659, 550);
            this.rightPanel.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AccessibleName = "Databinding1";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Adult Information";
            // 
            // label6
            // 
            this.label6.AccessibleName = "Databinding1";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(897, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Children Information";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 24);
            this.button3.TabIndex = 40;
            this.button3.Text = "Enter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Payment
            // 
            this.Payment.AccessibleName = "Databinding1";
            this.Payment.AllowDrop = true;
            this.Payment.FormattingEnabled = true;
            this.Payment.Items.AddRange(new object[] {
            "Paypal",
            "Cash",
            "BIDV",
            "Vietcombank",
            "MasterCard",
            "Bitcoin",
            "American Express"});
            this.Payment.Location = new System.Drawing.Point(751, 120);
            this.Payment.Margin = new System.Windows.Forms.Padding(4);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(69, 23);
            this.Payment.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AccessibleName = "Databinding1";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Payment Method";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(740, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 24);
            this.button4.TabIndex = 43;
            this.button4.Text = "Enter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // BookingTourSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.TournameBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Amount_Money);
            this.Controls.Add(this.Money_sum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdultPriceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no_of_Children);
            this.Controls.Add(this.ChildrenPriceBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TourIDBox);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.no_of_Adults);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BookingTourSection";
            this.Size = new System.Drawing.Size(1371, 787);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.no_of_Adults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_Children)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown no_of_Adults;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TourIDBox;
        private System.Windows.Forms.TextBox TournameBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown no_of_Children;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ChildrenPriceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdultPriceBox;
        private System.Windows.Forms.Label Money_sum;
        private System.Windows.Forms.Label Amount_Money;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Payment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}
