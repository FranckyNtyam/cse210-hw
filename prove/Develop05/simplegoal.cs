using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    
    public SimpleGoal(string name, string description, int points): base (name, description, points)
    {
        name = "Unknown";
        description = "Unknown";
        points = 0;
        _isComplete = false;
    }

    public override void RecordEvent()
     {
       Console.WriteLine($"Congratulations! You have earned {base.GetPoint()} points!");
       int numberOfPoint = 0;
       Console.WriteLine($"You now have {numberOfPoint+=base.GetPoint()} points");
     }
    public override bool IsComplete()
    {
        if (base.GetPoint() != 0 )
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }

        return _isComplete;
    }

    public override string GetDetailsString()
    {
      
        return $"[] {base.GetName()} ({base.GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetName()},{base.GetDescription()},{base.GetPoint()},{IsComplete()}";
    }

   
}