using System;

namespace c6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.1546525;
            double y = x.Round(4);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
    static class DoubleEx
    {
       public static double Round(this double input,int digits)
        {
            double rs = Math.Round(input, digits);
            return rs;
        }
    }
}
