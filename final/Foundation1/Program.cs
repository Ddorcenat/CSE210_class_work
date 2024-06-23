using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the your journal report program!");
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine(); 
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"{firstName} make your selcection form the list below ");

        Console.WriteLine("1, Wrtite a new entry");
        Console.WriteLine("2, Dipslay the Journal ");
        Console.WriteLine("Save the journal to a file");
        Console.WriteLine("4, Load the journal from a file");
        Console.WriteLine("5, Exit the program");
        Console.Write($"{firstName} select one teh option above: ");
        string option = Console.ReadLine();

        int response = 0;
        do
        {
        Display menu
        respond = int.Parse(Console.ReadLine);
            if (response = 1)
            
        }
    }

}