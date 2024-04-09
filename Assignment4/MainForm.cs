using Assignment4.Models.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Assignment4
{
    public partial class MainForm : Form
    {
        public UserDetail userDetail;
        private readonly User user;

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadUserDetail();
            lblUserName.Text = $"{user.Firstname} {user.Lastname}";
            UpdateTransactionDataGridView();
            UpdateAccountList();
        }

        public void LoadUserDetail()
        {
            try
            {
                using (var context = new MDFContext())
                {
                    var accounts = context.Accounts.Where(a => a.UserId == user.Id).ToList();
                    var transactions = context.TransactionHistories
                        .Where(t => context.Accounts.Any(a => a.AccountId == t.AccountId && a.UserId == user.Id))
                        .ToList();

                    userDetail = new UserDetail(user, accounts, transactions);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void UpdateTransactionDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var t in userDetail.transactions)
            {
                string accountType = userDetail.accounts.FirstOrDefault(a => a.AccountId == t.AccountId).AccountType;
                dataGridView1.Rows.Add(
                t.TransactionId.ToString(),
                t.TransactionDate.ToString(),
                t.Amount,
                accountType,
                t.Description
                );
            }
        }
        public void UpdateAccountList()
        {
            lstAccountList.Items.Clear();
            foreach (var a in userDetail.accounts)
            {
                lstAccountList.Items.Add($"Account: {a.AccountType} -- {a.CurrentBalance}$");
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            // Get the screen size
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            // Calculate the position of the form to display it in the center of the screen
            int x = (screenBounds.Width - this.Width) / 2;
            int y = (screenBounds.Height - this.Height) / 2;

            // Set the position of the form
            this.Location = new Point(x, y);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var columnName = dataGridView1.Columns[e.ColumnIndex].Name;

                if (columnName == "Operate")
                {
                    //Display Confirmation Dialog
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (var context = new MDFContext())
                            {
                                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];

                                int transactionId = Convert.ToInt32(clickedRow.Cells[0].Value.ToString());
                                string accountType = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                                int accountID = userDetail.accounts.FirstOrDefault(a => a.AccountType == accountType).AccountId;
                                double amount = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value.ToString());

                                userDetail.transactions.Remove(userDetail.transactions.FirstOrDefault(t => t.TransactionId == transactionId));
                                context.TransactionHistories.Remove(context.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId));

                                userDetail.accounts.FirstOrDefault(a => a.AccountId == accountID).CurrentBalance += amount;
                                context.Accounts.FirstOrDefault(a => a.AccountId == accountID).CurrentBalance += amount;

                                context.SaveChanges();

                                UpdateAccountList();
                                UpdateTransactionDataGridView();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(this);
            transactionForm.StartPosition = FormStartPosition.CenterScreen;
            transactionForm.ShowDialog();
        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
