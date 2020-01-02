namespace Bank_App.UserControls
{
    partial class InvestmentsUserControl
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
            this.InvestmentsLabel = new System.Windows.Forms.Label();
            this.IncorrectSelectedItemLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Instruction2Label = new System.Windows.Forms.Label();
            this.Instruction1Label = new System.Windows.Forms.Label();
            this.InvestmentsList = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvestmentNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InterestColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FinishColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RefreshButton = new System.Windows.Forms.Button();
            this.RefreshLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InvestmentsLabel
            // 
            this.InvestmentsLabel.AutoSize = true;
            this.InvestmentsLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvestmentsLabel.Location = new System.Drawing.Point(20, 20);
            this.InvestmentsLabel.Name = "InvestmentsLabel";
            this.InvestmentsLabel.Size = new System.Drawing.Size(152, 25);
            this.InvestmentsLabel.TabIndex = 11;
            this.InvestmentsLabel.Text = "Investments";
            this.InvestmentsLabel.UseWaitCursor = true;
            // 
            // IncorrectSelectedItemLabel
            // 
            this.IncorrectSelectedItemLabel.AutoSize = true;
            this.IncorrectSelectedItemLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IncorrectSelectedItemLabel.ForeColor = System.Drawing.Color.Red;
            this.IncorrectSelectedItemLabel.Location = new System.Drawing.Point(20, 700);
            this.IncorrectSelectedItemLabel.Name = "IncorrectSelectedItemLabel";
            this.IncorrectSelectedItemLabel.Size = new System.Drawing.Size(251, 16);
            this.IncorrectSelectedItemLabel.TabIndex = 18;
            this.IncorrectSelectedItemLabel.Text = "Select at least one investment and try again.";
            this.IncorrectSelectedItemLabel.UseWaitCursor = true;
            this.IncorrectSelectedItemLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(20, 730);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(690, 40);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(20, 655);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(690, 40);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(20, 565);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(690, 40);
            this.CreateButton.TabIndex = 17;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Instruction2Label
            // 
            this.Instruction2Label.AutoSize = true;
            this.Instruction2Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Instruction2Label.Location = new System.Drawing.Point(20, 620);
            this.Instruction2Label.Name = "Instruction2Label";
            this.Instruction2Label.Size = new System.Drawing.Size(229, 21);
            this.Instruction2Label.TabIndex = 12;
            this.Instruction2Label.Text = "Delete selected investment.";
            this.Instruction2Label.UseWaitCursor = true;
            // 
            // Instruction1Label
            // 
            this.Instruction1Label.AutoSize = true;
            this.Instruction1Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Instruction1Label.Location = new System.Drawing.Point(20, 530);
            this.Instruction1Label.Name = "Instruction1Label";
            this.Instruction1Label.Size = new System.Drawing.Size(215, 21);
            this.Instruction1Label.TabIndex = 13;
            this.Instruction1Label.Text = "Create a new investment.";
            this.Instruction1Label.UseWaitCursor = true;
            // 
            // InvestmentsList
            // 
            this.InvestmentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.InvestmentNameColumn,
            this.TypeColumn,
            this.ValueColumn,
            this.InterestColumn,
            this.StartColumn,
            this.FinishColumn,
            this.DurationColumn});
            this.InvestmentsList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvestmentsList.FullRowSelect = true;
            this.InvestmentsList.GridLines = true;
            this.InvestmentsList.HideSelection = false;
            this.InvestmentsList.LabelWrap = false;
            this.InvestmentsList.Location = new System.Drawing.Point(20, 70);
            this.InvestmentsList.MultiSelect = false;
            this.InvestmentsList.Name = "InvestmentsList";
            this.InvestmentsList.Size = new System.Drawing.Size(690, 363);
            this.InvestmentsList.TabIndex = 19;
            this.InvestmentsList.UseCompatibleStateImageBehavior = false;
            this.InvestmentsList.View = System.Windows.Forms.View.Details;
            this.InvestmentsList.SelectedIndexChanged += new System.EventHandler(this.InvestmentsListView_SelectedIndexChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            // 
            // InvestmentNameColumn
            // 
            this.InvestmentNameColumn.Text = "Name";
            this.InvestmentNameColumn.Width = 200;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            this.TypeColumn.Width = 200;
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Value";
            this.ValueColumn.Width = 116;
            // 
            // InterestColumn
            // 
            this.InterestColumn.Text = "Interest";
            this.InterestColumn.Width = 100;
            // 
            // StartColumn
            // 
            this.StartColumn.Text = "Start";
            this.StartColumn.Width = 130;
            // 
            // DurationColumn
            // 
            this.DurationColumn.DisplayIndex = 6;
            this.DurationColumn.Text = "Duration";
            this.DurationColumn.Width = 130;
            // 
            // FinishColumn
            // 
            this.FinishColumn.Text = "Finish";
            this.FinishColumn.Width = 130;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(20, 475);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(690, 40);
            this.RefreshButton.TabIndex = 21;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // RefreshLabel
            // 
            this.RefreshLabel.AutoSize = true;
            this.RefreshLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RefreshLabel.Location = new System.Drawing.Point(20, 440);
            this.RefreshLabel.Name = "RefreshLabel";
            this.RefreshLabel.Size = new System.Drawing.Size(93, 21);
            this.RefreshLabel.TabIndex = 20;
            this.RefreshLabel.Text = "Refresh list.";
            this.RefreshLabel.UseWaitCursor = true;
            // 
            // InvestmentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.RefreshLabel);
            this.Controls.Add(this.InvestmentsList);
            this.Controls.Add(this.InvestmentsLabel);
            this.Controls.Add(this.IncorrectSelectedItemLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.Instruction2Label);
            this.Controls.Add(this.Instruction1Label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvestmentsUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InvestmentsLabel;
        private System.Windows.Forms.Label IncorrectSelectedItemLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label Instruction2Label;
        private System.Windows.Forms.Label Instruction1Label;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader InvestmentNameColumn;
        private System.Windows.Forms.ColumnHeader TypeColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.ColumnHeader InterestColumn;
        private System.Windows.Forms.ColumnHeader StartColumn;
        private System.Windows.Forms.ColumnHeader DurationColumn;
        private System.Windows.Forms.ColumnHeader FinishColumn;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label RefreshLabel;
        public System.Windows.Forms.ListView InvestmentsList;
    }
}
