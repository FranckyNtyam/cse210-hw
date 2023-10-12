using System.Collections.Generic;
using System;

public class Square : Shape
{

    private double _side;
    /* Create a constructor that accepts the color and the side, and then call the base constructor with the color.*/
    public Square(string color, double side): base (color)
    {
        _side = side;
    }

    public override double GetArea()
    {
       return _side * _side;
    }

}