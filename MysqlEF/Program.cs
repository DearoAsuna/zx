using Microsoft.EntityFrameworkCore;

namespace MysqlEF
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region 无并发

            /*Console.WriteLine("Your Name");
        using (var i =new MyDbContext())
        {
            var first = i.House.First(a=>a.Id==1);
            if (!string.IsNullOrEmpty(first.Owner))
            {
                Console.WriteLine($"By {first.Owner}");
            }
        }*/

            #endregion

            #region 有并发

            Console.WriteLine("Your Name");
            var readLine = Console.ReadLine();
            using (var i=new MyDbContext())
            using (var ct=i.Database.BeginTransaction() )
            {
                Console.WriteLine(DateTime.Now);
                var single = i.House.FromSql
                        ($"select * from T_House where Id=1 for update")
                        .Single();

                Console.WriteLine(DateTime.Now);
                if (string.IsNullOrEmpty(single.Owner))
                {
                    single.Owner = readLine;
                    Thread.Sleep(5000);
                    i.SaveChanges();
                    ct.Commit();
                    Console.WriteLine("gxgx");
                }
                else
                {
                    Console.WriteLine("error");
                }

                Console.ReadLine();
            }
            


            #endregion
        }
    }
}