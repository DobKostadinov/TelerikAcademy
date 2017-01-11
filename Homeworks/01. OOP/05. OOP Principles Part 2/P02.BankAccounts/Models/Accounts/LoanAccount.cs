using P02.BankAccounts.Contracts;
using P02.BankAccounts.Models.Customers;

namespace P02.BankAccounts.Models.Accounts
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (this.Customer.Type == CustomerType.Individual)
            {
                return this.MonthlyInterestRate * (numberOfMonths - 3);
            }

            return this.MonthlyInterestRate * (numberOfMonths - 2);
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
