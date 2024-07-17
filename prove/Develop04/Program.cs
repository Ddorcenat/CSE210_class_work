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
            Console.WriteLine("Hello Develop04 World!");
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
                breath.timeactivity();
            }
            else if (option == "2")
            {
                Listing list = new Listing();
                list.intro();
            }
            // The class doesn't have an intenses does. 
            else if (option == "3")
            {
                Reflecting reflec = new Reflecting();
                reflec.intro();
            }

        }
    }
}