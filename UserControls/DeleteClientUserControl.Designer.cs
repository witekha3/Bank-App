namespace Bank_App.UserControls
{
    partial class DeleteClientUserControl
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.RefreshLabel = new System.Windows.Forms.Label();
            this.ClientsListView = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoginColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PeselColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CleintLabel = new System.Windows.Forms.Label();
            this.IncorrectSelectedItemLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Instruction2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(20, 570);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(690, 40);
            this.RefreshButton.TabIndex = 31;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // RefreshLabel
            // 
            this.RefreshLabel.AutoSize = true;
            this.RefreshLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshLabel.Location = new System.Drawing.Point(20, 535);
            this.RefreshLabel.Name = "RefreshLabel";
            this.RefreshLabel.Size = new System.Drawing.Size(114, 23);
            this.RefreshLabel.TabIndex = 30;
            this.RefreshLabel.Text = "Refresh list.";
            this.RefreshLabel.UseWaitCursor = true;
            // 
            // ClientsListView
            // 
            this.ClientsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.LoginColumn,
            this.EmailColumn,
            this.PeselColumn,
            this.AccountNumberColumn});
            this.ClientsListView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientsListView.FullRowSelect = true;
            this.ClientsListView.GridLines = true;
            this.ClientsListView.HideSelection = false;
            this.ClientsListView.LabelWrap = false;
            this.ClientsListView.Location = new System.Drawing.Point(20, 70);
            this.ClientsListView.MultiSelect = false;
            this.ClientsListView.Name = "ClientsListView";
            this.ClientsListView.Size = new System.Drawing.Size(690, 445);
            this.ClientsListView.TabIndex = 29;
            this.ClientsListView.UseCompatibleStateImageBehavior = false;
            this.ClientsListView.View = System.Windows.Forms.View.Details;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            // 
            // LoginColumn
            // 
            this.LoginColumn.Text = "Login";
            this.LoginColumn.Width = 120;
            // 
            // EmailColumn
            // 
            this.EmailColumn.Text = "Email";
            this.EmailColumn.Width = 120;
            // 
            // PeselColumn
            // 
            this.PeselColumn.Text = "Pesel";
            this.PeselColumn.Width = 120;
            // 
            // AccountNumberColumn
            // 
            this.AccountNumberColumn.Text = "Account Number";
            this.AccountNumberColumn.Width = 264;
            // 
            // CleintLabel
            // 
            this.CleintLabel.AutoSize = true;
            this.CleintLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CleintLabel.Location = new System.Drawing.Point(20, 20);
            this.CleintLabel.Name = "CleintLabel";
            this.CleintLabel.Size = new System.Drawing.Size(106, 34);
            this.CleintLabel.TabIndex = 22;
            this.CleintLabel.Text = "Clients";
            this.CleintLabel.UseWaitCursor = true;
            // 
            // IncorrectSelectedItemLabel
            // 
            this.IncorrectSelectedItemLabel.AutoSize = true;
            this.IncorrectSelectedItemLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectSelectedItemLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectSelectedItemLabel.Location = new System.Drawing.Point(20, 705);
            this.IncorrectSelectedItemLabel.Name = "IncorrectSelectedItemLabel";
            this.IncorrectSelectedItemLabel.Size = new System.Drawing.Size(282, 19);
            this.IncorrectSelectedItemLabel.TabIndex = 28;
            this.IncorrectSelectedItemLabel.Text = "Select at least one client and try again.";
            this.IncorrectSelectedItemLabel.UseWaitCursor = true;
            this.IncorrectSelectedItemLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(20, 735);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(690, 40);
            this.CancelButton.TabIndex = 25;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(20, 660);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(690, 40);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Instruction2Label
            // 
            this.Instruction2Label.AutoSize = true;
            this.Instruction2Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Instruction2Label.Location = new System.Drawing.Point(20, 625);
            this.Instruction2Label.Name = "Instruction2Label";
            this.Instruction2Label.Size = new System.Drawing.Size(232, 23);
            this.Instruction2Label.TabIndex = 23;
            this.Instruction2Label.Text = "Delete selected client.";
            this.Instruction2Label.UseWaitCursor = true;
            // 
            // DeleteClientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RefreshLabel);
            this.Controls.Add(this.ClientsListView);
            this.Controls.Add(this.CleintLabel);
            this.Controls.Add(this.IncorrectSelectedItemLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Instruction2Label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteClientUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.Load += new System.EventHandler(this.DeleteClientUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label RefreshLabel;
        private System.Windows.Forms.ListView ClientsListView;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.Label CleintLabel;
        private System.Windows.Forms.Label IncorrectSelectedItemLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Instruction2Label;
        private System.Windows.Forms.ColumnHeader LoginColumn;
        private System.Windows.Forms.ColumnHeader EmailColumn;
        private System.Windows.Forms.ColumnHeader PeselColumn;
        private System.Windows.Forms.ColumnHeader AccountNumberColumn;
    }
}
