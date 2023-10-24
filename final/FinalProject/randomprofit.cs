using System;

public class RandomProfit: IProfitCalculator
{
    private double _rate;
    private Random random;

    // create constructor without parameter

    public RandomProfit()
    {
        random = new Random();
        _rate = random.NextDouble();
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