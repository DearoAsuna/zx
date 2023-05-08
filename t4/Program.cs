namespace t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Task<int> t1 = Task.Run((() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("smd");
                return 3;
            }));
            var result = t1.Result;
            Console.WriteLine(result);
            Console.WriteLine(t1.IsCompleted);*/


            /*
            var task = Task.Run((() =>
            {
                throw null;
            }));
            try
            {
                task.Wait();
            }
            catch (Exception e)
            {
                Console.WriteLine("Null");
                throw;
            }
            */
            /*var t1 = new TaskCompletionSource<int>();
            new Thread((() =>
            {
                Thread.Sleep(2000);
                t1.SetResult(42);
            }))
           .Start();
            var t1Task = t1.Task;
            Console.WriteLine(t1Task.Result);*/
            Task<int> prTask = Task.Run((() =>
            {
                int sum = 0;
                for (int i = 0; i < 10000; i++)
                {
                    sum += i;
                }

                return sum;
            }));
            var taskAwaiter = prTask.GetAwaiter();
            taskAwaiter.OnCompleted((() =>
            {
                var result = taskAwaiter.GetResult();
                Console.WriteLine(result);
            }));
            Console.Read();

        }
    }
}