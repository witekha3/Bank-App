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
using Bank_App.Forms;

namespace Bank_App.UserControls
{
    public partial class DeleteClientUserControl : UserControl
    {
        AccountsManager accountsManager = new AccountsManager();
        DataBaseManager dataBaseManager = new DataBaseManager();

        public DeleteClientUserControl()
        {
            InitializeComponent();
        }
        private void ResetControls()
        {
            IncorrectSelectedItemLabel.Visible = false;
        }

        private void Delete()
        {
            try
            {
                string id = ClientsListView.SelectedItems[0].Text;
                string accountNumber = ClientsListView.SelectedItems[0].SubItems[4].Text;

                accountsManager.DeleteClientFromDataBase(id);
                accountsManager.DeleteAnotherRecordsRelatedToClient(accountNumber);

                ClientsListView.SelectedItems[0].Remove();
            }
            catch (ArgumentOutOfRangeException)
            {
                IncorrectSelectedItemLabel.Visible = true;
            }
            ResetControls();
        }

        public void ShowClients()
        {
            DataTable data = accountsManager.GetAllUsersFromDataBase();

            ListViewItem item;

            try
            {
                int rowsNumber = data.Rows.Count;

                for (int i = 0; i < rowsNumber; i++)
                {
                    item = new ListViewItem(data.Rows[i].ItemArray[0].ToString());
                    item.SubItems.Add(data.Rows[i].ItemArray[1].ToString());
                    item.SubItems.Add(data.Rows[i].ItemArray[2].ToString());
                    item.SubItems.Add(data.Rows[i].ItemArray[3].ToString());
                    item.SubItems.Add(data.Rows[i].ItemArray[4].ToString());

                    ClientsListView.Items.Add(item);
                }
            }
            catch (IndexOutOfRangeException)
            {

            }


        }

        private void Cancel()
        {
            ResetControls();
            this.Parent.Controls["MainUserControl"].BringToFront();
        }

        private void RefreshListView()
        {
            ClientsListView.Items.Clear();
            ShowClients();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteClientUserControl_Load(object sender, EventArgs e)
        {
            ShowClients();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }
    }
}
