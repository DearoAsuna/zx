namespace t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            bool a = false;
            ThreadStart a1 = () =>
            {
                if (!a)
                {
                    a = true;
                    Console.WriteLine(1);
                }
            };
            new Thread(a1).Start();
            a1();
            */
            var t1 = new Thread((() => Print("smd?")));
            t1.Start();
            for (int i = 0; i < 10; i++)
            {
               var t2 = i;
                new Thread((() => Console.Write(t2))).Start();
            }
        }
        static void Print(string s) {
            Console.WriteLine(s);
        }
    }
}