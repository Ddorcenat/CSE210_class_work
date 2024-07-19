using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Listing : Activity
{
    private string[] _promtps = 
    // This is a variable, Where private is reffering to thelocation of the file, while string reffers to information inside the variable. Prompt is the title and teh ALias. 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "What have been an event that impacted your life",
        "What habbit hhave yo built that's currently challenge"
    };
    public Listing() : base("Listing activity", "Listing desc") { }
    private void RandomPrompt()
    {
            Random randomgenerator = new Random(); 
            int random = randomgenerator.Next(0, _promtps.Length); // Veriable first letter should be in lowercase.
            // Since the next method is expectiong an "int" AKA interger, I can not use _promt because it's an array but when I add .lenght it become and interger
            Console.WriteLine(_promtps[random]);
            // prompts in this case is an Variable type Array or just an Array, meanwhile Random is teh index that represent the prompt that's going to be display.
    }

    public void TimeActivity() 
    {
        int totalanswers = 0;

        Console.WriteLine(" List as many response you cna to the following prompt. ");
        RandomPrompt();
        Console.WriteLine(" You acan start after .....");
        
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); 
            Console.Write("\b");
        }

        DateTime endtime = DateTime.Now.AddSeconds(_time);
        // Console.WriteLine(endtime);
        while(DateTime.Now <= endtime)
        {
            Console.WriteLine("> ");
            Console.ReadLine();
            
            totalanswers+= 1; // or could be totalanswers++; 
            
        }
        Console.WriteLine($"You answered {totalanswers} times");
        Thread.Sleep(2000);
        
    }

}