using System;

class Menu
{
    public int DisplayMenu()
{ 
    int response = 0;

    while(response < 1 || response > 4)

    {
        Console.Clear();
        Console.WriteLine("Menu Option");
        Console.WriteLine(" 1, Start Breathing Activity");
        Console.WriteLine(" 2, start Reflecting Activity");
        Console.WriteLine(" 3, Start Listing Activity");
        Console.WriteLine(" 4, Quit");
    }

    try
    {
        response = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine(" ");
    }
}
}