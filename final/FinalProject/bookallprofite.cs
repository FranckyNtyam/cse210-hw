using System;

public class BookAllProfitAccount: Account
{
    private IProfitCalculator _profitCalculator;
    public BookAllProfitAccount(IProfitCalculator calculator)
    {
        _profitCalculator = calculator;
    }
    public override decimal _balance 
    {
        get
        {
          return _profitCalculator.CalculateProfit(base._balance) ;
        }
        
    }

        public void OperationInBookAllProfitAccount()
           {
          
            Console.WriteLine();
            Console.Write("Apply some fixe rate in this account: ");
             double rateApply = double.Parse(Console.ReadLine());
            IProfitCalculator fixedRateProfit = new FixedRateProfit(rateApply);
            new BookAllProfitAccount(fixedRateProfit);
            Console.WriteLine("Types of Operations:");
            Console.WriteLine("1. Credited Account");
            Console.WriteLine("2. Debited Account");
            Console.Write("Choose the operation you want accomplish: ");
            int operationChoosing = int.Parse(Console.ReadLine());
        
             if (operationChoosing == 1)
            {
                Console.Write("What is the amount to be credited? ");
                int amountCredited = int.Parse(Console.ReadLine());
                Credited(amountCredited);
            }
            else if (operationChoosing == 2)
            {
               Console.Write("What is the amount to be debited? ");
                int amountDebited = int.Parse(Console.ReadLine());
                Debtor(amountDebited);
            }
            else
            {
                Console.WriteLine("Not operation done");
            }
        }

    public override void DisplayAccountDetails()
    {
        Console.WriteLine("*************************************");
        Console.WriteLine("Book all profit account of : " + base.GetAccountOwner());
        Console.WriteLine($"\tBalance : {_balance}" );
        Console.WriteLine($"\tRate : {_profitCalculator.Rate}");
        Console.WriteLine("\n\nOperations :");
        base.DisplayOperations();
        

        Console.WriteLine("*************************************");
    }
}