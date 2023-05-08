using ConfigService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class iniFileCongig
    {
        public static void ADDconfig(this ServiceCollection services, string file)
        {
            services.AddScoped
            (
                typeof(IconfigService), s
                => new iniFileCoinfigService()
                    { FilePath = file }
            );
        }
}
   
}
