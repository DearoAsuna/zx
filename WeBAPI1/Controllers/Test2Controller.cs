using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeBAPI1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Test2Controller : ControllerBase
    {
        private readonly Calculator calculator;
     
        public Test2Controller(Calculator calculator, Time time)
        {
            this.calculator = calculator;
       
        }
        [HttpGet]
        public int add1()
        {
            return calculator.Add(3, 8);
        }

        [HttpGet]
        public string add2([FromServices]Time time)
        {
            return time.Sleep();
        }
        [ResponseCache(Duration = 20)]
        [HttpGet]
        public string Now()
        {
            return DateTime.Now.ToString();
        }
    }
}
