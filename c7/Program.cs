using System;

namespace c7
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Action a1 = new Action(c1.Report);
            a1.Invoke();   
            Func<int, int, int> func1 = new Func<int, int, int>(c1.Add);
            int z = func1(2, 3);
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("There have 3 methods");
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
    }
}
