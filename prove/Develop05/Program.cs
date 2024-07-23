using System;
using System.Diagnostics.Contracts;
using System.Formats.Asn1;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();
        int option = 0;
        Console.WriteLine("Welcom to the Eternal quest program");
        while (option != 6)
        {
            Console.Clear();
            goals.DisplayScore();
            option = menu.DisplayMenu();
            switch (option)
            {
                case 1:
                    // Goal goal = new Goal("Christ", "come follow me", 100, false);
                    // goals.AddGoal(goal);
                    // Console.WriteLine(goal.ToString());
                    // Console.ReadLine();
                    Simple simple = new Simple();
                    simple.RunGoal();
                    goals.AddGoal(simple);
                    break;
                case 2:
                    goals.DisplayGoals();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    goals.RecordEvent();
                    break;
                case 6:
                    break;
            }
            // Console.WriteLine(journalEntry.GetEntry());
        }
    }
}