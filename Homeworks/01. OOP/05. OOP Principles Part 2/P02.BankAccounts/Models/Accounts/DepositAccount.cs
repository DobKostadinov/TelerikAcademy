using P02.BankAccounts.Contracts;
using P02.BankAccounts.Models.Customers;

namespace P02.BankAccounts.Models.Accounts
{
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal monthlyInterestRate) 
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            else
            {
                return this.MonthlyInterestRate * numberOfMonths;
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
