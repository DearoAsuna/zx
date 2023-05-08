using System;

namespace l1
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = new Func<int, int, int>((i, i1) => i + i1);
            var f2 = f1(1, 2);
            Console.WriteLine(f2);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
