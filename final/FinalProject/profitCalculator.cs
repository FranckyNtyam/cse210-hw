using System;

public interface IProfitCalculator
{
    /* this interface will help each behavior of profit or not to respect this contract.*/
    decimal CalculateProfit(decimal _balance);
    double Rate {get;}
    
}