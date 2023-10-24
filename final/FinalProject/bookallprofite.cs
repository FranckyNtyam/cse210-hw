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