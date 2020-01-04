namespace Bank_App.UserControls
{
    partial class AddingClientUserControl2
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.IncorrectZipCodeLabel = new System.Windows.Forms.Label();
            this.IncorrectClientLabel = new System.Windows.Forms.Label();
            this.IncorrectPhoneNumberLabel = new System.Windows.Forms.Label();
            this.IncorrectPeselLabel = new System.Windows.Forms.Label();
            this.IncorrectCityNameLabel = new System.Windows.Forms.Label();
            this.IncorrectSurnameLabel = new System.Windows.Forms.Label();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.ZipCodeTextBox1 = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PeselTextBox = new System.Windows.Forms.TextBox();
            this.CityNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PeselLabel = new System.Windows.Forms.Label();
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CreateClientLabel = new System.Windows.Forms.Label();
            this.CentralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CentralPanel
            // 
            this.CentralPanel.Controls.Add(this.CancelButton);
            this.CentralPanel.Controls.Add(this.CreateUserButton);
            this.CentralPanel.Controls.Add(this.DateOfBirthPicker);
            this.CentralPanel.Controls.Add(this.IncorrectZipCodeLabel);
            this.CentralPanel.Controls.Add(this.IncorrectClientLabel);
            this.CentralPanel.Controls.Add(this.IncorrectPhoneNumberLabel);
            this.CentralPanel.Controls.Add(this.IncorrectPeselLabel);
            this.CentralPanel.Controls.Add(this.IncorrectCityNameLabel);
            this.CentralPanel.Controls.Add(this.IncorrectSurnameLabel);
            this.CentralPanel.Controls.Add(this.IncorrectNameLabel);
            this.CentralPanel.Controls.Add(this.ZipCodeTextBox1);
            this.CentralPanel.Controls.Add(this.PhoneNumberTextBox);
            this.CentralPanel.Controls.Add(this.PeselTextBox);
            this.CentralPanel.Controls.Add(this.CityNameTextBox);
            this.CentralPanel.Controls.Add(this.SurnameTextBox);
            this.CentralPanel.Controls.Add(this.NameTextBox);
            this.CentralPanel.Controls.Add(this.label1);
            this.CentralPanel.Controls.Add(this.PhoneNumberLabel);
            this.CentralPanel.Controls.Add(this.PeselLabel);
            this.CentralPanel.Controls.Add(this.CityNameLabel);
            this.CentralPanel.Controls.Add(this.SurnameLabel);
            this.CentralPanel.Controls.Add(this.DateOfBirthLabel);
            this.CentralPanel.Controls.Add(this.NameLabel);
            this.CentralPanel.Controls.Add(this.CreateClientLabel);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(0, 0);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(730, 800);
            this.CentralPanel.TabIndex = 0;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(495, 700);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 40);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateUserButton.Location = new System.Drawing.Point(350, 700);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(140, 40);
            this.CreateUserButton.TabIndex = 14;
            this.CreateUserButton.Text = "Create ";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthPicker.Location = new System.Drawing.Point(27, 405);
            this.DateOfBirthPicker.MaxDate = new System.DateTime(2019, 10, 26, 0, 0, 0, 0);
            this.DateOfBirthPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(200, 32);
            this.DateOfBirthPicker.TabIndex = 12;
            this.DateOfBirthPicker.Value = new System.DateTime(2019, 10, 26, 0, 0, 0, 0);
            // 
            // IncorrectZipCodeLabel
            // 
            this.IncorrectZipCodeLabel.AutoSize = true;
            this.IncorrectZipCodeLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectZipCodeLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectZipCodeLabel.Location = new System.Drawing.Point(376, 235);
            this.IncorrectZipCodeLabel.Name = "IncorrectZipCodeLabel";
            this.IncorrectZipCodeLabel.Size = new System.Drawing.Size(292, 19);
            this.IncorrectZipCodeLabel.TabIndex = 10;
            this.IncorrectZipCodeLabel.Text = "Zip Code, which you entered is incorrect.";
            this.IncorrectZipCodeLabel.UseWaitCursor = true;
            this.IncorrectZipCodeLabel.Visible = false;
            // 
            // IncorrectClientLabel
            // 
            this.IncorrectClientLabel.AutoSize = true;
            this.IncorrectClientLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectClientLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectClientLabel.Location = new System.Drawing.Point(20, 440);
            this.IncorrectClientLabel.Name = "IncorrectClientLabel";
            this.IncorrectClientLabel.Size = new System.Drawing.Size(168, 19);
            this.IncorrectClientLabel.TabIndex = 10;
            this.IncorrectClientLabel.Text = "This client already exist.";
            this.IncorrectClientLabel.UseWaitCursor = true;
            this.IncorrectClientLabel.Visible = false;
            // 
            // IncorrectPhoneNumberLabel
            // 
            this.IncorrectPhoneNumberLabel.AutoSize = true;
            this.IncorrectPhoneNumberLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPhoneNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPhoneNumberLabel.Location = new System.Drawing.Point(372, 335);
            this.IncorrectPhoneNumberLabel.Name = "IncorrectPhoneNumberLabel";
            this.IncorrectPhoneNumberLabel.Size = new System.Drawing.Size(331, 19);
            this.IncorrectPhoneNumberLabel.TabIndex = 10;
            this.IncorrectPhoneNumberLabel.Text = "Phone number, which you entered is incorrect.";
            this.IncorrectPhoneNumberLabel.UseWaitCursor = true;
            this.IncorrectPhoneNumberLabel.Visible = false;
            // 
            // IncorrectPeselLabel
            // 
            this.IncorrectPeselLabel.AutoSize = true;
            this.IncorrectPeselLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectPeselLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectPeselLabel.Location = new System.Drawing.Point(16, 335);
            this.IncorrectPeselLabel.Name = "IncorrectPeselLabel";
            this.IncorrectPeselLabel.Size = new System.Drawing.Size(321, 19);
            this.IncorrectPeselLabel.TabIndex = 10;
            this.IncorrectPeselLabel.Text = "Pesel number, which you entered is incorrect.";
            this.IncorrectPeselLabel.UseWaitCursor = true;
            this.IncorrectPeselLabel.Visible = false;
            // 
            // IncorrectCityNameLabel
            // 
            this.IncorrectCityNameLabel.AutoSize = true;
            this.IncorrectCityNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectCityNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectCityNameLabel.Location = new System.Drawing.Point(20, 235);
            this.IncorrectCityNameLabel.Name = "IncorrectCityNameLabel";
            this.IncorrectCityNameLabel.Size = new System.Drawing.Size(301, 19);
            this.IncorrectCityNameLabel.TabIndex = 10;
            this.IncorrectCityNameLabel.Text = "City name, which you entered is incorrect.";
            this.IncorrectCityNameLabel.UseWaitCursor = true;
            this.IncorrectCityNameLabel.Visible = false;
            // 
            // IncorrectSurnameLabel
            // 
            this.IncorrectSurnameLabel.AutoSize = true;
            this.IncorrectSurnameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectSurnameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectSurnameLabel.Location = new System.Drawing.Point(376, 135);
            this.IncorrectSurnameLabel.Name = "IncorrectSurnameLabel";
            this.IncorrectSurnameLabel.Size = new System.Drawing.Size(290, 19);
            this.IncorrectSurnameLabel.TabIndex = 10;
            this.IncorrectSurnameLabel.Text = "Surname, which you entered is incorrect.";
            this.IncorrectSurnameLabel.UseWaitCursor = true;
            this.IncorrectSurnameLabel.Visible = false;
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(20, 135);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(271, 19);
            this.IncorrectNameLabel.TabIndex = 10;
            this.IncorrectNameLabel.Text = "Name, which you entered is incorrect.";
            this.IncorrectNameLabel.UseWaitCursor = true;
            this.IncorrectNameLabel.Visible = false;
            // 
            // ZipCodeTextBox1
            // 
            this.ZipCodeTextBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZipCodeTextBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ZipCodeTextBox1.Location = new System.Drawing.Point(380, 205);
            this.ZipCodeTextBox1.MaxLength = 6;
            this.ZipCodeTextBox1.Name = "ZipCodeTextBox1";
            this.ZipCodeTextBox1.Size = new System.Drawing.Size(110, 28);
            this.ZipCodeTextBox1.TabIndex = 8;
            this.ZipCodeTextBox1.Text = "00-000";
            this.ZipCodeTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ZipCodeTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeTextBox1_KeyPress);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneNumberTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(381, 305);
            this.PhoneNumberTextBox.MaxLength = 9;
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(300, 28);
            this.PhoneNumberTextBox.TabIndex = 8;
            this.PhoneNumberTextBox.Text = "000000000";
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PeselTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PeselTextBox.Location = new System.Drawing.Point(25, 305);
            this.PeselTextBox.MaxLength = 11;
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(300, 28);
            this.PeselTextBox.TabIndex = 8;
            this.PeselTextBox.Text = "00000000";
            this.PeselTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeselTextBox_KeyPress);
            // 
            // CityNameTextBox
            // 
            this.CityNameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityNameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CityNameTextBox.Location = new System.Drawing.Point(25, 205);
            this.CityNameTextBox.Name = "CityNameTextBox";
            this.CityNameTextBox.Size = new System.Drawing.Size(300, 28);
            this.CityNameTextBox.TabIndex = 8;
            this.CityNameTextBox.Text = "City Name ";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SurnameTextBox.Location = new System.Drawing.Point(380, 105);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(300, 28);
            this.SurnameTextBox.TabIndex = 8;
            this.SurnameTextBox.Text = "Surname";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameTextBox.Location = new System.Drawing.Point(25, 105);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(300, 28);
            this.NameTextBox.TabIndex = 8;
            this.NameTextBox.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zip Code:";
            this.label1.UseWaitCursor = true;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(376, 270);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(162, 23);
            this.PhoneNumberLabel.TabIndex = 7;
            this.PhoneNumberLabel.Text = "Phone Number:";
            this.PhoneNumberLabel.UseWaitCursor = true;
            // 
            // PeselLabel
            // 
            this.PeselLabel.AutoSize = true;
            this.PeselLabel.Location = new System.Drawing.Point(20, 270);
            this.PeselLabel.Name = "PeselLabel";
            this.PeselLabel.Size = new System.Drawing.Size(66, 23);
            this.PeselLabel.TabIndex = 7;
            this.PeselLabel.Text = "Pesel:";
            this.PeselLabel.UseWaitCursor = true;
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.AutoSize = true;
            this.CityNameLabel.Location = new System.Drawing.Point(20, 170);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(119, 23);
            this.CityNameLabel.TabIndex = 7;
            this.CityNameLabel.Text = "City Name:";
            this.CityNameLabel.UseWaitCursor = true;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(376, 70);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(101, 23);
            this.SurnameLabel.TabIndex = 7;
            this.SurnameLabel.Text = "Surname:";
            this.SurnameLabel.UseWaitCursor = true;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(22, 370);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(134, 23);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            this.DateOfBirthLabel.UseWaitCursor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(20, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(76, 23);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            this.NameLabel.UseWaitCursor = true;
            // 
            // CreateClientLabel
            // 
            this.CreateClientLabel.AutoSize = true;
            this.CreateClientLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateClientLabel.Location = new System.Drawing.Point(20, 20);
            this.CreateClientLabel.Name = "CreateClientLabel";
            this.CreateClientLabel.Size = new System.Drawing.Size(491, 34);
            this.CreateClientLabel.TabIndex = 6;
            this.CreateClientLabel.Text = "Create Client Account (Step 2 of 2)";
            this.CreateClientLabel.UseWaitCursor = true;
            // 
            // AddingClientUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.CentralPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddingClientUserControl2";
            this.Size = new System.Drawing.Size(730, 800);
            this.CentralPanel.ResumeLayout(false);
            this.CentralPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CreateClientLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.Label IncorrectZipCodeLabel;
        private System.Windows.Forms.Label IncorrectCityNameLabel;
        private System.Windows.Forms.Label IncorrectSurnameLabel;
        private System.Windows.Forms.TextBox ZipCodeTextBox1;
        private System.Windows.Forms.TextBox CityNameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CityNameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Label IncorrectPeselLabel;
        private System.Windows.Forms.TextBox PeselTextBox;
        private System.Windows.Forms.Label PeselLabel;
        private System.Windows.Forms.Label IncorrectPhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label IncorrectClientLabel;
    }
}
