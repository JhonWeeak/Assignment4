using Assignment4.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class UserDetail
    {
        public User user;
        public List<Account> accounts;
        public List<TransactionHistory> transactions;

        public UserDetail(User user, List<Account> accounts, List<TransactionHistory> transactions)
        {
            this.user = user;
            this.accounts = accounts;
            this.transactions = transactions;
        }
    }
}
