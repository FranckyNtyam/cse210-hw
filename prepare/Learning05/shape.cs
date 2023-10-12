using System.Collections.Generic;
using System;

public abstract class Shape
{
    private string _color;

    // create getter and setter of member variable.

    public string GetColor()
    {
        return _color;
    }
    public void SetColor( string color)
    {
        _color = color;
    }

    // Create the constructor 

    public Shape(string color)
    {
        _color = color;
    }

    // Create a virtual method for get area.

    public abstract double GetArea();
    


}