using P02.BankAccounts.Common;
using P02.BankAccounts.Contracts;
using P02.BankAccounts.Models.Customers;
using System.Text;

namespace P02.BankAccounts.Models.Accounts
{
   public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal monthlyInterestRate;

        public Account(Customer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get { return this.balance; }

            protected set
            {
                Validator.CheckForNegativeValues(value);

                this.balance = value;
            }
        }

        public decimal MonthlyInterestRate
        {
            get { return this.monthlyInterestRate; }

            protected set
            {
                Validator.CheckForNegativeValues(value);

                this.monthlyInterestRate = value;
            }
        }

        public abstract decimal CalculateInterest(int numberOfMonths);

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            stb.AppendLine($"Customer: {this.Customer.Name}");
            stb.AppendLine($"Account type: {this.Customer.Type}");
            stb.AppendLine($"Balance: {this.Balance}");

            return stb.ToString();
        }
    }
}
