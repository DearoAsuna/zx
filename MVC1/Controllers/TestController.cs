using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Demo1()
        {
            var person = new Person(true,DateTime.Now, "SmdProMax");
            return View(person);
        }
    }
}
