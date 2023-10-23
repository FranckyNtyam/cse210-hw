using System;

public class NegativeGoal : Goal
{

    
    public NegativeGoal(string name, string description, int points): base (name, description, points)
    {
        name = "Unknown";
        description = "Unknown";
        points = 0;
        
    }

    public override void RecordEvent()
     {
       Console.WriteLine($"Sorry! You will lose {base.GetPoint()} points!");
       int numberOfPoint = 0;
       Console.WriteLine($"You lost {numberOfPoint+=base.GetPoint()} points");
     }
    public override bool IsComplete()
    {
        if (base.GetName() !="" && base.GetDescription() !="" && base.GetPoint() != 0)
        {
            return true;
        }
        else
        {
            return false;
        }

        
    }

    public override string GetDetailsString()
    {
      
        return $"[] {base.GetName()} ({base.GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{base.GetName()},{base.GetDescription()},{base.GetPoint()}";
    }

   
}