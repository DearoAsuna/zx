namespace t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(Go);
            t.Start();
            Console.WriteLine("end");
        }

        static void Go()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("y");
            }
        }
    }
}