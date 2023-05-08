namespace wt_as
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(async (obj) =>
            {
                while (true)
                {
                    await File.WriteAllTextAsync($@"D:\test\1.text",
                        "smd?");
                    Console.WriteLine("smd?");
                }
            });
            Console.Read();
        }
    }
}