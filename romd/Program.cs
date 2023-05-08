using System;

namespace romd
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = new Random();
            var next = r1.Next(0, 2);
            Console.WriteLine(next);
            if (next==1)
            {

                Console.WriteLine("xiaoji");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
