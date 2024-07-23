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
                    int goalChoice = menu.DisplayGoalMenu();
                    if (goalChoice == 1)
                    {
                        Simple simple = new Simple();
                        simple.RunGoal();
                        goals.AddGoal(simple);
                    }
                    else if(goalChoice == 2)
                    {
                        CheckList checkList = new CheckList();
                        checkList.RunGoal();
                        goals.AddGoal(checkList);
                    }
                    else if (goalChoice == 3)
                    {
                        Eternal eternal = new Eternal();
                        eternal.RunGoal();
                        goals.AddGoal(eternal);
                    }
                    break;
                case 2:
                    goals.DisplayGoals();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    break;
                case 3:
                    goals.SaveGoal();

                    break;
                case 4:
                    goals.LoadGoals();
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