namespace task3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var t1 = Task.Run((() =>
            {
                return "smd?";
            }));
            Console.WriteLine(t1.Result);
            var t2 =await Task.Run((() =>
            {
                return "smd?";
            }));
            Console.WriteLine(t2);
        }
    }
}