namespace 异步不等于多线程
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Threadid   "+Thread.CurrentThread.ManagedThreadId);
            /*var c1 = await CalcAsync(100);
            Console.WriteLine(c1);*/
            double i1=0;
            var r2 = new Task<double>((() =>
            {
                var r1 = new Random();
                for (int i = 0; i < 1000; i++)
                {
                    var r2 = r1.NextDouble();
                    i1 += r2;
                }
                Console.WriteLine("Threadid11    " + Thread.CurrentThread.ManagedThreadId);
                return i1;
            }));
            r2.Start();
            r2.Wait();
            Console.WriteLine(i1);
            Console.WriteLine("Threadid22   " + Thread.CurrentThread.ManagedThreadId);
        }

        /*public static async Task<double> CalcAsync(int n)
        {
            Console.WriteLine("CalcAsync"+Thread.CurrentThread.ManagedThreadId);
            double result = 0;
            var r1 = new Random();
            for (int i = 0; i < n*n; i++)
            {
                var d1 = r1.NextDouble();
                result += d1;
            }

            return result;
        }*/
    }
}