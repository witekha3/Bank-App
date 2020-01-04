using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_App.Classes;

namespace Bank_App.UserControls
{
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
            HelloLabel.Text = "Good Morning, " + LogInManager.WhoIsCurrentLoged + "\n Today is: " + DateTime.Now.ToString("D");

        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {

        }

        private void HelloLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
