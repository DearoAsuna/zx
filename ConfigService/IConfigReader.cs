using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService
{
    public interface IConfigReader
    {
        public string GetValue(string name);
    }
}
