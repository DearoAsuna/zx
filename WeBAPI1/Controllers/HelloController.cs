using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeBAPI1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HelloController 
    {
        [HttpPost]
        public int Add(int i,int j)
        {
            return i + j;
        }

        [HttpGet]
        public int Cj(int a)
        {
            if (a==1)
            {
                return 8;
            }
            return 0;
        }

        [HttpGet]
        public async Task<string> Add2(int id)
        {
            var async =await File.ReadAllTextAsync("D:/C#dm/zx1/WeBAPI1/司马刁.txt");
            return async;

        }
    }

   
}
