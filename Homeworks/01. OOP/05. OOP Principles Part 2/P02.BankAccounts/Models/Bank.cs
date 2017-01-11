using P02.BankAccounts.Contracts;
using System.Collections.Generic;

namespace P02.BankAccounts.Models
{
    public class Bank
    {
        private ICollection<IAccount> accounts;

        public Bank()
        {
            this.Accounts = new List<IAccount>();
        }

        public ICollection<IAccount> Accounts
        {
            get { return this.accounts; }
            set { this.accounts = value; }
        }

        public void AddAccount(IAccount account)
        {
            this.Accounts.Add(account);
        }

        public void RemoveAcount(IAccount account)
        {
            this.Accounts.Remove(account);
        }
    }
}
