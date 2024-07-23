
using System.ComponentModel.DataAnnotations.Schema;

class Eternal : Goal
// public int _simpleGoal
{
    private int _totalcomplete;
    public Eternal() : base()
    {
        _totalcomplete = 0;
    }

    public Eternal(string name, string description, int numberOfPoints, bool status, int complete ): base(name, description, numberOfPoints, status)
    {
        _totalcomplete = complete;
    }
    public override void RunGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }
    public override int RecordEvent()
    {
        _totalcomplete++;
        return GetPoint();
    }
    public override string FileSystemString()
    {
        return $"{base.FileSystemString()}#{_totalcomplete}";
    }
    public override string ToString()
    {
        return $"{base.ToString()} Completions: {_totalcomplete}";
    }
}
