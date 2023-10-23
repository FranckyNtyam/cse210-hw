using System.IO;
using System.Collections.Generic;
using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Star()
    {
        while (true)
        {
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goal");
            Console.WriteLine("\t3. Save Goal");
            Console.WriteLine("\t4. Load Goal");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                CreateGoal();
            }
            if (userChoice == 2)
            {
                ListGoalDetails();
            }
            if (userChoice == 3)
            {
                SaveGoals();
            }
            if (userChoice == 4)
            {
                LoadGoals();
            }
            if (userChoice == 5)
            {
                RecordEvent();
            }
            if (userChoice == 6)
            {
                return;
            }
       }
    }
    SimpleGoal simpleGoal = new SimpleGoal("","",0);
    EternalGoal eternalGoal = new EternalGoal("","",0);
    CheckListGoal checkListGoal = new CheckListGoal("","", 0, 0,0,0);
    NegativeGoal negativeGoal = new NegativeGoal("","",0);
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames()
    {
        int i = 1;
      foreach(Goal goal in _goals)
      {
        
        Console.WriteLine($"{i}. {goal.GetName()}");
        i++;
      }
    }
    public void ListGoalDetails()
    {
        List<string> listOfGoalDetail = new List<string>();
        listOfGoalDetail.Add(simpleGoal.GetDetailsString());
        listOfGoalDetail.Add(eternalGoal.GetDetailsString());
        listOfGoalDetail.Add(checkListGoal.GetDetailsString());
        listOfGoalDetail.Add(negativeGoal.GetDetailsString());
        
        int i = 1;
        foreach (string goaldetail in listOfGoalDetail)
        {
            Console.WriteLine($"{i}. {goaldetail}");
            i++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. CheckList Goal");
         Console.WriteLine("\t4. Negative Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        int userChoice = int.Parse(userInput);
        if (userChoice == 1)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            simpleGoal.SetName(goalName);
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();            simpleGoal.SetDescription(goalDescription);
            Console.Write("What is the amount of point associated with this goal? ");
            simpleGoal.SetPoint(int.Parse(Console.ReadLine()));
            _goals.Add( new SimpleGoal(simpleGoal.GetName(), simpleGoal.GetDescription(), simpleGoal.GetPoint()));
        }
        else if (userChoice == 2)
        {
            Console.Write("What is the name of your goal? ");
            eternalGoal.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            eternalGoal.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of point associated with this goal? ");
            eternalGoal.SetPoint(int.Parse(Console.ReadLine()));
            _goals.Add( new EternalGoal(eternalGoal.GetName(), eternalGoal.GetDescription(), eternalGoal.GetPoint()));
        }
        else if (userChoice == 3)
        {
            Console.Write("What is the name of your goal? ");
            checkListGoal.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            checkListGoal.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of point associated with this goal? ");
            checkListGoal.SetPoint(int.Parse(Console.ReadLine()));
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            checkListGoal.SetTarget(int.Parse(Console.ReadLine()));
            Console.Write("What is the bonus for accomplishing it that many times? ");
            checkListGoal.SetBonus(int.Parse(Console.ReadLine()));
            _goals.Add( new CheckListGoal(checkListGoal.GetName(), checkListGoal.GetDescription(), checkListGoal.GetPoint(), checkListGoal.GetBonus(), checkListGoal.GetTarget(), checkListGoal.GetAmountCompleted()));
        }
         else if (userChoice == 4)
        {
            Console.Write("What is the name of bad habits goal You are suppose to never repeat? ");
            negativeGoal.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            negativeGoal.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of point associated with this goal you will lost if accomplish? ");
            negativeGoal.SetPoint(int.Parse(Console.ReadLine()));
            _goals.Add( new EternalGoal(negativeGoal.GetName(), negativeGoal.GetDescription(), negativeGoal.GetPoint()));
        }
       
    }
    public void RecordEvent()
    {

        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine());
        List<string> objectGoal = new List<string>();
        for (int i = 0; i< _goals.Count; i++)
        {

            objectGoal.Add(_goals[i].GetName());
        }
          if (objectGoal[userInput-1] == simpleGoal.GetName())
            {
                simpleGoal.RecordEvent();
                _score += simpleGoal.GetPoint();
            }
            else if (objectGoal[userInput-1] == eternalGoal.GetName())
            {
                eternalGoal.RecordEvent();
                _score += eternalGoal.GetPoint();
            }
            else if (objectGoal[userInput-1] == checkListGoal.GetName())
            {
                checkListGoal.RecordEvent();
                _score += checkListGoal.GetPoint();

               
            }
            else if (objectGoal[userInput-1] == negativeGoal.GetName())
            {
                negativeGoal.RecordEvent();
                _score -= negativeGoal.GetPoint();

               
            }
            else
            {
                Console.WriteLine("You don't have goals");
            }
    
    }

    public void SaveGoals()
    {
         List<string> goalRepresentation = new List<string>();
         goalRepresentation.Add(simpleGoal.GetStringRepresentation());
         goalRepresentation.Add(eternalGoal.GetStringRepresentation());
         goalRepresentation.Add(checkListGoal.GetStringRepresentation());
         goalRepresentation.Add(negativeGoal.GetStringRepresentation());
        Console.Write("What is the filename for the goal file? ");
         string fileName = Console.ReadLine();
         using (StreamWriter outputFile = new StreamWriter(fileName))
         {
            outputFile.WriteLine(_score);
            foreach ( string goalrepresentation in goalRepresentation)
            {
                outputFile.WriteLine(goalrepresentation);
            }

         }
    }

    public void LoadGoals()
    {
         Console.Write("What is the filename for the goal file? ");
         string fileName = Console.ReadLine();
         string[] lines = System.IO.File.ReadAllLines(fileName);

         foreach (string line in lines)
         {
             string[] movetypeobject = line.Split(":");
             if (movetypeobject.Contains("SimpleGoal"))
             {
                string[] stringsDetails = movetypeobject[1].Split(",");
                simpleGoal.SetName(stringsDetails[0]);
                simpleGoal.SetDescription(stringsDetails[1]);
                simpleGoal.SetPoint(int.Parse(stringsDetails[2])); 
             }
            if (movetypeobject.Contains("EternalGoal"))
             {
                string[] stringsDetails = movetypeobject[1].Split(",");
                eternalGoal.SetName(stringsDetails[0]);
                eternalGoal.SetDescription(stringsDetails[1]);
                eternalGoal.SetPoint(int.Parse(stringsDetails[2])); 
             }
            if (movetypeobject.Contains("CheckListGoal"))
             {
                string[] stringsDetails = movetypeobject[1].Split(",");
                checkListGoal.SetName(stringsDetails[0]);
                checkListGoal.SetDescription(stringsDetails[1]);
                checkListGoal.SetPoint(int.Parse(stringsDetails[2])); 
                checkListGoal.SetBonus(int.Parse(stringsDetails[3]));
                checkListGoal.SetTarget(int.Parse(stringsDetails[4]));
                checkListGoal.SetAmountCompleted(int.Parse(stringsDetails[5]));
            }
              if (movetypeobject.Contains("NegativeGoal"))
             {
                string[] stringsDetails = movetypeobject[1].Split(",");
                negativeGoal.SetName(stringsDetails[0]);
                negativeGoal.SetDescription(stringsDetails[1]);
                negativeGoal.SetPoint(int.Parse(stringsDetails[2])); 
             }
             
         }
    }


}