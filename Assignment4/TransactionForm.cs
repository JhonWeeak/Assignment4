using Assignment4.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class TransactionForm : Form
    {

        private MainForm mainForm;

        public TransactionForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            UpdateComboBoxItems();
            txtAmout.Text = string.Empty;
            txtCreateDescription.Text = string.Empty;
        }
        public void UpdateComboBoxItems()
        {
            cmbAccount.Items.Clear();

            cmbAccount.DataSource = mainForm.userDetail.accounts;
            cmbAccount.ValueMember = "AccountId";
            cmbAccount.DisplayMember = "AccountType";
        }


        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MDFContext())
                {
                    // Parse input data
                    int amount = int.Parse(txtAmout.Text);
                    int accountID = int.Parse(cmbAccount.SelectedValue.ToString());
                    string description = txtCreateDescription.Text;

                    // Create new transaction
                    var transaction = new TransactionHistory
                    {
                        AccountId = accountID,
                        TransactionDate = DateTime.Now,
                        Description = description,
                        Amount = amount
                    };

                    // Add transaction to userDetail and context
                    mainForm.userDetail.transactions.Add(transaction);
                    context.TransactionHistories.Add(transaction);

                    // Update account balance
                    var accountToUpdate = mainForm.userDetail.accounts.FirstOrDefault(a => a.AccountId == accountID);
                    if (accountToUpdate != null)
                    {
                        accountToUpdate.CurrentBalance -= amount;
                    }

                    var accountInContext = context.Accounts.FirstOrDefault(a => a.AccountId == accountID);
                    if (accountInContext != null)
                    {
                        accountInContext.CurrentBalance -= amount;
                    }

                    // Save changes
                    context.SaveChanges();

                    // Update UI
                    mainForm.UpdateAccountList();
                    mainForm.UpdateTransactionDataGridView();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
