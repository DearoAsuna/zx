using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wt2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Action(Say);
            a1();
            var a2 = new Action<string>(Say1);
            a2("smd");
            var f1 = new Func<int,int,int>(Add);
            var i = f1(1, 2);
            Console.WriteLine(i);

        }
        static int Add(int x,int y)
        {
        return x + y;
        }

        static void Say()
        {
        Console.WriteLine("Hello smd");
        }

        static void Say1(string a1)
        {
            Console.WriteLine($"Hello {a1}");
        }
    }
    
}
