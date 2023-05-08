using System.Runtime.CompilerServices;

namespace dxc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread((() =>
            {
                DosomeThings("smd");
            }));
            t1.Start();
        }

        public static void DosomeThings(string a1)
        {
            Console.WriteLine(a1);
        }
    }
}