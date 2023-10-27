using System;

public class AccountManager
{
    private DateTime _date;

    // create Constructor without parameters

    public AccountManager()
    {
        _date = DateTime.Now;
    }
     SavingAccount savingAccount = new SavingAccount();
     CurrentAccount currentAccount = new CurrentAccount();
     BookAllProfitAccount bookAllProfitAccount = new BookAllProfitAccount(new FixedRateProfit(0.2));
     
    public void Star()
    {
        Console.Clear();
        
            Console.Write("What is the name of account owner? ");
            string customerName = Console.ReadLine();
            savingAccount.SetAccountOwner(customerName);
            currentAccount.SetAccountOwner(customerName);
            

        while(true)
        {
            Console.WriteLine($"Accounts Menu of Mrs {customerName} ");
            Console.WriteLine("\t1. Savings Account");
            Console.WriteLine("\t2. Current Account");
            Console.WriteLine("\t3. Book all profit Account");
            Console.WriteLine("\t4. print the bank statement of customers");
            Console.WriteLine("\t5. Quit");
            Console.Write("Choose an operation you want to do: ");
            int operationsChoose = int.Parse(Console.ReadLine());

            if ( operationsChoose == 1)
            {
                savingAccount.OperateInSavingAccount();
                
            }
            else if (operationsChoose == 2)
            {
                currentAccount.OperateInCurrentAccount();
            }
            else if (operationsChoose == 3)
            {
                
                bookAllProfitAccount.OperationInBookAllProfitAccount();
            }
            else if ( operationsChoose == 4)
            {
                bookAllProfitAccount.SetAccountOwner(customerName);
                DisplayAllAccountDetails();
        
                
            }
            else if ( operationsChoose == 5)
            {
                return;
            }
            else
            {
                Console.WriteLine("Choose de appropriate operation");
            }

        }

       
    }

     public void DisplayAllAccountDetails()
        {
            Console.WriteLine();
            Console.WriteLine($"Bank statement date: {_date}");
            Console.WriteLine();
            savingAccount.DisplayAccountDetails();
            currentAccount.DisplayAccountDetails();
            bookAllProfitAccount.DisplayAccountDetails();
        }
}