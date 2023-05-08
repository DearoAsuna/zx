using System;


namespace a1
{
    public delegate int Calc(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c1 = new Calculator();
            Calc ca1 = new Calc(c1.Add);
            Calc ca2 = new Calc(c1.Sub);

            var a1 = ca1(1, 2);
            Console.WriteLine(a1);
            Console.ReadKey();

        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    
    }
}
