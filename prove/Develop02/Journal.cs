using System.ComponentModel;
using System.Dynamic;
using Microsoft.VisualBasic;


/// <summary>
/// This section will return the save imput of the user. 
/// </summary>
class Journal
{


    //lIst is a class in this contsxt
    private List<Entry> _entries = new List<Entry>();

    // this is call Array [] the purpose is
    private string[] _prompt = { "How was your day?", "Did you meet anyone interesting today?", "What did you like about your day?", "What did you eat today?" };
    public Journal()// constructor method 
    {

    }

    public string getRandomPrompt()
    {
        // making a new instance so we call the new method call next. 
        Random generator = new Random();
        //  Next is a method that return an interger, randomnum become a interger that we can use as an index. 
        int randomnum = generator.Next(0, _prompt.Length);

        return _prompt[randomnum];
    }

    // The lines below are methods 
    public void CreateEntry()
    {
        string prompt = getRandomPrompt();
        Console.WriteLine(prompt);

        string userinput = Console.ReadLine();
        Entry NewEntry = new Entry(prompt, userinput);
        _entries.Add(NewEntry);
    }
    public void DisplayEntry()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveEntries()
    {
        // string Journal = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter("Journal.txt"))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");

            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetSaveString());
            }
        }
    }
}
