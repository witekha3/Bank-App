namespace Bank_App.UserControls
{
    partial class AddingInvestmentUserControl
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
            this.CreateInvestmentLabel = new System.Windows.Forms.Label();
            this.IncorrectNameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.IncorrectValueLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DurationComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.IncorrectBalanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateInvestmentLabel
            // 
            this.CreateInvestmentLabel.AutoSize = true;
            this.CreateInvestmentLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CreateInvestmentLabel.Location = new System.Drawing.Point(20, 20);
            this.CreateInvestmentLabel.Name = "CreateInvestmentLabel";
            this.CreateInvestmentLabel.Size = new System.Drawing.Size(264, 34);
            this.CreateInvestmentLabel.TabIndex = 1;
            this.CreateInvestmentLabel.Text = "Create Investment";
            this.CreateInvestmentLabel.UseWaitCursor = true;
            // 
            // IncorrectNameLabel
            // 
            this.IncorrectNameLabel.AutoSize = true;
            this.IncorrectNameLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectNameLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectNameLabel.Location = new System.Drawing.Point(20, 135);
            this.IncorrectNameLabel.Name = "IncorrectNameLabel";
            this.IncorrectNameLabel.Size = new System.Drawing.Size(271, 19);
            this.IncorrectNameLabel.TabIndex = 12;
            this.IncorrectNameLabel.Text = "Name, which you entered is incorrect.";
            this.IncorrectNameLabel.UseWaitCursor = true;
            this.IncorrectNameLabel.Visible = false;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NameTextBox.Location = new System.Drawing.Point(25, 105);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(300, 28);
            this.NameTextBox.TabIndex = 11;
            this.NameTextBox.Text = "Name";
            this.NameTextBox.UseWaitCursor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(20, 70);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(76, 23);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name:";
            this.NameLabel.UseWaitCursor = true;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(25, 205);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(301, 31);
            this.TypeComboBox.TabIndex = 13;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(20, 170);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(61, 23);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = "Type:";
            this.TypeLabel.UseWaitCursor = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(20, 270);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(74, 23);
            this.ValueLabel.TabIndex = 10;
            this.ValueLabel.Text = "Value:";
            this.ValueLabel.UseWaitCursor = true;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValueTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ValueTextBox.Location = new System.Drawing.Point(25, 305);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(300, 28);
            this.ValueTextBox.TabIndex = 11;
            this.ValueTextBox.Text = "Value";
            this.ValueTextBox.UseWaitCursor = true;
            // 
            // IncorrectValueLabel
            // 
            this.IncorrectValueLabel.AutoSize = true;
            this.IncorrectValueLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectValueLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectValueLabel.Location = new System.Drawing.Point(20, 340);
            this.IncorrectValueLabel.Name = "IncorrectValueLabel";
            this.IncorrectValueLabel.Size = new System.Drawing.Size(269, 19);
            this.IncorrectValueLabel.TabIndex = 12;
            this.IncorrectValueLabel.Text = "Value, which you entered is incorrect.";
            this.IncorrectValueLabel.UseWaitCursor = true;
            this.IncorrectValueLabel.Visible = false;
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(22, 382);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(97, 23);
            this.DurationLabel.TabIndex = 10;
            this.DurationLabel.Text = "Duration:";
            this.DurationLabel.UseWaitCursor = true;
            // 
            // DurationComboBox
            // 
            this.DurationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DurationComboBox.FormattingEnabled = true;
            this.DurationComboBox.Location = new System.Drawing.Point(27, 417);
            this.DurationComboBox.Name = "DurationComboBox";
            this.DurationComboBox.Size = new System.Drawing.Size(301, 31);
            this.DurationComboBox.TabIndex = 13;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(496, 700);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 40);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.UseWaitCursor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmButton.Location = new System.Drawing.Point(350, 700);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(140, 40);
            this.ConfirmButton.TabIndex = 15;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.UseWaitCursor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // IncorrectBalanceLabel
            // 
            this.IncorrectBalanceLabel.AutoSize = true;
            this.IncorrectBalanceLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectBalanceLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectBalanceLabel.Location = new System.Drawing.Point(20, 452);
            this.IncorrectBalanceLabel.Name = "IncorrectBalanceLabel";
            this.IncorrectBalanceLabel.Size = new System.Drawing.Size(409, 19);
            this.IncorrectBalanceLabel.TabIndex = 12;
            this.IncorrectBalanceLabel.Text = "You do not have enough money to realize this investment.";
            this.IncorrectBalanceLabel.UseWaitCursor = true;
            this.IncorrectBalanceLabel.Visible = false;
            // 
            // AddingInvestmentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DurationComboBox);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.IncorrectBalanceLabel);
            this.Controls.Add(this.IncorrectValueLabel);
            this.Controls.Add(this.IncorrectNameLabel);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CreateInvestmentLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddingInvestmentUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateInvestmentLabel;
        private System.Windows.Forms.Label IncorrectNameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label IncorrectValueLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.ComboBox DurationComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label IncorrectBalanceLabel;
    }
}
