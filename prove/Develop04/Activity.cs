using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

class Activity
{
    protected string _title;
    protected string _desc;
    protected int _time;
    string[] _spinner = { "|", "\\", "-", "/" };

    public Activity(string title, string descrip)
    {
        _title = title;
        _desc = descrip;
    }

    public void intro()
    {
        Console.WriteLine($"{_title} : {_desc}");
        Console.WriteLine("How long do you want to do the activity?");
        _time = Int32.Parse(Console.ReadLine()); //To store the infromation as number 
        Console.Write("Get ready....");
        spinner(); // "()" indicate that we are callong a method
    }
    public void spinner()
    {
        for (int i = 0; i < 3; i++)
        {

            foreach (string str in _spinner) // All logic block are opened with a curly bracease 
            {
                Console.Write($"{str}"); // This is reffering to a format string $
                Thread.Sleep(400);//This is allowing the string to remain
                Console.Write("\b"); // this is here to allow teh str to dsiappear
            }
        }
    }
}