using System.Diagnostics.Contracts;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

class Goals
{
    private List<Goal> _goals;
    private int _totalscore;

    public Goals()
    {
        _goals = new List<Goal>();
        _totalscore = 0;
    }
    public void DisplayGoals()
    {
        int count = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count++}. {goal.ToString()}");
        }
    }
    public void AddGoal(Goal g)//This is the process to add the goal. 
    {
        _goals.Add(g);
    }
    public void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Which goal do you wish to record ? ");
        int record = int.Parse(Console.ReadLine());
        _totalscore += _goals[record - 1].RecordEvent();
    }
    public void DisplayScore()
    {
        Console.WriteLine($"The total score is {_totalscore}");
    }

    public void LoadGoals()
    {
        Console.WriteLine("What file do you want to load?");
        string FileName = Console.ReadLine();
        if (File.Exists(FileName))
        {
            string[] lines = File.ReadAllLines(FileName);
            foreach(string line in lines)
            {
                string[] items = line.Split("#");
                if (items[0] == "Score")
                {
                    _totalscore = int.Parse(items[1]);
                }
                else
                {
                    string name = items[1];
                    string description = items[2];
                    bool status = bool.Parse(items[3]);
                    int numberOfPoints = int.Parse(items[4]);
                    if (items[0] == "Simple")
                    {
                        Simple simple = new Simple(name, description, numberOfPoints, status);
                        _goals.Add(simple);
                    }
                    else if (items[0] == "Eternal")
                    {
                        int completion = int.Parse(items[5]);
                        Eternal eternal = new Eternal(name, description, numberOfPoints, status, completion);
                        _goals.Add(eternal);
                    }
                }

            }
            
        }

    }
    public void SaveGoal() // function 
    {
        Console.WriteLine("What file name do you wish to use? ");
        string FileName = Console.ReadLine();
        StreamWriter streamWriter = new StreamWriter(FileName);
        streamWriter.WriteLine($"Score#{_totalscore}");
        foreach(Goal goal in _goals)
        {
            streamWriter.WriteLine(goal.FileSystemString());
        }
        streamWriter.Close();
    }

}