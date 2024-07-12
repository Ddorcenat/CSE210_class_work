using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the your journal report program!");
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"{firstName} make your selcection form the list below ");

        Journal journalEntry = new Journal();
        while (true)
        {
            Console.WriteLine("1, Wrtite an Entry");
            Console.WriteLine("2, Dipslay the Journal");
            Console.WriteLine("3, Load the journal from a file");
            Console.WriteLine("4, Save the journal to a file");
            Console.WriteLine("5, Exit the program");
            Console.WriteLine($"{firstName} select one the option above.");
            string option = Console.ReadLine();

            if (option == "1")
            {
                journalEntry.CreateEntry();
            }
            else if (option == "2")
            {
                journalEntry.DisplayEntry();
            }
            // The class doesn't have an intenses does. 
            else if (option == "4")
            {
                journalEntry.SaveEntries();
            }
            // Console.WriteLine(journalEntry.GetEntry());
        }
    }
}