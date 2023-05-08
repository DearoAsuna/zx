using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigService
{
     class LayeredConfigReader: IConfigReader
    {
        private readonly IEnumerable<IconfigService> _readers;

        public LayeredConfigReader(IEnumerable<IconfigService> _readers)
        {
            this._readers = _readers;
        }
        public string GetValue(string name)
        {
            string value = null;
            foreach (var i in _readers)
            {
               string newValue=i.GetValue(name);
               if (newValue != null)
               {
                   value=newValue;
               }
            }

            return value;
        }
    }
}
