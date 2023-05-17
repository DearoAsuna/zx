using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FillterWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Demo1Controller : ControllerBase
    {
        [HttpGet]
        public async Task<string> Test1()
        {
            var async =await System.IO.File.ReadAllTextAsync("smd历险记");
            return async;
        }
    }
}
