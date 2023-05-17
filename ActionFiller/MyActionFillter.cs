

using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFiller
{
    public class MyActionFillter:IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync
            (ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("2   执行前代码");
            var executedContext = await next();
            if (executedContext.Exception != null)
            {
                Console.WriteLine("MyActionFillterl2:出现异常了");
            }
            else
            {
                Console.WriteLine("MyActionFillterl2:成功");
            }
        }
    }
}
