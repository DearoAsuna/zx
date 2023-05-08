using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wt
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele<int> deleAdd = new MyDele<int>(Add);
            int res = deleAdd(100, 200);
            Console.WriteLine(res);
            var myDele = new MyDele<double>(Mul);
            var dele = myDele(0.5, 2.3);
            Console.WriteLine(dele);
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Mul(double x, double y)
        {
            return x * y;
        }
    }

    delegate T MyDele<T>(T x, T y);

}
