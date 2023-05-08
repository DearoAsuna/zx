using System.Threading.Channels;

namespace lamada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Func<int> a =(() =>
            {
                return 1;
            });
            Console.WriteLine(a());
            Action a1 = (() =>
            {
                Console.WriteLine(111);
            });
            a1();
            Action a2 = delegate()
            {
                Console.WriteLine("smd?");
            };
            a2.Invoke();
            Action<int, string> f1 = delegate(int a, string b) { Console.WriteLine(a + b); };
            f1(18, "smd?");
            Func<int, string, string> f2 = (s, i) => s + i ;
            Console.WriteLine(f2(18,"smd?"));
            Func<int,int,int> f3=(a,b) => a + b;
            Console.WriteLine(f3(1,3));
            Action a111 = () =>  Console.WriteLine("1111");
            a111();
            Action<int, int> s1 = (i, i1) => Console.WriteLine(i + i1);
            s1(1,2);
            Func<int,int,int> f2123= (a,b) => a + b;
            Console.WriteLine(f2123(1,2));
            Action<int> a11111 = i => Console.WriteLine(i);
            a11111(12312312);*/
            Func<int, bool> f1 = i => i > 6;
            Console.WriteLine(f1(2));
            Func<int, bool> f2 = delegate(int i1)
            {
                return i1 > 6;
            };
            Func<int, bool> f3 
                = (int i1) =>  i1 > 6;

            Action<string> a1 = delegate(string s)
                { Console.WriteLine(s); };
            Func<int, bool> f4 = delegate(int i)
            {
                return i > 5;
            };

        }
    }
}