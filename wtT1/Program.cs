using System.Threading.Channels;

namespace wtT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            D d111 = F1;
            d111.Invoke();
            d111();
            Action d1 = new Action(F1);
            d1.Invoke();
            Func<int,int,int > a = Add;
            Console.WriteLine(a(2,3));
            Func<int> f2 = (() =>10);
            Action<int> a2 = (i => Console.Write(i));



        }

        static void F1()
        {
            Console.WriteLine("smd?");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }

    delegate void D();
}