using System.Text;

namespace async3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            var sb = new StringBuilder();
            for (int i = 0; i < 1; i++)
            {
                sb.Append("XXXXXXXXXXXXXXXXXXXXX");
            }
            await File.WriteAllTextAsync(@"D:\test\1.text",sb.ToString());
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        }
    }
}