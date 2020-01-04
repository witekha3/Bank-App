using Bank_App.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_App.Forms
{
    public partial class AdminForm : Form
    {
        private AdminForm instance;

        public AdminForm Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new AdminForm();
                }

                return instance;
            }
        }

        public AdminForm()
        {
            InitializeComponent();
            CreateControls();
            CentralPanel.Controls["mainUserControl"].BringToFront();
        }

        private void CreateControls()
        {
            MainUserControl mainUserControl = new MainUserControl();
            mainUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(mainUserControl);

            AddingClientUserControl1 addingClientUserControl1 = new AddingClientUserControl1();
            addingClientUserControl1.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addingClientUserControl1);

            AddingClientUserControl2 addingClientUserControl2 = new AddingClientUserControl2();
            addingClientUserControl2.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(addingClientUserControl2);

            ShowClientDetailsUserControl showClientDetailsUserControl = new ShowClientDetailsUserControl();
            showClientDetailsUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(showClientDetailsUserControl);

            DeleteClientUserControl deleteClientUserControl = new DeleteClientUserControl();
            deleteClientUserControl.Dock = DockStyle.Fill;
            CentralPanel.Controls.Add(deleteClientUserControl);

        }

        private void logOut()
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }


        private void AddClientButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["addingClientUserControl1"].BringToFront();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void ShowClientDetailsButton_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["showClientDetailsUserControl"].BringToFront();
        }

        private void RemoveClient_Click(object sender, EventArgs e)
        {
            CentralPanel.Controls["deleteClientUserControl"].BringToFront();
        }
    }
}
