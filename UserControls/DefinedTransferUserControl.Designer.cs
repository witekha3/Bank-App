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
            this.TransferHistoryLabel = new System.Windows.Forms.Label();
            this.TransferHistoryListView = new System.Windows.Forms.ListView();
            this.TitleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Instruction1Label = new System.Windows.Forms.Label();
            this.Instruction2Label = new System.Windows.Forms.Label();
            this.IncorrectSelectedItemLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransferHistoryLabel
            // 
            this.TransferHistoryLabel.AutoSize = true;
            this.TransferHistoryLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransferHistoryLabel.Location = new System.Drawing.Point(20, 20);
            this.TransferHistoryLabel.Name = "TransferHistoryLabel";
            this.TransferHistoryLabel.Size = new System.Drawing.Size(215, 34);
            this.TransferHistoryLabel.TabIndex = 3;
            this.TransferHistoryLabel.Text = "Transfer History";
            this.TransferHistoryLabel.UseWaitCursor = true;
            // 
            // TransferHistoryListView
            // 
            this.TransferHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TitleColumn,
            this.LastValueColumn,
            this.AccountNumberColumn,
            this.DateColumn});
            this.TransferHistoryListView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TransferHistoryListView.FullRowSelect = true;
            this.TransferHistoryListView.GridLines = true;
            this.TransferHistoryListView.HideSelection = false;
            this.TransferHistoryListView.LabelWrap = false;
            this.TransferHistoryListView.Location = new System.Drawing.Point(20, 70);
            this.TransferHistoryListView.Name = "TransferHistoryListView";
            this.TransferHistoryListView.Size = new System.Drawing.Size(690, 450);
            this.TransferHistoryListView.TabIndex = 4;
            this.TransferHistoryListView.UseCompatibleStateImageBehavior = false;
            this.TransferHistoryListView.View = System.Windows.Forms.View.Details;
            // 
            // TitleColumn
            // 
            this.TitleColumn.Text = "Title";
            this.TitleColumn.Width = 178;
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
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(20, 565);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(690, 40);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
            this.Instruction1Label.Size = new System.Drawing.Size(114, 23);
            this.Instruction1Label.TabIndex = 3;
            this.Instruction1Label.Text = "Refresh list.";
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
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.TransferHistoryListView);
            this.Controls.Add(this.Instruction2Label);
            this.Controls.Add(this.Instruction1Label);
            this.Controls.Add(this.TransferHistoryLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DefinedTransferUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.Load += new System.EventHandler(this.DefinedTransferUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransferHistoryLabel;
        private System.Windows.Forms.ListView TransferHistoryListView;
        private System.Windows.Forms.ColumnHeader TitleColumn;
        private System.Windows.Forms.ColumnHeader LastValueColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.ColumnHeader AccountNumberColumn;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Instruction1Label;
        private System.Windows.Forms.Label Instruction2Label;
        private System.Windows.Forms.Label IncorrectSelectedItemLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}
