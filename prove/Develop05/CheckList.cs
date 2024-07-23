
using System.ComponentModel.DataAnnotations.Schema;

class CheckList: Goal
// public int _simpleGoal
{
    private int _totalcomplete;
    private int _maxattemps;
    private int _bonuspoints;
    public CheckList() : base()
    {
        _totalcomplete = 0;
        _maxattemps = 0;
        _bonuspoints = 0;
    }

    public CheckList(string name, string description, int numberOfPoints, bool status, int complete, int maxattemps, int bonuspoints): base(name, description, numberOfPoints, status)
    {
        _totalcomplete = complete;
        _maxattemps = maxattemps;
        _bonuspoints = bonuspoints;
    }
    public override void RunGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        Console.Write("How many times does this goal needs to accomplish: ");
        _maxattemps = int.Parse(Console.ReadLine());
        Console.Write(" How many points will you reward achieving this goal: "); 
        _bonuspoints = int.Parse(Console.ReadLine());
    }
    public override int RecordEvent()
    {
        _totalcomplete++;
        int bonuspoints = 0; 
        if (_totalcomplete == _maxattemps)
        {
            MarkComplete();
            bonuspoints = _bonuspoints;
        }
        return GetPoint() +bonuspoints;
    }
    public override string FileSystemString()
    {
        return $"{base.FileSystemString()}#{_totalcomplete}#{_maxattemps}#{_bonuspoints}";
    }
    public override string ToString()
    {
        return $"{base.ToString()} Completions: {_totalcomplete}/{_maxattemps}";
    }
}
