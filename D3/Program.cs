using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IA
    {
        void Run();
        void Stop();
        void Fill();
    }
    abstract class A : IA
    {
        public void Fill()
        {
            Console.WriteLine("Filling");
        }

        abstract public void Run();
    
        public void Stop()
        {
            Console.WriteLine("Stoping");
        }
    }

    class Car:A
    {
        public override void Run()
        {
            throw new NotImplementedException();
        }
    }


}
