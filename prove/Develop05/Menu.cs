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
}