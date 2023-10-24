using System;

public class BookAllprofitAccount: Account
{
    private IProfitCalculator _profitCalculator;
    public BookAllprofitAccount(IProfitCalculator calculator)
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