using System;

public abstract class Activity
{
    private string _name ;
    public string GetName()
    {
        return _name;
    }
     public void SetName(string name)
    {
        _name = name;
    }
    private string _description;
     public string GetDescription()
    {
        return _description;
    }
     public void SetDescription(string description)
    {
        _description = description;
    }
    private int _duration;
      public int GetDuration()
    {
        return _duration;
    }
     public void SetDuration(int duration)
    {
        _duration = duration;
    }
    // create constructor without parameter

    public Activity()
    {
        _name = "Unknown";
        _description = "Unknown";
        _duration = 5;
    }

    // create methods for starting message

    public abstract void DisplayStartingMessage();
    public abstract void DisplayEndingMessage();
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> stringsInMoving = new List<string>(){"|","/","-","\\","|","/","-","\\"};
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string movingString = stringsInMoving[i];
            Console.Write(movingString);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
            i++;
            if (i >= stringsInMoving.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for ( int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
    }
}