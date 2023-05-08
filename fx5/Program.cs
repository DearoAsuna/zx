using System;
    

namespace fx5
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> a1 = Say;
            a1.Invoke("Smd!");
            a1("Smd!");
            Action<int> a2 = Mui;
            a2(100);

        }

        static void Say(string str)
        {
            Console.WriteLine($"hello {str}");
        }

        static void Mui(int a)
        {
            Console.WriteLine(a*100);
        }
    }
   
}
