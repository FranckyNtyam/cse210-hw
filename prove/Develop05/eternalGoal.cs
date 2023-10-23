using System;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, int points): base (name, description, points)
    {}

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {base.GetPoint()} points!");
       int numberOfPoint = 0;
       Console.WriteLine($"You now have {numberOfPoint+=base.GetPoint()} points");
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

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetName()},{base.GetDescription()},{base.GetPoint()}";
    }

    public override string GetDetailsString()
    {
        return $"[] {base.GetName()} ({base.GetDescription()})";
    }
}