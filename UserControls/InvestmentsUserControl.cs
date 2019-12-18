﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App.UserControls
{
    public partial class InvestmentsUserControl : UserControl
    {
        public InvestmentsUserControl()
        {
            InitializeComponent();
        }
        private void ResetControls()
        {
            IncorrectSelectedItemLabel.Visible = false;
        }

        private void Delete()
        {

            ResetControls();

            try
            {
                InvestmentsListView.SelectedItems[0].Remove();
            }
            catch (ArgumentOutOfRangeException)
            {
                IncorrectSelectedItemLabel.Visible = true;
            }

        }

        private void Cancel()
        {
            ResetControls();
            this.Parent.Controls["MainUserControl"].BringToFront();
        }

        private void Create()
        {
            ResetControls();
            this.Parent.Controls["addingInvestmentUserControl"].BringToFront();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

        }
    }
}
