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
    public partial class SelectDefinedTransferUserControl : UserControl
    {
        public SelectDefinedTransferUserControl()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["transferUserControl"].BringToFront();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

        }

        private void Instruction1Label_Click(object sender, EventArgs e)
        {

        }
    }
}
