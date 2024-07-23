using System.Diagnostics.Contracts;

class Goals 
{
    private List<Goal>  _goals; 
    private int _totalscore;

    public Goals()
    {
        _goals = new List<Goal>();
        _totalscore = 0;
    }
    public void DisplayGoals()
    {
        int count = 1;

        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{count++}. {goal.ToString()}");
        }
    }
    public void AddGoal (Goal g)//This is the process to add the goal. 
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
}