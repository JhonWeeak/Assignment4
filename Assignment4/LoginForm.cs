using Assignment4.Models.Entities;
using Microsoft.VisualBasic.ApplicationServices;

namespace Assignment4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitUserData();
            InitializeComponent();
        }




        private void btnLogin_Click_1(object sender, EventArgs e)
        {
           
            string username = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username and password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            using (var context = new MDFContext())
            {

                Models.Entities.User userModel = context.Users.FirstOrDefault(u => u.Email == username && u.Password == password);
                if (userModel != null)
                {
                    MainForm mainForm = new MainForm(userModel);
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void InitUserData()
        {
            try
            {
                using (var context = new MDFContext())
                {
                    //var user1 = context.Users.ToList();
                    //if (user1 != null)
                    //{
                    //    context.Users.RemoveRange(user1);
                    //    context.SaveChanges();
                    //}

                    //var Account1 = context.Accounts.ToList();
                    //if (Account1 != null)
                    //{
                    //    context.Accounts.RemoveRange(Account1);
                    //    context.SaveChanges();
                    //}

                    if (context.Users.Count() == 0)
                    {
                        var user = new Models.Entities.User
                        {
                            Id = 1,
                            Firstname = "Maverick",
                            Lastname = "Li",
                            Email = "169458789@gmail.com",
                            Password = "123456",
                            DateCreated = DateTime.Now
                        };
                        context.Users.Add(user);
                        context.SaveChanges();

                        var account = new Models.Entities.Account
                        {
                            AccountType = "test1",
                            CurrentBalance = 1000,
                            DateCreated = DateTime.Now,
                            UserId = user.Id
                        };
                        context.Accounts.Add(account);

                        var account1 = new Models.Entities.Account
                        {
                            AccountType = "test2",
                            CurrentBalance = 200,
                            DateCreated = DateTime.Now,
                            UserId = user.Id
                        };
                        context.Accounts.Add(account1);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Get the screen size
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;

            // Calculate the position of the form to display it in the center of the screen
            int x = (screenBounds.Width - this.Width) / 2;
            int y = (screenBounds.Height - this.Height) / 2;

            // Set the position of the form
            this.Location = new Point(x, y);
        }
    }
}
