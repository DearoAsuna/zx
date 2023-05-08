using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace EF3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            #region 分页

            /*Pages(3);
           Console.WriteLine("输入第多少页");
           var line = int.Parse(Console.ReadLine() ?? string.Empty);
           PrintPage(5, 3);*/

            #endregion
            #region 原生sql

            /*
           * using (var i=new MyDbcontext())

          {

              await i.Database.ExecuteSqlInterpolatedAsync
              ($@"insert into T_Article(title,Message)select title,
                  '666' from T_Article  where id>110");#1#
             string title = "%s%";
             var articles = i.Articles.FromSqlInterpolated
             ($@"select * from T_Article where Title 
                  like {title}");
              /*var articles = 
                  i.Articles.Where(a => a.Message.Contains("smd"));#1#
              var queryable = articles.GroupBy(a => a.title)
                  .Select(a => new
                  {
                      title = a.Key
                  });
              foreach (var i1 in queryable)
              {
                  Console.WriteLine(i1.title);
              }


              await i.SaveChangesAsync();
          }*/

            #endregion
            #region add
            /*
             
            using (var d = new MyDbcontext())
           {
               var article = new Article();
               article.title = "smd";
               article.Message = "smd slm";

               var commnet = new Commnet
               {
                   Message = "smd zhen gaisi"
               };
               var commnet1 = new Commnet
               {
                   Message = "si dei hao!"
               };

               article.Commnets.Add(commnet);
               article.Commnets.Add(commnet1);

               d.Articles.Add(article);
               var i = await d.SaveChangesAsync();
               Console.WriteLine(i);
           }*/
            /*await AddA(20);*/


            /*
            using (var d=new MyDbcontext())
            {
                var user = new User()
                {
                    Name = "smd",
                };
                var user1 = new User()
                {
                    Name = "cg",
                };
                var leave = new Leave()
                {
                    Remarks = "jlsrl",
                    Approver = user,
                    Requseter = user1
                };
                var entityEntry = d.Leaves.Add(leave);
                await d.SaveChangesAsync();
            }*/

            #endregion
            #region select

            /*using (var d= new MyDbcontext())
           {
               var article = d.Articles.Include
                   (a=>a.Commnets).SingleOrDefault(a => a.id == 2);
               Console.WriteLine();
               Console.WriteLine(article.ToString());
               foreach (var i in article.Commnets)
               {
                   Console.WriteLine();
                   Console.WriteLine(i.ToString());
               }

               var commnet = d.Commnets.Include(a=>a.Article)
                   .SingleOrDefault(a => a.id == 1);
               /*var commnet = d.Commnets
                   .SingleOrDefault(a => a.id == 1);#1#
               Console.WriteLine(commnet.Article.Message);
           }*/
            /*using (var d = new MyDbcontext())
            {
                var article = d.Articles.
                    Include(a => a.Commnets).First();
                foreach (var i in article.Commnets)
                {
                    Console.WriteLine(i.Message);
                }
                
            }*/

            #endregion
            #region select1

            /*using (var d = new MyDbcontext())
            {
                var a = d.Articles.Select(a => new
                {
                    a.id,
                    a.title
                }).First();
                Console.WriteLine(a.ToString());
            }*/

            #endregion
            #region Select2

            /*using (var d = new MyDbcontext())
            {
                var a = d.Commnets.
                    Select(a => new
                    {
                       id1 = a.id,
                       id = a.Article.id
                    }).Where(a=>a.id==1);
                foreach (var i in a)
                {
                    Console.WriteLine(i.ToString());
                }
            }*/


            #endregion
            #region select3

            /*using (var d = new MyDbcontext())
            {
                var commnet = d.Commnets.SingleOrDefault(c => c.id == 2);
                Console.WriteLine(commnet.id+"   "+commnet.Articleid);
            }*/

            #endregion
            #region select4

            /*using (var d=new MyDbcontext())
            {
                var i = d.Leaves.SingleOrDefault(a => a.id == 1);
                if (i!=null)
                {
                    Console.WriteLine(i.ToString());
                }
            }*/


            #endregion
            #region select5

            /*
            using (var d=new MyDbcontext())
            {
                var queryable = d.Articles.Where(a => a.
                    Commnets.Any(a=>a.Message.Contains("smd")));
                foreach (var article in queryable)
                {
                    Console.WriteLine(article.Message);
                }

                var articles = d.Commnets.Where(a => a.Message.Contains("smd")).
                    Select(a => a.Article)
                    .GroupBy(a => a.title);
                foreach (var i in articles)
                {
                    Console.WriteLine(i.Key);
                }
            }
            */

            #endregion
            #region select6/客户端评估

            /*using (var i=new MyDbcontext())
            {
                var queryable =((IEnumerable<Commnet>) i.Commnets).Select(a => new
                {
                    id = a.id,
                    Pre = a.Message.Substring(0, 1) + "...."
                });
                foreach (var i1 in queryable)
                {
                    Console.WriteLine(i1.id+"  "+i1.Pre);
                }

                var commnets = ((IEnumerable<Commnet>)i.Commnets)
                    .Where(a => IsOk(a.Message));
                foreach (var i1 in commnets)
                {
                    Console.WriteLine(i1.id + "  " + i1.Message);
                }
            }*/

            #endregion
            #region 异步

            /*using (var i=new MyDbcontext())
            {
                await foreach (var i1 in i.Articles.Where(a=>a.id>1).AsAsyncEnumerable())
            {
                Console.WriteLine(i1.title);
            }
            }*/


            #endregion
            #region IQ

            /*using (var i=new MyDbcontext())
            {
                /*

               var user = new Leave()
               {
                   id=1
               };
               i.Remove(user);
               var  saveChangesAsync =await i.SaveChangesAsync();
               Console.WriteLine(saveChangesAsync);#1#
                var queryable = i.Articles.Where(a => a.id == 1).Select(a=>new
                {
                    id=a.id,
                }).Count();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(queryable);
            }*/
            /*Console.WriteLine("---------------------------------------");
            QueryA("smd",false,true);*/

            #endregion
            #region 实验

            /*using (var d= new MyDbcontext())
            {
                var article = d.Articles.SingleOrDefault(a => a.id == 2);
                Console.WriteLine();
                Console.WriteLine(article.ToString());
                foreach (var i in article.Commnets)
                {
                    Console.WriteLine();
                    Console.WriteLine(i.ToString());
                }

                var commnet = d.Commnets.SingleOrDefault(a => a.id == 1);
                Console.WriteLine(commnet.Article.Message);
            }*/

            #endregion

            #region 状态跟踪

            using (var i =new MyDbcontext())
            {
                var article = i.Articles.First();
                article.Message = "smsmsmsmd?";
                var entityEntry = i.Entry(article);
                Console.WriteLine(entityEntry);
            }

            #endregion
        }

        static void PrintPage(int pageIdex, int pageSize)
        {
            using (var a1 = new MyDbcontext())
            {
                var queryable = a1.Articles.Where(a => a.id >= 3)
                                .Where(a => !a.title.Equals("smd"));
                var articles = queryable.Skip((pageIdex-1)*pageSize).Take(pageSize);
                foreach (var i in articles)
                {
                    Console.WriteLine(i.title);
                }
            }
        }

        static void Pages(int pageSize)
        {
            using (var i=new MyDbcontext())
            {
                var count = i.Articles.Select(a => a.id).Count();
                var ceiling = Math.Ceiling(count * 1.0 / pageSize);
                Console.WriteLine(ceiling);
            }
        }

        static async Task AddA(int a)
        {
            using (var a1=new MyDbcontext())
            {
                for (int i = 0; i < a; i++)
                {
                    
                    var article = new Article()
                    {
                        title = "卡了",
                        Message = "别加了,卡了"

                    };
                    var commnet = new Commnet()
                    {
                        Message = "纯卡比，别玩了"
                    };
                    var commnet1 = new Commnet()
                    {
                        Message = "真他妈卡"
                    };
                    article.Commnets.Add(commnet1);
                    article.Commnets.Add(commnet);
                    a1.Articles.Add(article);
                    var async = await a1.SaveChangesAsync();
                    Console.WriteLine(async);
                    Console.WriteLine(1);
                }
                
            }
        }
        static bool IsOk(String s)
        {
            if (s.StartsWith("s"))
            {
                return s.Length > 4;
            }
            else
            {
                return s.Length < 3;
            }
        }
        static void QueryA(string name, bool all, bool byid)
        {
            using (var i=new MyDbcontext())
            {
                var queryable = i.Articles.Where(a => a.title.Contains(name));
                Console.WriteLine(1);
                if (byid)
                {
                    var orderedQueryable = queryable.OrderBy(a => a.id);
                    Console.WriteLine(2);
                    if (!all)
                    {
                        var select = orderedQueryable.Select(a => new
                        {
                            id = a.id,

                        });
                        foreach (var i1 in select)
                        {
                            Console.WriteLine(i1.id);
                        }

                    }

                  
                }

               
                
            }
        }
        }

}