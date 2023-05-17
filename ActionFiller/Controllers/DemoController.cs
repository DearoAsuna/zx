using System.Transactions;
using EFCore11;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ActionFiller.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly MyDbContext _db;

        public DemoController(MyDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpPost]
        [NotTransation]
        public async Task<ActionResult<string>> Test(string name)
        {
            using (var i = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                var person = new Person()
                {
                    Name = name,
                    Description = "司马刁冒险日记系列丛书作者"
                };
                _db.Persons.Add(person);
                await _db.SaveChangesAsync();
                var book = new Book()
                {
                    DateTime = DateTime.Now,
                    Name = "司马刁",
                    Price = 88,
                };
                _db.Books.Add(book);
                person.Books?.Add(book);
                await _db.SaveChangesAsync();
                i.Complete();
            }

            return Ok("ok");

        }

        [HttpPost]
        [NotTransation]
        public async Task<ActionResult<string>> Test1(string name)
        {
            using (var i = new TransactionScope
                       (TransactionScopeAsyncFlowOption.Enabled))
            {
                var person = new Person()
                {
                    Name = name,
                    Description = "司马刁冒险日记系列丛书作者"
                };
                _db.Persons.Add(person);
                await _db.SaveChangesAsync();
                var book = new Book()
                {
                    DateTime = DateTime.Now,
                    Name = "司马刁啊实打实",
                    Price = 88,
                };
                _db.Books.Add(book);
                person.Books?.Add(book);
                await _db.SaveChangesAsync();
            }

            return Ok("ok");
        }
    }
}
