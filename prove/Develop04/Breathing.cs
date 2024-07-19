using System.Diagnostics;

class Breathing : Activity
{
    public Breathing() : base("Breathing activity","Breathing desc"){}

    public void TimeActivity()
    {
        // DateTime endtime = DateTime.Now.AddSeconds(_time);
        // Console.WriteLine(endtime);
        // while(DateTime.Now.Second <= endtime.Second) This is aborted because a while is troublesome 
        double loopamount = Math.Round(_time/10); // Variable 
        for (int ab = 0; ab < loopamount; ab++) 
        {
            // Console.WriteLine(DateTime.Now.Second);
            // Console.WriteLine(endtime.Second);
            // Thread.Sleep(1000);
            Console.WriteLine();
            Console.Write("start Breathin ....... ");
            for(int a = 4; a > 0; a--)
            {
                Console.Write(a);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
            Console.WriteLine();
            Console.Write("Now Breathout ...... ");
            for(int a = 6; a > 0; a--)
            {
                Console.Write(a);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
        }
        Console.WriteLine("Congratulation you've completed the breathing activity");
        Thread.Sleep(5000);
    }
}