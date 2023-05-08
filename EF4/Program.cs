using Microsoft.EntityFrameworkCore;

namespace EF4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region add

            /*using (var i = new MyDbcontext())
            {
                var book = new Book()
                {
                    name = "司马刁奇遇记2",
                    description = "记录着smd大冒险2,故事更精彩",
                    price = 666,
                };
                var remark = new Remark()
                {
                    Name = "菜狗",
                    Msg = "什么依托答辩plus"
                };
                var remark1 = new Remark()
                {
                    Name = "羊狗",
                    Msg = "这玩意还能出续集？"

                };
                book.remarks.Add(remark);
                book.remarks.Add(remark1);
                i.Books.Add(book);
                var async = await i.SaveChangesAsync();
                Console.WriteLine(async);

               

            }*/
            #endregion

            #region select

            using (var i=new MyDbcontext())
            {
                var book = i.Books.Include(a=>a.remarks)
                    .SingleOrDefault(a => a.id == 1);
                Console.WriteLine(book.name);
                foreach (var i1 in book.remarks)
                {
                    Console.WriteLine(i1.Name+"   "+i1.Msg);
                }
            }

            #endregion
        }
    }
}