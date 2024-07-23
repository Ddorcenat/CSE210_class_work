using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
