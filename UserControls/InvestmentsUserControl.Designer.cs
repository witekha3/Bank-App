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
            this.InvestmentsListView = new System.Windows.Forms.ListView();
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InterestColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvestmentsLabel = new System.Windows.Forms.Label();
            this.IncorrectSelectedItemLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Instruction2Label = new System.Windows.Forms.Label();
            this.Instruction1Label = new System.Windows.Forms.Label();
            this.TypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // InvestmentsListView
            // 
            this.InvestmentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdColumn,
            this.TypeColumn,
            this.ValueColumn,
            this.DurationColumn,
            this.InterestColumn});
            this.InvestmentsListView.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvestmentsListView.FullRowSelect = true;
            this.InvestmentsListView.GridLines = true;
            this.InvestmentsListView.HideSelection = false;
            this.InvestmentsListView.LabelWrap = false;
            this.InvestmentsListView.Location = new System.Drawing.Point(20, 70);
            this.InvestmentsListView.Name = "InvestmentsListView";
            this.InvestmentsListView.Size = new System.Drawing.Size(690, 450);
            this.InvestmentsListView.TabIndex = 14;
            this.InvestmentsListView.UseCompatibleStateImageBehavior = false;
            this.InvestmentsListView.View = System.Windows.Forms.View.Details;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Id";
            // 
            // ValueColumn
            // 
            this.ValueColumn.Text = "Value";
            this.ValueColumn.Width = 100;
            // 
            // DurationColumn
            // 
            this.DurationColumn.DisplayIndex = 4;
            this.DurationColumn.Text = "Duration";
            this.DurationColumn.Width = 200;
            // 
            // InterestColumn
            // 
            this.InterestColumn.DisplayIndex = 3;
            this.InterestColumn.Text = "Interest";
            this.InterestColumn.Width = 100;
            // 
            // InvestmentsLabel
            // 
            this.InvestmentsLabel.AutoSize = true;
            this.InvestmentsLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvestmentsLabel.Location = new System.Drawing.Point(20, 20);
            this.InvestmentsLabel.Name = "InvestmentsLabel";
            this.InvestmentsLabel.Size = new System.Drawing.Size(175, 34);
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
            this.IncorrectSelectedItemLabel.Size = new System.Drawing.Size(352, 19);
            this.IncorrectSelectedItemLabel.TabIndex = 18;
            this.IncorrectSelectedItemLabel.Text = "Select at least one defined transfer and try again.";
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
            // 
            // Instruction2Label
            // 
            this.Instruction2Label.AutoSize = true;
            this.Instruction2Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Instruction2Label.Location = new System.Drawing.Point(20, 620);
            this.Instruction2Label.Name = "Instruction2Label";
            this.Instruction2Label.Size = new System.Drawing.Size(286, 23);
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
            this.Instruction1Label.Size = new System.Drawing.Size(266, 23);
            this.Instruction1Label.TabIndex = 13;
            this.Instruction1Label.Text = "Create a new investment.";
            this.Instruction1Label.UseWaitCursor = true;
            // 
            // TypeColumn
            // 
            this.TypeColumn.Text = "Type";
            this.TypeColumn.Width = 226;
            // 
            // InvestmentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.InvestmentsListView);
            this.Controls.Add(this.InvestmentsLabel);
            this.Controls.Add(this.IncorrectSelectedItemLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.Instruction2Label);
            this.Controls.Add(this.Instruction1Label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InvestmentsUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView InvestmentsListView;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader ValueColumn;
        private System.Windows.Forms.ColumnHeader DurationColumn;
        private System.Windows.Forms.ColumnHeader InterestColumn;
        private System.Windows.Forms.Label InvestmentsLabel;
        private System.Windows.Forms.Label IncorrectSelectedItemLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label Instruction2Label;
        private System.Windows.Forms.Label Instruction1Label;
        private System.Windows.Forms.ColumnHeader TypeColumn;
    }
}
