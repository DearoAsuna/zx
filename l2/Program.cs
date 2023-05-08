using System;

namespace l2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomeCa(( a,b)=>a*b,1,2);
        }
        static void DoSomeCa<T>(Func<T, T, T> func, T x, T y)
        {
            var f1 = func(x, y);
            Console.WriteLine(f1);
        }
    }
    
}
