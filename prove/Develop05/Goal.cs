using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

abstract class Goal
{
    string _name;
    string _description;
    int _numberOfPoints;
    bool _status; 
    string _goalType;

    public Goal(string name, string desciption, int point, bool status)
    {
        _name = name;
        _description = desciption;
        _numberOfPoints = point;
        _status = status;
        _goalType = base.ToString();
    }

    public Goal()
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
        return $"[{statusMarker}] {_goalType} {_name}: {_description}";
    }
    public void SetName()
    {
        Console.WriteLine("What is the name of your goal? "); // Methods for the programs 
        _name = Console.ReadLine();
    }
    public void SetDescription()
    {
        Console.WriteLine($"What is your short description for {_name}? ");
        _description = Console.ReadLine();
    }
    public void SetPoints()
    {
        Console.WriteLine($"How much you do you wich to set for {_name}? ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }
    public int GetPoint()
    {
        return _numberOfPoints; 
    }
    public int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }
    public abstract int RecordEvent();
    public abstract void RunGoal();


    // public string GetName()
    // {

    // }
}