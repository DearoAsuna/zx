using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConfigService
{
    public class iniFileCoinfigService:IconfigService
    {
        public string FilePath { get; set; }
        public string GetValue(string name)
        {
            var k = File.ReadLines(FilePath)
                .Select(s=>s.Split("="))
                .Select(s => new
                {
                    Name = s[0],
                    value = s[1]
                }).SingleOrDefault(k=>k.Name==name);
            if (k!=null)
            {
                return k.value;
            }
            else
            {
                return null;
            }
        }
    }
}
