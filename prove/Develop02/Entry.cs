using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Entry
{
    // They are all variables ( string is a tyoe of variable and datetime is another type for the vairable)
    // string _title;
    string _prompt;
    string _userinput;
    DateTime _date;

    // This is a constructor that conatin an (parameters) 
    public Entry(string promt, string userinput)
    {
        // set the value of member variable 
        // _title = title;
        _prompt = promt;
        _userinput = userinput;
        _date = DateTime.Now;
    }

    // this a methid
    public void DisplayEntry()
    {
        Console.WriteLine($"{_prompt}, {_userinput} {_date}");
    }
    public string GetSaveString()
    {
        return $"{_prompt}|{_userinput}|{_date}";
    }
}
