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
    public partial class DefinedTransferUserControl : UserControl
    {
        DataBaseManager dataBaseManager = new DataBaseManager();
        TransferManager transferManager = new TransferManager();
        public DefinedTransferUserControl()
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
                string title = TransferHistoryListView.SelectedItems[0].Text;
                string accountNumber = TransferHistoryListView.SelectedItems[0].SubItems[2].Text;
                string date = TransferHistoryListView.SelectedItems[0].SubItems[3].Text;

                transferManager.DeleteFromTransferHistory(title, accountNumber, date);

                TransferHistoryListView.SelectedItems[0].Remove();
            }
            catch (ArgumentOutOfRangeException)
            {
                IncorrectSelectedItemLabel.Visible = true;
            }
        }

        public void ShowTransferHistory()
        {
            DataTable data = transferManager.GetTransferHistoryFromDataBase();

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
                    TransferHistoryListView.Items.Add(item);
                }
            }
            catch(IndexOutOfRangeException)
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
            TransferHistoryListView.Items.Clear();
            ShowTransferHistory();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void DefinedTransferUserControl_Load(object sender, EventArgs e)
        {
            ShowTransferHistory();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }
    }
}
