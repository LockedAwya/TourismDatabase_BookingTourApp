
namespace TourismDatabase1
{
    partial class changePasswordForm
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
            this.VerifyPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VerifyPasswordBox
            // 
            this.VerifyPasswordBox.Location = new System.Drawing.Point(283, 197);
            this.VerifyPasswordBox.Name = "VerifyPasswordBox";
            this.VerifyPasswordBox.Size = new System.Drawing.Size(424, 22);
            this.VerifyPasswordBox.TabIndex = 37;
            this.VerifyPasswordBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Verify new Password";
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(283, 148);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(424, 22);
            this.newPassword.TabIndex = 35;
            this.newPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "New Password";
            // 
            // SaveBox
            // 
            this.SaveBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBox.Location = new System.Drawing.Point(283, 316);
            this.SaveBox.Margin = new System.Windows.Forms.Padding(4);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(224, 58);
            this.SaveBox.TabIndex = 40;
            this.SaveBox.Text = "Save";
            this.SaveBox.UseVisualStyleBackColor = true;
            this.SaveBox.Click += new System.EventHandler(this.SaveBox_Click);
            // 
            // changePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.SaveBox);
            this.Controls.Add(this.VerifyPasswordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.label2);
            this.Name = "changePasswordForm";
            this.Load += new System.EventHandler(this.changePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VerifyPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBox;
    }
}