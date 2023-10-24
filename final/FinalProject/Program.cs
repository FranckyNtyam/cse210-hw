using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my final project");

        AccountManager  accountManager = new AccountManager();

        accountManager.Star();
        // CurrentAccount currentAccount = new CurrentAccount();
        // SavingAccount savingAccount = new SavingAccount();
        // IProfitCalculator fixedRateProfit = new FixedRateProfit(0.275);
        // BookAllprofitAccount bookAllprofitAccount = new BookAllprofitAccount(fixedRateProfit);
        // bookAllprofitAccount.Credited(800);
        // bookAllprofitAccount.Credited(100);
        // bookAllprofitAccount.DisplayAccountDetails();
        
        // currentAccount.OperateInCurrentAccount();
        // savingAccount.OperateInSavingAccount();
        // currentAccount.DisplayAccountDetails();
        // savingAccount.DisplayAccountDetails();
    }
}