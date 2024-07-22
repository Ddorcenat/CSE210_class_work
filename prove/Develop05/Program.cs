using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int option = 0;
        Console.WriteLine("Welcom to the Eternal quest program");
        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine("Here the total point display");
            option = menu.DisplayMenu();
            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
            // Console.WriteLine(journalEntry.GetEntry());
        }
    }
}