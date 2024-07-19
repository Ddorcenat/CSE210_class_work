using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

class Reflection : Activity
{
    private string[] _promtps = 
    // This is a variable, Where private is reffering to thelocation of the file, while string reffers to information inside the variable. Prompt is the title and teh ALias. 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private string[] _questionprompt= 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    public Reflection() : base("Reflecting activity", "Reflecting desc") { }
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