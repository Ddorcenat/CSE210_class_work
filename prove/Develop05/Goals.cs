using System.Diagnostics.Contracts;

class Goals 
{
    private List<Goal>  _goals; 

    public Goals()
    {
        _goals = new List<Goal>();
    }
    public void DisplayGoals()
    {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.ToString());
        }
    }
    public void AddGoal (Goal g)//This is the process to add the goal. 
    {
        _goals.Add(g);
    }
}