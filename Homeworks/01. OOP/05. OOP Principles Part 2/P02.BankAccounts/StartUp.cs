using P02.BankAccounts.Contracts;
using P02.BankAccounts.Models;
using P02.BankAccounts.Models.Accounts;
using P02.BankAccounts.Models.Customers;
using System;

namespace P02.BankAccounts
{
    public class StartUp
    {
        public static void Main()
        {
            Bank bank = new Bank();

            Customer pesho = new Customer("Pesho", CustomerType.Individual);
            Customer milko = new Customer("Milko", CustomerType.Individual);
            Customer jichka = new Customer("jichka", CustomerType.Individual);

            Customer dell = new Customer("Dell", CustomerType.Company);
            Customer hp = new Customer("HP", CustomerType.Company);
            Customer apple = new Customer("Apple", CustomerType.Company);

            DepositAccount peshoAccount = new DepositAccount(pesho, 4300, 2.2m);
            LoanAccount milkoAccount = new LoanAccount(milko, 9999, 3.7m);
            MortgageAccount jichkaAccount = new MortgageAccount(jichka, 559, 1.2m);

            Account dellAccount = new DepositAccount(dell, 17631782.4234m, 7.1m);
            Account hpAccount = new LoanAccount(hp, 111111.1114m, 4.4m);
            Account appleAccount = new MortgageAccount(apple, 1888631782.4934234m, 11.1m);

            peshoAccount.Deposit(400.50m);
            peshoAccount.Withdraw(200);

            bank.AddAccount(peshoAccount);
            bank.AddAccount(milkoAccount);
            bank.AddAccount(jichkaAccount);
            bank.AddAccount(dellAccount);
            bank.AddAccount(hpAccount);
            bank.AddAccount(appleAccount);

            foreach (IAccount account in bank.Accounts)
            {
                Console.WriteLine($"{account} -- with interest for 23 months -> {account.CalculateInterest(23):F1}\n");
            }
        }
    }
}
