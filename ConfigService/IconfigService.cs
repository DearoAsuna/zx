using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService
{
    public interface IconfigService
    {
        public string GetValue(string name);
    }
}
