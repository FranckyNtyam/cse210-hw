using System;

public class CheckListGoal: Goal
{
private int _amountCompleted;
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
public CheckListGoal(string name, string description, int points, int target, int bonus): base (name, description, points)
{
    _target = target;
    _bonus = bonus;
}

  public override string GetDetailsString()
    {
        return "";
    }

  

    public override void RecordEvent()
    {
     
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }
}