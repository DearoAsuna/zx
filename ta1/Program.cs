namespace ta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = new Task((() =>
            {
                Console.WriteLine("mym?");
            }));
            task.Start();

            Task.Run(() =>
            {
                Console.WriteLine("smd?"+DateTime.Now);
            });
            Thread.Sleep(500);
            var t1 = Task.Run<DateTime>(() =>
            {
                return DateTime.Now;
            });
            var t2 = t1.Result;
            t1.Wait();
            Console.WriteLine(t2);
        }
    }
}