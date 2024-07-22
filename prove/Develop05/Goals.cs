using System.Diagnostics.Contracts;

class Goals 
{
    private string _goal;
    private string _goalDescription; 
    int _point;

    public Goals(string goal, string goalDescription)
    {
        _goal = goal;
        _goalDescription = goalDescription;
    }
}