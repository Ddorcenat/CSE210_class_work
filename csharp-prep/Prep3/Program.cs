using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the game guess the number.");
        Console.WriteLine("What is the magical number? ");
        string answer = Console.ReadLine();
        
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i); 
    }

    string response = "yes";

    while (response == "yes")
    {
        Console.WriteLine(" Do you want to continue?");
        response = Console.ReadLine();
    }
    }
}
