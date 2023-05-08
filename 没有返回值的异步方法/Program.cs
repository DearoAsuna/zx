using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace 没有返回值的异步方法
{
    internal class Program
    {
        static async Task  Main(string[] args)
        {  Console.WriteLine(Thread.CurrentThread.ManagedThreadId+ "   1");
            var read =await Readasync(1);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + "   3");
            Console.WriteLine(read);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId+"   3");
          

           
        }

        static async Task<string> Readasync(int number)
        {
            
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId+"    2");
            var sb =new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                sb.AppendLine("xxxxxxxxxxx");
            }

           await File.WriteAllTextAsync(@"D:\test\1.txt", sb.ToString());
            if (number==0)
            {
                Exception e;
            }
            
            if (number==1)
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId+"   4");
                return await File.ReadAllTextAsync(@"D:\test\1.txt");
             
            }
            else
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                return await File.ReadAllTextAsync(@"D:\test\2.txt");
            }
        }
    }
}