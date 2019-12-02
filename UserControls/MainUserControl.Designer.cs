namespace Bank_App.UserControls
{
    partial class MainUserControl
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
            this.HelloLabel = new System.Windows.Forms.Label();
            this.CentralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CentralPanel
            // 
            this.CentralPanel.Controls.Add(this.HelloLabel);
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CentralPanel.Location = new System.Drawing.Point(0, 0);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(730, 800);
            this.CentralPanel.TabIndex = 0;
            // 
            // HelloLabel
            // 
            this.HelloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelloLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelloLabel.Location = new System.Drawing.Point(0, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(730, 800);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Good Morning, Username";
            this.HelloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HelloLabel.Click += new System.EventHandler(this.HelloLabel_Click);
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CentralPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(730, 800);
            this.Load += new System.EventHandler(this.MainUserControl_Load);
            this.CentralPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.Label HelloLabel;
    }
}
