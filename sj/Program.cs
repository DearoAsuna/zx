using System;
using System.Timers;

namespace sj
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer t1 = new Timer();
            t1.Interval = 100;
            Boy b1= new Boy();
            Girl g1 = new Girl();
            t1.Elapsed += b1.Action;
            t1.Elapsed += g1.Action;
            t1.Start();
            Console.ReadKey();
        }
    }
    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }
    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
