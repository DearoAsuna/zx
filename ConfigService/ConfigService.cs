using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService
{
    public class ConfigService1:IconfigService
    {
        public string GetValue(string name)
        {
            return Environment.GetEnvironmentVariable(name);
        }
    }
}
