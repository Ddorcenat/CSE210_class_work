using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        // Class + "reference become the "variable name that we're going to use = class on constructor + constructor (Book, chapter, verse)
        Reference reference = new Reference("John", 3, 17);
        // use the object to call the methode to display the output. 
        Console.WriteLine(reference.GetScriptureReference());
    }
    
}