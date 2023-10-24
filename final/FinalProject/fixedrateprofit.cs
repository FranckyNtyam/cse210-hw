using System;

public class FixedRateProfit: IProfitCalculator
{
    private double _rate;

    // create Constructor with one parameter

    public FixedRateProfit(double fixedRate)
    {
        _rate = fixedRate;
    }

    // create method to calculate profit.

    public decimal CalculateProfit(decimal _balance)
    {
        return _balance * (decimal)(1 + _rate);
    }
    public double Rate
    {
        get
        {
            return _rate;
        }
    }
}