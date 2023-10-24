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
            bookAllProfitAccount.SetAccountOwner(customerName);

        while(true)
        {
            Console.WriteLine($"Accounts Menu of Mrs {customerName} ");
            Console.WriteLine("\t1. Savings Account");
            Console.WriteLine("\t2. Current Account");
            Console.WriteLine("\t3. Book all profit Account");
            Console.WriteLine("\t4. print the bank statement of customers");
            Console.WriteLine("\t5. Quit");
            Console.Write("Choose account where you want to operate: ");
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
                OperationInBookAllProfitAccount();
            }
            else if ( operationsChoose == 4)
            {
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


          public void OperationInBookAllProfitAccount()
           {
          
            Console.WriteLine();
            Console.Write("Apply some fixe rate in this account: ");
             double rateApply = double.Parse(Console.ReadLine());
            IProfitCalculator fixedRateProfit = new FixedRateProfit(rateApply);
            bookAllProfitAccount = new BookAllProfitAccount(fixedRateProfit);
            Console.WriteLine("Types of Operations:");
            Console.WriteLine("1. Credited Account");
            Console.WriteLine("2. Debited Account");
            Console.Write("Choose the operation you want accomplish: ");
            int operationChoosing = int.Parse(Console.ReadLine());
        
             if (operationChoosing == 1)
            {
                Console.Write("What is the amount to be credited? ");
                int amountCredited = int.Parse(Console.ReadLine());
                bookAllProfitAccount.Credited(amountCredited);
            }
            else if (operationChoosing == 2)
            {
               Console.Write("What is the amount to be debited? ");
                int amountDebited = int.Parse(Console.ReadLine());
                bookAllProfitAccount.Debtor(amountDebited);
            }
            else
            {
                Console.WriteLine("Not operation done");
            }
        }

     public void DisplayAllAccountDetails()
        {
            Console.WriteLine();
            Console.WriteLine(_date);
            Console.WriteLine();
            savingAccount.DisplayAccountDetails();
            currentAccount.DisplayAccountDetails();
            bookAllProfitAccount.DisplayAccountDetails();
        }
}