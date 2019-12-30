namespace Bank_App.UserControls
{
    partial class TransferUserControl
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
            this.TransferLabel = new System.Windows.Forms.Label();
            this.IncorrectTitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.IncorrectValueLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CreateTransferButton = new System.Windows.Forms.Button();
            this.OrLabel = new System.Windows.Forms.Label();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.AccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.IncorrectAccountNumberLabel = new System.Windows.Forms.Label();
            this.DefinedTransferTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransferLabel
            // 
            this.TransferLabel.AutoSize = true;
            this.TransferLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransferLabel.Location = new System.Drawing.Point(20, 20);
            this.TransferLabel.Name = "TransferLabel";
            this.TransferLabel.Size = new System.Drawing.Size(130, 34);
            this.TransferLabel.TabIndex = 1;
            this.TransferLabel.Text = "Transfers";
            this.TransferLabel.UseWaitCursor = true;
            // 
            // IncorrectTitleLabel
            // 
            this.IncorrectTitleLabel.AutoSize = true;
            this.IncorrectTitleLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectTitleLabel.Location = new System.Drawing.Point(20, 320);
            this.IncorrectTitleLabel.Name = "IncorrectTitleLabel";
            this.IncorrectTitleLabel.Size = new System.Drawing.Size(254, 19);
            this.IncorrectTitleLabel.TabIndex = 12;
            this.IncorrectTitleLabel.Text = "Title, which you entered is incorrect.";
            this.IncorrectTitleLabel.UseWaitCursor = true;
            this.IncorrectTitleLabel.Visible = false;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Enabled = false;
            this.TitleTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TitleTextBox.Location = new System.Drawing.Point(25, 290);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(300, 28);
            this.TitleTextBox.TabIndex = 11;
            this.TitleTextBox.Text = "Title";
            this.TitleTextBox.UseWaitCursor = true;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(20, 255);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(51, 23);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "Title:";
            this.TitleLabel.UseWaitCursor = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(20, 355);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(74, 23);
            this.ValueLabel.TabIndex = 10;
            this.ValueLabel.Text = "Value:";
            this.ValueLabel.UseWaitCursor = true;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Enabled = false;
            this.ValueTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ValueTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ValueTextBox.Location = new System.Drawing.Point(25, 390);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(300, 28);
            this.ValueTextBox.TabIndex = 11;
            this.ValueTextBox.Text = "0";
            this.ValueTextBox.UseWaitCursor = true;
            // 
            // IncorrectValueLabel
            // 
            this.IncorrectValueLabel.AutoSize = true;
            this.IncorrectValueLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectValueLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectValueLabel.Location = new System.Drawing.Point(20, 420);
            this.IncorrectValueLabel.Name = "IncorrectValueLabel";
            this.IncorrectValueLabel.Size = new System.Drawing.Size(269, 19);
            this.IncorrectValueLabel.TabIndex = 12;
            this.IncorrectValueLabel.Text = "Value, which you entered is incorrect.";
            this.IncorrectValueLabel.UseWaitCursor = true;
            this.IncorrectValueLabel.Visible = false;
            // 
            // DatePicker
            // 
            this.DatePicker.Enabled = false;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(25, 590);
            this.DatePicker.MaxDate = new System.DateTime(2019, 10, 26, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(200, 32);
            this.DatePicker.TabIndex = 14;
            this.DatePicker.Value = new System.DateTime(2019, 10, 26, 0, 0, 0, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(20, 555);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(64, 23);
            this.DateLabel.TabIndex = 13;
            this.DateLabel.Text = "Date:";
            this.DateLabel.UseWaitCursor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(496, 700);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(140, 40);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmButton.Location = new System.Drawing.Point(350, 700);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(140, 40);
            this.ConfirmButton.TabIndex = 16;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CreateTransferButton
            // 
            this.CreateTransferButton.Location = new System.Drawing.Point(25, 175);
            this.CreateTransferButton.Name = "CreateTransferButton";
            this.CreateTransferButton.Size = new System.Drawing.Size(400, 40);
            this.CreateTransferButton.TabIndex = 17;
            this.CreateTransferButton.Text = "Create new one";
            this.CreateTransferButton.UseVisualStyleBackColor = true;
            this.CreateTransferButton.Click += new System.EventHandler(this.CreateTransferButton_Click);
            // 
            // OrLabel
            // 
            this.OrLabel.AutoSize = true;
            this.OrLabel.Location = new System.Drawing.Point(185, 130);
            this.OrLabel.Name = "OrLabel";
            this.OrLabel.Size = new System.Drawing.Size(29, 23);
            this.OrLabel.TabIndex = 10;
            this.OrLabel.Text = "or";
            this.OrLabel.UseWaitCursor = true;
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Location = new System.Drawing.Point(20, 455);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(180, 23);
            this.AccountNumberLabel.TabIndex = 13;
            this.AccountNumberLabel.Text = "Account Number";
            this.AccountNumberLabel.UseWaitCursor = true;
            // 
            // AccountNumberTextBox
            // 
            this.AccountNumberTextBox.Enabled = false;
            this.AccountNumberTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AccountNumberTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AccountNumberTextBox.Location = new System.Drawing.Point(25, 490);
            this.AccountNumberTextBox.Name = "AccountNumberTextBox";
            this.AccountNumberTextBox.Size = new System.Drawing.Size(300, 28);
            this.AccountNumberTextBox.TabIndex = 11;
            this.AccountNumberTextBox.Text = "0";
            this.AccountNumberTextBox.UseWaitCursor = true;
            // 
            // IncorrectAccountNumberLabel
            // 
            this.IncorrectAccountNumberLabel.AutoSize = true;
            this.IncorrectAccountNumberLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectAccountNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectAccountNumberLabel.Location = new System.Drawing.Point(20, 520);
            this.IncorrectAccountNumberLabel.Name = "IncorrectAccountNumberLabel";
            this.IncorrectAccountNumberLabel.Size = new System.Drawing.Size(269, 19);
            this.IncorrectAccountNumberLabel.TabIndex = 12;
            this.IncorrectAccountNumberLabel.Text = "Value, which you entered is incorrect.";
            this.IncorrectAccountNumberLabel.UseWaitCursor = true;
            this.IncorrectAccountNumberLabel.Visible = false;
            // 
            // DefinedTransferTxt
            // 
            this.DefinedTransferTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DefinedTransferTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.DefinedTransferTxt.Location = new System.Drawing.Point(202, 75);
            this.DefinedTransferTxt.Name = "DefinedTransferTxt";
            this.DefinedTransferTxt.Size = new System.Drawing.Size(447, 32);
            this.DefinedTransferTxt.TabIndex = 18;
            this.DefinedTransferTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DefinedTransferTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Defined transfer";
            // 
            // TransferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DefinedTransferTxt);
            this.Controls.Add(this.CreateTransferButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.AccountNumberLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.IncorrectAccountNumberLabel);
            this.Controls.Add(this.IncorrectValueLabel);
            this.Controls.Add(this.IncorrectTitleLabel);
            this.Controls.Add(this.AccountNumberTextBox);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.OrLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.TransferLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransferUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.Load += new System.EventHandler(this.TransferUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransferLabel;
        private System.Windows.Forms.Label IncorrectTitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label IncorrectValueLabel;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button CreateTransferButton;
        private System.Windows.Forms.Label OrLabel;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.TextBox AccountNumberTextBox;
        private System.Windows.Forms.Label IncorrectAccountNumberLabel;
        private System.Windows.Forms.TextBox DefinedTransferTxt;
        private System.Windows.Forms.Label label1;
    }
}
