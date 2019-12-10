namespace Bank_App.UserControls
{
    partial class DefinedTransferUserControl
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
            this.DefinedTransfersLabel = new System.Windows.Forms.Label();
            this.DefinedTransferListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Instruction1Label = new System.Windows.Forms.Label();
            this.Instruction2Label = new System.Windows.Forms.Label();
            this.IncorrectSelectedItemLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DefinedTransfersLabel
            // 
            this.DefinedTransfersLabel.AutoSize = true;
            this.DefinedTransfersLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DefinedTransfersLabel.Location = new System.Drawing.Point(20, 20);
            this.DefinedTransfersLabel.Name = "DefinedTransfersLabel";
            this.DefinedTransfersLabel.Size = new System.Drawing.Size(244, 34);
            this.DefinedTransfersLabel.TabIndex = 3;
            this.DefinedTransfersLabel.Text = "Defined Transfers";
            this.DefinedTransfersLabel.UseWaitCursor = true;
            // 
            // DefinedTransferListView
            // 
            this.DefinedTransferListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.LastValueColumn,
            this.AccountNumberColumn,
            this.DateColumn});
            this.DefinedTransferListView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DefinedTransferListView.FullRowSelect = true;
            this.DefinedTransferListView.GridLines = true;
            this.DefinedTransferListView.HideSelection = false;
            this.DefinedTransferListView.LabelWrap = false;
            this.DefinedTransferListView.Location = new System.Drawing.Point(20, 70);
            this.DefinedTransferListView.Name = "DefinedTransferListView";
            this.DefinedTransferListView.Size = new System.Drawing.Size(690, 450);
            this.DefinedTransferListView.TabIndex = 4;
            this.DefinedTransferListView.UseCompatibleStateImageBehavior = false;
            this.DefinedTransferListView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 178;
            // 
            // LastValueColumn
            // 
            this.LastValueColumn.Text = "Value";
            this.LastValueColumn.Width = 100;
            // 
            // AccountNumberColumn
            // 
            this.AccountNumberColumn.Text = "Account Number";
            this.AccountNumberColumn.Width = 250;
            // 
            // DateColumn
            // 
            this.DateColumn.Text = "Date";
            this.DateColumn.Width = 156;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(20, 565);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(690, 40);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(20, 655);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(690, 40);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Instruction1Label
            // 
            this.Instruction1Label.AutoSize = true;
            this.Instruction1Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Instruction1Label.Location = new System.Drawing.Point(20, 530);
            this.Instruction1Label.Name = "Instruction1Label";
            this.Instruction1Label.Size = new System.Drawing.Size(312, 23);
            this.Instruction1Label.TabIndex = 3;
            this.Instruction1Label.Text = "Create a new defined transfer.";
            this.Instruction1Label.UseWaitCursor = true;
            // 
            // Instruction2Label
            // 
            this.Instruction2Label.AutoSize = true;
            this.Instruction2Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Instruction2Label.Location = new System.Drawing.Point(20, 620);
            this.Instruction2Label.Name = "Instruction2Label";
            this.Instruction2Label.Size = new System.Drawing.Size(332, 23);
            this.Instruction2Label.TabIndex = 3;
            this.Instruction2Label.Text = "Delete selected defined transfer.";
            this.Instruction2Label.UseWaitCursor = true;
            // 
            // IncorrectSelectedItemLabel
            // 
            this.IncorrectSelectedItemLabel.AutoSize = true;
            this.IncorrectSelectedItemLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectSelectedItemLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectSelectedItemLabel.Location = new System.Drawing.Point(20, 700);
            this.IncorrectSelectedItemLabel.Name = "IncorrectSelectedItemLabel";
            this.IncorrectSelectedItemLabel.Size = new System.Drawing.Size(352, 19);
            this.IncorrectSelectedItemLabel.TabIndex = 10;
            this.IncorrectSelectedItemLabel.Text = "Select at least one defined transfer and try again.";
            this.IncorrectSelectedItemLabel.UseWaitCursor = true;
            this.IncorrectSelectedItemLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(20, 730);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(690, 40);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DefinedTransferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.IncorrectSelectedItemLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.DefinedTransferListView);
            this.Controls.Add(this.Instruction2Label);
            this.Controls.Add(this.Instruction1Label);
            this.Controls.Add(this.DefinedTransfersLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DefinedTransferUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DefinedTransfersLabel;
        private System.Windows.Forms.ListView DefinedTransferListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader LastValueColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader AccountNumberColumn;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Instruction1Label;
        private System.Windows.Forms.Label Instruction2Label;
        private System.Windows.Forms.Label IncorrectSelectedItemLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}
