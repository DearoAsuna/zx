using System.Diagnostics;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Run((() =>
            {
                try
                {
                    var i = 0;
                    var y = 10;
                    // ReSharper disable once IntDivisionByZero
                    var c = y / i;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }));
            Task.WaitAll(task);




        }
    }
}