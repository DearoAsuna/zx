using System;
using System.Runtime.InteropServices;


namespace fx6
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> fun1 = (double a, double b) => { return a + b;};
            var r = fun1(1.1, 1.2);
            var smd1 = new smd1();
            Console.WriteLine(smd1.S);
        }

    }

    partial class  smd1
    {
        public string S { get; set; }
    }
    partial class smd1
    {
        public void w()
        {
            Console.WriteLine(S);
        }
    }
}
