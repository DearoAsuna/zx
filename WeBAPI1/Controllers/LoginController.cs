using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeBAPI1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost] 
        public LogReponse Login(LogRequst req)
        {
            if (req.UserName.Equals("admin")&&req.Password=="123456")
            {
                Console.WriteLine(req.UserName +req.Password);
                var infos = Process.GetProcesses().Select(p =>
                    new ProcessInfo(p.Id, p.WorkingSet64)).ToArray();
                return new LogReponse(true, infos);

            }

            return new LogReponse(false,null) ;
        }
    }

    public record LogRequst(string UserName, string Password);
    public record ProcessInfo(long Id, long WorkingSet);

    public record LogReponse(bool OK, ProcessInfo[] Process);

}
