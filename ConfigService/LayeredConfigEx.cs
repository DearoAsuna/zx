using System;
using System.Collections.Generic;
using System.Text;
using ConfigService;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class LayeredConfigEx
    {
        public static void AddLayeredconfig(this IServiceCollection service)
        {
            service.AddScoped<IConfigReader, LayeredConfigReader>();
        }
    }
}
