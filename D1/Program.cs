using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            c c = new c();
            
            c.run();
        }
        
    }
    class p
    {
        private int smd1;

        public int Smd1
        {
            get { return smd1; }
            set { smd1 = value; }
        }

        public  void run()
        {
            Console.WriteLine("smd1 run");
        }
    }
    class c:p
    {
        public void run()
        {
            Console.WriteLine("smd2 run");
            Console.WriteLine();
         
        }
    }
    
}
