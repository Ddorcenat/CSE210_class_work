using System.Diagnostics;

class Breathing : Activity
{
    public Breathing() : base("Breathing activity","Breathing desc"){}

    public void timeactivity()
    {
        DateTime endtime =  DateTime.Now.AddSeconds(_time);
        Console.WriteLine(endtime);
        while(DateTime.Now.Second != endtime.Second)
        {
            // Console.WriteLine(DateTime.Now.Second);
            // Console.WriteLine(endtime.Second);
            // Thread.Sleep(1000);

            Console.WriteLine("start Breathin ");
            for(int a = 4; a > 0; a--)
            {
                Console.Write(a);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
            Console.WriteLine("start Breathout ");
            for(int a = 4; a > 0; a--)
            {
                Console.Write(a);
                Thread.Sleep(1000);
                Console.Write("\b");
            }
        }
    }
}