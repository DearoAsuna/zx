namespace task4
{
    internal class Program
    {
        private readonly static object obj_Lock = new object();
        static void Main(string[] args)
        {
           var titlist=new List<int>();
           var tasks = new List<Task>();
           int i1= 0;
           for (int i = 0; i < 50; i++)
           {
               i1 += i;
               Task.Run((() =>
               {
                   titlist.Add(i);
               }));
           }

           Console.ReadKey();
           foreach (var i in titlist)
           {
               Console.WriteLine(i);
           }
           Console.WriteLine(titlist.Count+"      "+i1);
        }
    }
}