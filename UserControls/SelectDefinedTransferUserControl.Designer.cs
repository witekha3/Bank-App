namespace Bank_App.UserControls
{
    partial class SelectDefinedTransferUserControl
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
            this.SelectDefinedTransferLabel = new System.Windows.Forms.Label();
            this.DefinedTransferListView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefreshButton = new System.Windows.Forms.Button();
            this.Instruction1Label = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectDefinedTransferLabel
            // 
            this.SelectDefinedTransferLabel.AutoSize = true;
            this.SelectDefinedTransferLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectDefinedTransferLabel.Location = new System.Drawing.Point(20, 20);
            this.SelectDefinedTransferLabel.Name = "SelectDefinedTransferLabel";
            this.SelectDefinedTransferLabel.Size = new System.Drawing.Size(324, 34);
            this.SelectDefinedTransferLabel.TabIndex = 2;
            this.SelectDefinedTransferLabel.Text = "Select Defined Transfer";
            this.SelectDefinedTransferLabel.UseWaitCursor = true;
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
            this.DefinedTransferListView.Size = new System.Drawing.Size(690, 530);
            this.DefinedTransferListView.TabIndex = 5;
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
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(20, 655);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(690, 40);
            this.RefreshButton.TabIndex = 7;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // Instruction1Label
            // 
            this.Instruction1Label.AutoSize = true;
            this.Instruction1Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Instruction1Label.Location = new System.Drawing.Point(20, 620);
            this.Instruction1Label.Name = "Instruction1Label";
            this.Instruction1Label.Size = new System.Drawing.Size(114, 23);
            this.Instruction1Label.TabIndex = 6;
            this.Instruction1Label.Text = "Refresh list.";
            this.Instruction1Label.UseWaitCursor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(20, 730);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(690, 40);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectDefinedTransferUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.Instruction1Label);
            this.Controls.Add(this.DefinedTransferListView);
            this.Controls.Add(this.SelectDefinedTransferLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectDefinedTransferUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectDefinedTransferLabel;
        private System.Windows.Forms.ListView DefinedTransferListView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader LastValueColumn;
        private System.Windows.Forms.ColumnHeader AccountNumberColumn;
        private System.Windows.Forms.ColumnHeader DateColumn;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label Instruction1Label;
        private System.Windows.Forms.Button CancelButton;
    }
}
