using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program

{
    static void Main(string[] args)
    {
        string option = "0";

        while (option != "4")
        {
            Console.Clear();
            Console.WriteLine("Today we are going to practice a couple activities together");
            Console.WriteLine(" 1 Start the breathing activity");
            Console.WriteLine(" 2 Start the listing activity");
            Console.WriteLine(" 3 Start the Refection activity");
            Console.WriteLine(" 4 Quit");
            option = Console.ReadLine();

            if (option == "1")

            {
                Breathing breath = new Breathing();
                breath.intro();
                breath.TimeActivity();
            }
            else if (option == "2")
            {
                Listing list = new Listing();
                list.intro();
                list.TimeActivity();
            }
            // The class doesn't have an intenses does. 
            else if (option == "3")
            {
                Reflection reflec = new Reflection();
                reflec.intro();
                reflec.TimeActivity();
            }

        }
    }
}