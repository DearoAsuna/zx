using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IVeh
    {
        void Fill();
        void Run();
        void Stop();

    }

    abstract class A1 : IVeh
    {
        public void Fill()
        {
            Console.WriteLine("Pay");
        }

        abstract public void Run();
    
        public void Stop()
        {
            Console.WriteLine("Stoping");
        }
    }
    class Car:A1
    {
        public override void Run()
        {
            Console.WriteLine("Car is running...");
        }
    }
}
