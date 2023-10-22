using  System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    //create the getter and setter of the attributes.

    public string GetName()
    {
        return _shortName;
    }
    public void SetName(string name)
    {
        _shortName = name;
    }
     public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
     public int GetPoint()
    {
        return _points;
    }
    public void SetPoint(int points)
    {
        _points = points;
    }
    
    //create constructor with the paramaters.
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    // create abstract methods 
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    
    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
   
}