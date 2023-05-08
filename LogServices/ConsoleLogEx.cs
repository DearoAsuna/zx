using System;
using System.Collections.Generic;
using System.Text;
using LogServices;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConsoleLogEx
    {
        public static void ADDConsoleLog(this ServiceCollection services)
        {
            services.AddScoped<ILogProvider, ConsoleLogProvider>();
        }
    }
}
