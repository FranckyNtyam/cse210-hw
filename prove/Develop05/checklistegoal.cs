using System;

public class CheckListGoal: Goal
{
private int _amountCompleted = 0;
private int _target;
private int _bonus;
// create the Getter and setter of the attributes

public int GetTarget()
{
  return _target;
}
public void SetTarget(int target)
{
  _target = target;
}
public int GetBonus()
{
  return _bonus;
}
public void SetBonus(int bonus)
{
  _bonus = bonus;
}
public int GetAmountCompleted()
{
  return _amountCompleted;
}
public void SetAmountCompleted(int amountCompleted)
{
  _amountCompleted = amountCompleted;
}

public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted): base (name, description, points)
{
    _target = target;
    _bonus = bonus;
    _amountCompleted = amountCompleted;
}

  public override string GetDetailsString()
    {
        return $"[] {base.GetName()} ({base.GetDescription()}) --Currently completed: {_amountCompleted}/{_target}";
    }

  

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {base.GetPoint()} points!");
        int numberOfPoint = 0;
        Console.WriteLine($"You now have {numberOfPoint+=base.GetPoint()} points");
    }

    public override bool IsComplete()
    {
        if (base.GetName() !="" && base.GetDescription() !="" && base.GetPoint() != 0 && _amountCompleted == _target)
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
        return $"CheckListGoal:{base.GetName()},{base.GetDescription()},{base.GetPoint()},{_bonus},{_target},{_amountCompleted}";
    }
}