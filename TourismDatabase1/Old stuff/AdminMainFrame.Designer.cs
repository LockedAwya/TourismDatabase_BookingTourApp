
namespace TourismDatabase1
{
    partial class AdminMainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainFrame));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.showtravelagentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showtourguidesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showuseraccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showbookingsectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showtravelagentsToolStripMenuItem,
            this.showtourguidesToolStripMenuItem,
            this.showuseraccountToolStripMenuItem,
            this.showbookingsectionToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(39, 24);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // showtravelagentsToolStripMenuItem
            // 
            this.showtravelagentsToolStripMenuItem.Name = "showtravelagentsToolStripMenuItem";
            this.showtravelagentsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.showtravelagentsToolStripMenuItem.Text = "show_travel_agents";
            this.showtravelagentsToolStripMenuItem.Click += new System.EventHandler(this.showtravelagentsToolStripMenuItem_Click);
            // 
            // showtourguidesToolStripMenuItem
            // 
            this.showtourguidesToolStripMenuItem.Name = "showtourguidesToolStripMenuItem";
            this.showtourguidesToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.showtourguidesToolStripMenuItem.Text = "show_tour_guides";
            // 
            // showuseraccountToolStripMenuItem
            // 
            this.showuseraccountToolStripMenuItem.Name = "showuseraccountToolStripMenuItem";
            this.showuseraccountToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.showuseraccountToolStripMenuItem.Text = "show_user_account";
            // 
            // showbookingsectionToolStripMenuItem
            // 
            this.showbookingsectionToolStripMenuItem.Name = "showbookingsectionToolStripMenuItem";
            this.showbookingsectionToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.showbookingsectionToolStripMenuItem.Text = "show_booking_section";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem showtravelagentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showtourguidesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showuseraccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showbookingsectionToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
    }
}