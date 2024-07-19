using System.Security.Cryptography;
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
    private string[] _questionprompt =
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
        Console.WriteLine($"--- {_promtps[random]} ---");
        // prompts in this case is an Variable type Array or just an Array, meanwhile Random is teh index that represent the prompt that's going to be display.
    }
    private void RandomQuest()
    {
        Random randomquestgenerator = new Random();
        int random = randomquestgenerator.Next(0, _questionprompt.Length);
        Console.WriteLine($"-- {_questionprompt[random]} --");
    }
    public void TimeActivity()
    {
        
        Console.Write("Welcome to the reflection Activity");
        Console.Write("");
        Console.WriteLine(@" This activity will help you reflect on times in your life when you have shown strength and resilience. 
        This will help you recognize the power you have and how you can use it in other aspects of your life. ");
        RandomPrompt();
        Console.WriteLine(" Pressenter once you you're ready to write");
        Console.ReadLine();

        DateTime endtime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endtime)
        {
            RandomQuest();
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
            }

            // DateTime endtime = DateTime.Now.AddSeconds(_time);
            // Console.WriteLine(endtime);
            
            
                Console.WriteLine("> ");
                Console.ReadLine();

            
            // Thread.Sleep(2000);
        }
    }

}