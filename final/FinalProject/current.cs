using System;

public class CurrentAccount : Account
{
    private double _accountOverdraft;

    // create Constructor with one parameter
    public CurrentAccount()
    {
        _accountOverdraft = 200;
    }

    // method that help to operate in a current account

    public void OperateInCurrentAccount()
    {

           Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Types of Operations:");
            Console.WriteLine("1. Credited Account");
            Console.WriteLine("2. Debited Account");
            Console.Write("Choose the operation you want accomplish: ");
            int operationChoosing = int.Parse(Console.ReadLine());
            if (operationChoosing == 1)
            {
                Console.Write("What is the amount to be credited? ");
                int amountCredited = int.Parse(Console.ReadLine());
                base.Credited(amountCredited);
            }
            else if (operationChoosing == 2)
            {
               Console.Write("What is the amount to be debited? ");
                int amountDebited = int.Parse(Console.ReadLine());
                base.Debtor(amountDebited);
            }
            else
            {
                Console.WriteLine("Not operation done");
            }
    }
    public override void DisplayAccountDetails()
    {
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Console.WriteLine("Current account of : " + base.GetAccountOwner());
        Console.WriteLine($"\tBalance : {_balance}" );
        Console.WriteLine($"\tOverdraft allowed : {_accountOverdraft}");
        Console.WriteLine("\n\nOperations :");
        base.DisplayOperations();

        
    }
}