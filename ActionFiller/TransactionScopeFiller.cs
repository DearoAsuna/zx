using System.Transactions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;


namespace ActionFiller
{
    public class TransactionScopeFiller:IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync
            (ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var actionDescriptor = context.ActionDescriptor as ControllerActionDescriptor;
            bool isTx = false;
            if (actionDescriptor != null)
            {
                var any = actionDescriptor.MethodInfo.GetCustomAttributes
                    (typeof(NotTransationAttribute),false).Any();
                isTx = !any;
            }

            if (isTx)
            {
                using (var i=new TransactionScope
                       (TransactionScopeAsyncFlowOption.Enabled))
                {
                    var r = await next();
                    if (r.Exception==null)
                    {
                        i.Complete();
                    }
                    
                }
            }
            else
            {
                await next();
            }

        }
    }
}

