using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FillterWebAPI
{
    
    public class MyExcpetionFiller:IAsyncExceptionFilter
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public MyExcpetionFiller(IWebHostEnvironment webHostEnvironment)
        {
           this.webHostEnvironment = webHostEnvironment;
        }

        public Task OnExceptionAsync(ExceptionContext context)
        {
            string msg;
            if (webHostEnvironment.IsDevelopment())
            {
                msg = "出大问题";
            }
            else
            {
                msg="出问题了";
            }

            var result = new ObjectResult(new { code = 500, message = msg });
            context.Result=result;
            context.ExceptionHandled=true;
            return Task.CompletedTask;
        }
    }
}
