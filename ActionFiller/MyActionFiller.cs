using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFiller
{
    public class MyActionFiller:IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync
            (ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("执行前代码");
            /*var
             objects = context.ActionArguments.Values;
            var list = objects.ToList();
            if (list[0] is string)
            {
                var s = list[0] as string;
                if (s.Equals("sm"))
                {
                    s="司马刁";
                }
            }*/

            var executedContext = await next();
            if (executedContext.Exception!=null)
            {
                Console.WriteLine("MyActionFillterl:出现异常了");
            }
            else
            {
                Console.WriteLine("MyActionFillterl:成功");
            }
        }
    }
}
