using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Simple : Goal
// public int _simpleGoal
{
    public Simple() : base()
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
