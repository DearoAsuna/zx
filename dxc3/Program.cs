using System.Runtime.CompilerServices;

namespace dxc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action a1 = (() =>
            {
                Console.WriteLine("smd?");
            });
            Action a2 = (() =>
            {
                Console.WriteLine("mym?");
            });
            Call(a1,a2);
        }

        private static void Call(Action a1, Action a2)
        {
            var t1 = new Thread((() =>
            {
                a1.Invoke();
                a2.Invoke();
            }));
            t1.Start();
        }
    }
}