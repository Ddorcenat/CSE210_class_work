
class Simple : Goal
// public int _simpleGoal
{
    public Simple() : base()
    {

    }

    public Simple(string name, string description, int numberOfPoints, bool status): base(name, description, numberOfPoints, status)
    {

    }
    public override void RunGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
    }
    public override int RecordEvent()
    {
        return MarkComplete();
    }
}
