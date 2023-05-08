namespace t2
{
    internal class Program
    {
        static Thread t3,t1;
        static void Main(string[] args)
        {
            t1 = new Thread(Thread1);
            t1.Start();
            t1.Name = "t1";
            t3 = new Thread(Thread1);
            t3.Start();
            t3.Name = "t3";
        }

        static void Thread1()
        {
            Console.WriteLine(Thread.CurrentThread.Name);
            if (Thread.CurrentThread.Name=="t1" && t3.ThreadState != ThreadState.Unstarted)
            {
                t3.Join();
            }

            Console.WriteLine("\n");
            Thread.Sleep(4000);
            Console.WriteLine(Thread.CurrentThread.Name);
            Console.WriteLine($"Thread:{Thread.CurrentThread.Name}");
            Console.WriteLine($"Thread1:{t1.ThreadState}");
            Console.WriteLine($"Thread3:{t3.ThreadState}");
          
        }
    }
}