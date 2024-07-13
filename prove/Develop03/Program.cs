using System;

class Program
{
    static void Main(string[] args)
    {
        // Class + "reference become the "variable name that we're going to use = class on constructor + constructor (Book, chapter, verse)
        Scripture scripture = new Scripture("John", 3, 17, "For God sent not his Son int the world to condemn the world; but that the world through him might be saved.");
        // use the object to call the methode to display the output. 
        
        Console.Clear();
        Console.WriteLine("Welcome to the scripture memorization program");
        Console.WriteLine("Press enter to start");
        scripture.ShowScripture();
        Console.ReadLine();


        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.HideWords();
            scripture.ShowScripture();
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
        }
    }

}