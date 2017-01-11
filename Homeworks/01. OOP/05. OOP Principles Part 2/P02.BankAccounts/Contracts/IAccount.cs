namespace P02.BankAccounts.Contracts
{
    public interface IAccount
    {
        decimal CalculateInterest(int numberOfMonths);
    }
}
