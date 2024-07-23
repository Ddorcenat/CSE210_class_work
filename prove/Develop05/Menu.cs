class Menu
{
    public int DisplayMenu()
    {
        int option = 0;
        while (option < 1 || option > 6)
        {
            Console.Write("");
            Console.Write("");
            Console.WriteLine("Menu Option: ");
            Console.Write("");
            Console.WriteLine("   1, Create New Goal");
            Console.WriteLine("   2, List Goals");
            Console.WriteLine("   3, Save Goals");
            Console.WriteLine("   4, Load Goals");
            Console.WriteLine("   5, Record Events");
            Console.WriteLine("   6, Quit");
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("You must enter a value between 1 and 6.");
            }
        }
        return option;
    }
    public int DisplayGoalMenu()
    {
        int choice = 0;
        while (choice < 1 || choice > 3)
        {
            Console.Write("");
            Console.Write("");
            Console.WriteLine("Goal Manu option: ");
            Console.Write("");
            Console.WriteLine("   1, Simple ");
            Console.WriteLine("   2, Check List");
            Console.WriteLine("   3, Eterna");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("You must enter a value between 1 and 3.");
            }
        }
        return choice;
    }
}