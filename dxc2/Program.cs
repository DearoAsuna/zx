namespace dxc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Thread((() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.Write("1");
                }
            }));
            t1.Priority=ThreadPriority.Highest;
            var t2 = new Thread((() =>
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.Write("2");
                }
            }));
            t2.Priority=ThreadPriority.Lowest;
            t2.Start();
            t1.Start();
        }
    }
}