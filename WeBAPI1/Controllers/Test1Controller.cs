using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeBAPI1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Test1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Grade(int id)
        {
            if (id == 1)
            {
                return Ok(99);
            }

            return BadRequest("空值");
        }
        [HttpGet]
        public ActionResult<int> Grade1(int id)
        {
            if (id == 1)
            {
                return 99;
            }

            return NotFound("空值");
        }
        [HttpGet("{id1}/{id2}")]
        public ActionResult<int> Grade2(int id1,int id2)
        {
            if (id1 == 1)
            {
                return 99;
            }

            return NotFound("空值");
        }

        [HttpGet("student/id/{id}")]
        public ActionResult<string> Grade3([FromRoute(Name = "id")]int id1)
        {
            if (id1==1)
            {
                return "666";
            }

            if (id1==2)
            {
                return "777";
            }

            return NotFound("找不到一点");
        }

        [HttpPost]
        public string Person(Person person)
        {
            return new string($"ok + {person.id}");
        }

        [HttpPost("id/{id}")]
        public ActionResult<string> Person1(Person person,int id)
        {
            return new string($"ok+{person.id}+{person.Name}");
        }


    }
}
