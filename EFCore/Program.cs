namespace EFCore
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var md= new MyDBcontext())
            {
                #region add
                /*

                              var book = new Book();
                              book.AuthorName = "smd1";
                              book.Title = "c++";
                              book.Price = 5;
                              book.PubTime=DateTime.Now;
                              md.Books.Add(book);
                              var book1 = new Book();
                              book1.AuthorName = "smd";
                              book1.Title = "java";
                              book1.Price = 51;
                              book1.PubTime = new DateTime(2000,1,1);
                              md.Books.Add(book1);
                              var book2 = new Book();
                              book2.AuthorName = "smd2";
                              book2.Title = "Csharp";
                              book2.Price = 158;
                              book2.PubTime = new DateTime(2201, 2, 1);
                              md.Books.Add(book2);
                              await md.SaveChangesAsync();*/
                #endregion
                #region select

                /*
                var books = md.Books.
                    OrderBy(a => a.Price ).Where(a=>a.Price>20);
                foreach (var i in books)
                {
                    Console.WriteLine(i.ToString());
                }

                var single = md.Books.Single(a => a.Title == "java");
                Console.WriteLine(single.ToString());*/
                /*var select = md.Books.GroupBy(a => a.AuthorName).Select(g => new
                {
                    name = g.Key,
                    cout = g.Count(),
                    Sum = g.Sum(a => a.Price)
                });
                foreach (var i in select)
                {
                    Console.WriteLine($"{i.name}  {i.cout}");
                }
                */

                #endregion
                #region Updata and delete

                /*var single = md.Books.SingleOrDefault(a => a.AuthorName == "yxy");
                single.AuthorName = "yxy";
               

                 var single1 = md.Books.Single(a => a.AuthorName == "smd1");
                 md.Remove(single1);
                 
                 await md.SaveChangesAsync();*/
                #endregion
                #region hua huo

                /*var queryable = md.Books.Where(a => a.Price > 20);
                foreach (var book in queryable)
                {
                    book.Price += 1;
                }

                await md.SaveChangesAsync();*/

                #endregion
                #region id返回值

                /*
                var Cat = new Cat();
                Cat.Name = "mym1";
                Cat.Age1 = 88;
                Console.WriteLine(Cat.Id);
                md.Cat.Add(Cat);
                await md.SaveChangesAsync();
                Console.WriteLine(Cat.Id);
                */


                #endregion

                #region Guild 自增

                var rabbit = new Rabbit();
                rabbit.Name = "smd";
                md.Rabbit.Add(rabbit);
                await md.SaveChangesAsync();

                #endregion
            }
        }
    }
}