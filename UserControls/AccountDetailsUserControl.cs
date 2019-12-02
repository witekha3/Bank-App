using System;
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
    public partial class AccountDetailsUserControl : UserControl
    {
        public AccountDetailsUserControl()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls["MainUserControl"].BringToFront();
        }

    }
}
