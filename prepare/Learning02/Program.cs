using System;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // This set of code allow the user to gather current the date.
        DateTime thecurrentTime = DateTime.Now;
        string datetext = thecurrentTime.ToShortDateString();

        // -Console.WriteLine("Hello Learning02 World!");
        // -Console.WriteLine("This is to learn all the code required for my assignemt");
        // This allow me to print or promt the user for information. In addition I can provide direction to the user.
        // Additional information when using WriteLine the user input will be display in the next line. While 
        Console.WriteLine("What is today's day?");
        // This section retain information from the user input. 
        string day = Console.ReadLine();
        Console.WriteLine($"Today is {day}");
    

        // -int number = 2;
        // -number = number + 6; 
        
        // -Console.WriteLine($" The total is of 2 + 6 is {number}");

        // -Console.WriteLine("What is your first name?");
        // -string firstname = Console.ReadLine();
        // -Console.WriteLine("What is your last name?");
        // -string lastname = Console.ReadLine();

        // -Console.WriteLine($"{datetext} Your full name is {firstname}{lastname}");

        // - second Program -
        
        Console.Write("Enter a number: ");
        // Thsi sectin allow me to enquire number from the user but I won't be able to use this numebr unytil I converted.
        string numberFromUser = Console.ReadLine();

        int x = int.Parse(numberFromUser);
        int y = 5;
        int z = 2;

        // This || = or, while && = and. 
        if (x > y || x > z)
        {
            Console.WriteLine("Greater");
        }
        else if (x < y)
        {
            Console.WriteLine("Less");
        }
        else 
        {
            Console.WriteLine(" Equal");
        }

    }
}