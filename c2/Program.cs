using System;
using System.Windows.Forms;
namespace c2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*   st st = new st();
               st.age = 10000;
               mk wk = st;
               Console.WriteLine(wk.age);
               int x = 100;
               string str = (x >= 60) ? "pass" : "No";
               Console.WriteLine(str);
               Console.ReadKey();*/
            int? x = null;
            var y = x ?? 100;
            int a2 = 5 > 3 ? 20 : 50;
            var z = 5 >2 ? 2.0 : 30;
            int[] A1 = { 1, 2, 3, 4 };
            
            Console.WriteLine(y);
            Console.ReadKey();
            Level high = Level.high;
           
            /*
            switch (Level)
            {
                case Level.high:
                    break;
                case Level.mid:
                    break;
                case Level.low:
                    break;
                default:
                    break;
            }*/
        }
        enum Level
        {
            high=2,
            mid=1,low=3
        }
        class mk
        {
            public int age;
            public static implicit operator mk(st st)
            {
                mk mk = new mk();
                mk.age = st.age / 100;
                return mk;
            }
        }
        class st
        {
            public int age;
        }
    }
 
 
}
