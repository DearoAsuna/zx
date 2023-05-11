using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService
{
    public class ceshi : IconfigService
    {
        public ceshi()
        {
            Console.WriteLine(GetType().Name);
        }
        public string GetValue(string name)
        {
            return name;
        }
    }
}