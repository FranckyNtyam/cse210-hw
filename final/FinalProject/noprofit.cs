using System;

public class NoProfit: IProfitCalculator
{
    public decimal CalculateProfit(decimal _balance)
    {
        return _balance;
    }
    public double Rate
    {
        get
        {
            return 0;
        }
    }
}