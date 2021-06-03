
namespace Contact_Tracing
{
    partial class Form1
    {
        private const string V = "Form1";

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameTxtBox = new System.Windows.Forms.TextBox();
            this.Genderlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.AgeTxtBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.ContactTxtBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.BarangayLAbel = new System.Windows.Forms.Label();
            this.BrgyTxtBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTxtBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.Location = new System.Drawing.Point(-2, -2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(426, 67);
            this.textBox1.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.DodgerBlue;
            this.Title.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(60, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(303, 32);
            this.Title.TabIndex = 2;
            this.Title.Text = "Contact Tracing Form";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.Location = new System.Drawing.Point(12, 100);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(84, 18);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTxtBox.Location = new System.Drawing.Point(12, 122);
            this.lastNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastNameTxtBox.Multiline = true;
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(135, 29);
            this.lastNameTxtBox.TabIndex = 4;
            this.lastNameTxtBox.TextChanged += new System.EventHandler(this.lastNameTxtBox_TextChanged);
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.middleNameLabel.Location = new System.Drawing.Point(286, 100);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(101, 18);
            this.middleNameLabel.TabIndex = 5;
            this.middleNameLabel.Text = "Middle Name";
            this.middleNameLabel.Click += new System.EventHandler(this.middleNameLabel_Click);
            // 
            // MiddleNameTxtBox
            // 
            this.MiddleNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiddleNameTxtBox.Location = new System.Drawing.Point(286, 122);
            this.MiddleNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MiddleNameTxtBox.Multiline = true;
            this.MiddleNameTxtBox.Name = "MiddleNameTxtBox";
            this.MiddleNameTxtBox.Size = new System.Drawing.Size(123, 29);
            this.MiddleNameTxtBox.TabIndex = 6;
            this.MiddleNameTxtBox.TextChanged += new System.EventHandler(this.MiddleNameTxtBox_TextChanged);
            // 
            // Genderlabel
            // 
            this.Genderlabel.AutoSize = true;
            this.Genderlabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Genderlabel.Location = new System.Drawing.Point(102, 174);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Genderlabel.Size = new System.Drawing.Size(60, 18);
            this.Genderlabel.TabIndex = 7;
            this.Genderlabel.Text = "Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Prefer Not to Answer"});
            this.comboBox1.Location = new System.Drawing.Point(102, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 29);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(153, 100);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstNameLabel.Size = new System.Drawing.Size(85, 18);
            this.FirstNameLabel.TabIndex = 9;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTxtBox.Location = new System.Drawing.Point(153, 122);
            this.firstNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstNameTxtBox.Multiline = true;
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(127, 29);
            this.firstNameTxtBox.TabIndex = 10;
            this.firstNameTxtBox.TextChanged += new System.EventHandler(this.firstNameTxtBox_TextChanged);
            // 
            // AgeTxtBox
            // 
            this.AgeTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeTxtBox.Location = new System.Drawing.Point(12, 196);
            this.AgeTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgeTxtBox.Multiline = true;
            this.AgeTxtBox.Name = "AgeTxtBox";
            this.AgeTxtBox.Size = new System.Drawing.Size(84, 29);
            this.AgeTxtBox.TabIndex = 11;
            this.AgeTxtBox.TextChanged += new System.EventHandler(this.AgeTxtBox_TextChanged);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeLabel.Location = new System.Drawing.Point(12, 174);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AgeLabel.Size = new System.Drawing.Size(37, 18);
            this.AgeLabel.TabIndex = 12;
            this.AgeLabel.Text = "Age";
            this.AgeLabel.Click += new System.EventHandler(this.AgeLabel_Click);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactLabel.Location = new System.Drawing.Point(227, 174);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactLabel.Size = new System.Drawing.Size(121, 18);
            this.ContactLabel.TabIndex = 13;
            this.ContactLabel.Text = "Contact Number";
            // 
            // ContactTxtBox
            // 
            this.ContactTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactTxtBox.Location = new System.Drawing.Point(227, 196);
            this.ContactTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContactTxtBox.Multiline = true;
            this.ContactTxtBox.Name = "ContactTxtBox";
            this.ContactTxtBox.Size = new System.Drawing.Size(141, 29);
            this.ContactTxtBox.TabIndex = 14;
            this.ContactTxtBox.TextChanged += new System.EventHandler(this.ContactTxtBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(12, 245);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailLabel.Size = new System.Drawing.Size(48, 18);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTxtBox.Location = new System.Drawing.Point(12, 267);
            this.EmailTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTxtBox.Multiline = true;
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(173, 29);
            this.EmailTxtBox.TabIndex = 16;
            this.EmailTxtBox.TextChanged += new System.EventHandler(this.EmailTxtBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.Location = new System.Drawing.Point(195, 245);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddressLabel.Size = new System.Drawing.Size(67, 18);
            this.AddressLabel.TabIndex = 17;
            this.AddressLabel.Text = "Address";
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressTxtBox.Location = new System.Drawing.Point(195, 267);
            this.AddressTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(214, 29);
            this.AddressTxtBox.TabIndex = 18;
            this.AddressTxtBox.TextChanged += new System.EventHandler(this.AddressTxtBox_TextChanged);
            // 
            // BarangayLAbel
            // 
            this.BarangayLAbel.AutoSize = true;
            this.BarangayLAbel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BarangayLAbel.Location = new System.Drawing.Point(12, 317);
            this.BarangayLAbel.Name = "BarangayLAbel";
            this.BarangayLAbel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BarangayLAbel.Size = new System.Drawing.Size(75, 18);
            this.BarangayLAbel.TabIndex = 19;
            this.BarangayLAbel.Text = "Barangay";
            // 
            // BrgyTxtBox
            // 
            this.BrgyTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrgyTxtBox.Location = new System.Drawing.Point(12, 339);
            this.BrgyTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrgyTxtBox.Multiline = true;
            this.BrgyTxtBox.Name = "BrgyTxtBox";
            this.BrgyTxtBox.Size = new System.Drawing.Size(150, 29);
            this.BrgyTxtBox.TabIndex = 20;
            this.BrgyTxtBox.TextChanged += new System.EventHandler(this.BrgyTxtBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityLabel.Location = new System.Drawing.Point(177, 317);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityLabel.Size = new System.Drawing.Size(35, 18);
            this.CityLabel.TabIndex = 21;
            this.CityLabel.Text = "City";
            // 
            // CityTxtBox
            // 
            this.CityTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityTxtBox.Location = new System.Drawing.Point(177, 339);
            this.CityTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CityTxtBox.Multiline = true;
            this.CityTxtBox.Name = "CityTxtBox";
            this.CityTxtBox.Size = new System.Drawing.Size(150, 29);
            this.CityTxtBox.TabIndex = 22;
            this.CityTxtBox.TextChanged += new System.EventHandler(this.CityTxtBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SubmitButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SubmitButton.Location = new System.Drawing.Point(315, 375);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(94, 40);
            this.SubmitButton.TabIndex = 23;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(421, 423);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CityTxtBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.BrgyTxtBox);
            this.Controls.Add(this.BarangayLAbel);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ContactTxtBox);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.AgeTxtBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Genderlabel);
            this.Controls.Add(this.MiddleNameTxtBox);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox MiddleNameTxtBox;
        private System.Windows.Forms.Label Genderlabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.TextBox AgeTxtBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox ContactTxtBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.Label BarangayLAbel;
        private System.Windows.Forms.TextBox BrgyTxtBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTxtBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}

