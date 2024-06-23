using System;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the game guess the number.");

        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 10);

            int guess = -1;

            while (guess != magicNumber)
            {
                Console.WriteLine("What is the magical number? ");
                guess = int.Parse(Console.ReadLine());
                
                if (guess > magicNumber)
                {
                    Console.WriteLine("Your should guess a lower number");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("You should guess a higher number");
                }
                else
                {
                    Console.WriteLine("Congratulation your guess was rigth!");
                }
            }
            Console.WriteLine(" Do you want to continue?");
            response = Console.ReadLine();
        }
    }
}
