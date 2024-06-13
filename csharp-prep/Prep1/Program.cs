 using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome to the introductoryy assignment?");
        Console.Write("what is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your Lant name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is:{lastName}, {firstName} {lastName}");
        string copy = $"Your name is:{lastName}, {firstName} {lastName}";
        Console.WriteLine(copy);
    }
}