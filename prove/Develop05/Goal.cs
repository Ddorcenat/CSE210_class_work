using System.Diagnostics.Contracts;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

class Goal
{
    string _name;
    string _description;
    int _numberOfPoints;
    bool _status;
    string _goalType;

    public Goal(string name, string desciption, int point, bool status, string goalType)
    {
        _name = name;
        _description = desciption;
        _numberOfPoints = point;
        _status = status;
        _goalType = goalType;
    }

    Goal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    public override string ToString()
    {
        string statusMarker = " ";
        if (_status)
        {
            statusMarker = "X";
        }
        return $"[{statusMarker}] {_name}: {_description}";
    }
    // public string GetName()
    // {

    // }
}