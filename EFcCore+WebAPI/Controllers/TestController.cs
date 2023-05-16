using EFCore11;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFcCore_WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    
    public class TestController : ControllerBase
    {
       private readonly MyDbContext db;

       public TestController(MyDbContext db)
       {
           this.db = db;
       }

       [HttpGet]
       public ActionResult<string> Get()
       {
           var count = db.Books.Count();
           if (count==0)
           {
               return NotFound("没找到");
           }

           return count.ToString();
       }

       [HttpGet]
       public ActionResult<Book> GetById(int id)
       {
           var b = db.Books.SingleOrDefault(a => a.Id == id);
           if (b!=null)
           {
               return Ok(b);
           }
           return NotFound("ID错了蠢狗");
       }

       [HttpPut]
       public async Task<ActionResult<string>> Add(Book book)
       {
          
           db.Books.Add(book);
          await  db.SaveChangesAsync();
          return Ok("增加完成");
       }

       [HttpDelete]
       public async Task<ActionResult<string>> Del(string name)
       {
           var bools = db.Books.Where(a => a.Name.Contains(name));


           foreach (var b in bools)
           {
               Console.WriteLine("------------------------------");
               Console.WriteLine(b.Id);
           }
           if ( !bools.Any())
           {
               return NotFound("没有值");
           }

          
           foreach (var b in bools)
           {
               
                db.Remove(b);
               
           }

           await db.SaveChangesAsync();

            return Ok("删除完成");
       }

       [HttpPut]
       public async Task<ActionResult<string>> Update(string name, Book book)
       {
           var bools = db.Books.Where(a => a.Name.Equals(name));
           foreach (var b in bools)
           {
               b.Name = book.Name;
               b.Price= book.Price;
               b.DateTime= book.DateTime;
               b.Title= book.Title;
           }

           var async = await db.SaveChangesAsync();
           if (async!=0)
           {
               return Ok($"更改了{async}");
           }

           return NotFound("出问题了");
       }

       [HttpGet]
       public ActionResult<List<Book>> fenye(int jige, int yeshu)
       {
           var books = db.Books.Where(a=>a.Id!=0)
               .Skip((yeshu - 1) * jige).Take(jige);
           var list = books.ToList();
           return Ok(list);
       }

    }
}
