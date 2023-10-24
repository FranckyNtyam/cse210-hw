using System;

public class RandomProfit: IProfitCalculator
{
    private double _rate;
    private Random _random;

    // create constructor without parameter

    public RandomProfit()
    {
        _random = new Random();
        _rate = _random.NextDouble();
    }

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