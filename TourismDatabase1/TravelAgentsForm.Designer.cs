
namespace TourismDatabase1
{
    partial class TravelAgentsForm
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddTourButton = new System.Windows.Forms.Button();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderSelection = new System.Windows.Forms.ComboBox();
            this.NationalityComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PNumberBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(183, 92);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(590, 22);
            this.NameBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name";
            // 
            // AddTourButton
            // 
            this.AddTourButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTourButton.Location = new System.Drawing.Point(320, 371);
            this.AddTourButton.Name = "AddTourButton";
            this.AddTourButton.Size = new System.Drawing.Size(147, 55);
            this.AddTourButton.TabIndex = 39;
            this.AddTourButton.Text = "Add";
            this.AddTourButton.UseVisualStyleBackColor = true;
            this.AddTourButton.Click += new System.EventHandler(this.AddTourButton_Click);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.AccessibleName = "Databinding1";
            this.BirthDatePicker.Location = new System.Drawing.Point(183, 147);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(245, 22);
            this.BirthDatePicker.TabIndex = 41;
            this.BirthDatePicker.Value = new System.DateTime(2021, 5, 3, 0, 0, 0, 0);
            this.BirthDatePicker.ValueChanged += new System.EventHandler(this.BirthDatePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Gender";
            // 
            // GenderSelection
            // 
            this.GenderSelection.AccessibleName = "Databinding1";
            this.GenderSelection.AllowDrop = true;
            this.GenderSelection.FormattingEnabled = true;
            this.GenderSelection.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderSelection.Location = new System.Drawing.Point(183, 203);
            this.GenderSelection.Name = "GenderSelection";
            this.GenderSelection.Size = new System.Drawing.Size(106, 24);
            this.GenderSelection.TabIndex = 44;
            // 
            // NationalityComboBox
            // 
            this.NationalityComboBox.AccessibleName = "Databinding1";
            this.NationalityComboBox.AllowDrop = true;
            this.NationalityComboBox.FormattingEnabled = true;
            this.NationalityComboBox.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "The Bahamas",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Côte d’Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "East Timor (Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "The Gambia",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Honduras",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Myanmar (Burma)",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Sudan, South",
            "Suriname",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.NationalityComboBox.Location = new System.Drawing.Point(183, 266);
            this.NationalityComboBox.Name = "NationalityComboBox";
            this.NationalityComboBox.Size = new System.Drawing.Size(215, 24);
            this.NationalityComboBox.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(590, 22);
            this.textBox1.TabIndex = 48;
            // 
            // PNumberBox
            // 
            this.PNumberBox.AutoSize = true;
            this.PNumberBox.Location = new System.Drawing.Point(61, 322);
            this.PNumberBox.Name = "PNumberBox";
            this.PNumberBox.Size = new System.Drawing.Size(99, 17);
            this.PNumberBox.TabIndex = 47;
            this.PNumberBox.Text = "PhoneNumber";
            // 
            // TravelAgentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PNumberBox);
            this.Controls.Add(this.NationalityComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenderSelection);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddTourButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Name = "TravelAgentsForm";
            this.Text = "TravelAgentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddTourButton;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GenderSelection;
        private System.Windows.Forms.ComboBox NationalityComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PNumberBox;
    }
}