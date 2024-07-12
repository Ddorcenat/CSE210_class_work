using System.Diagnostics;

class Prep 
{
    public Prep(string[] args)
    {

        string response = "yes";
        while (response == "yes")
        {
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }
    }
}