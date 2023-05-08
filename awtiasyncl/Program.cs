using System.Text;

namespace awtiasyncl
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*
            string filename = @"D:\test\1.text";
            File.WriteAllText(filename,"Smd");
            var r1 = File.ReadAllText(filename);
            Console.WriteLine(r1);
            */
            string filename = @"D:\test\1.text";
            var sb = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                sb.AppendLine("Hello");
            }
            await File.WriteAllTextAsync(filename,sb.ToString());
            string r1 = await File.ReadAllTextAsync(filename);
            Console.WriteLine(r1);
        }
    }
}