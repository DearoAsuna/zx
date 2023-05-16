using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeBAPI1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public Person[] GetAll()
        {
            return new Person[]
            {
                new  Person(1,10,"SmdPro"),
                new  Person(2,10,"SmdProMax"),
            };
        }
        [HttpGet]
        public Person GetById(int id)
        {
            if (id==1)
            {
                return new Person(1, 10, "SmdPro");
            }
            
            return new Person(2, 10, "SmdProMax");
            
            
        }

        [HttpPost]
        public string SaveNote(Person person)
        {
            return "ok";
        }
    }
}
