using P02.BankAccounts.Contracts;
using P02.BankAccounts.Models.Customers;

namespace P02.BankAccounts.Models.Accounts
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal monthlyInterestRate)
            : base(customer, balance, monthlyInterestRate)
        {
        }

        public override decimal CalculateInterest(int numberOfMonths)
        {
            if (Customer.Type == CustomerType.Company)
            {
                if (numberOfMonths < 12)
                {
                    return (this.MonthlyInterestRate / 2) * numberOfMonths;
                }

                else
                {
                    decimal interestForFirstTwelveM = (this.MonthlyInterestRate / 2) * 12;
                    decimal interestForTheRestOfThePeriod = (numberOfMonths - 12) * this.MonthlyInterestRate;
                    decimal theWholeInterest = (interestForFirstTwelveM + interestForTheRestOfThePeriod) / 2;

                    return theWholeInterest;
                }
            }

            else
            {
                if (numberOfMonths < 6)
                {
                    return 0;
                }

                else
                {
                    decimal interestForTheRestOfThePeriod = (numberOfMonths - 6) * this.MonthlyInterestRate;

                    return interestForTheRestOfThePeriod;
                }
            }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
    }
}
