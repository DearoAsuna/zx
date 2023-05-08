using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService
{
    public class ceshi : IconfigService
    {
        public string GetValue(string name)
        {
            return name;
        }
    }
}