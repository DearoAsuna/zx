using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json1;
using Microsoft.Extensions.Options;

namespace Json1
{

    public class TestWebConfig
    {
        private IOptionsSnapshot<WebConfig> snapshot;
        public TestWebConfig(IOptionsSnapshot<WebConfig> snapshot)
        {
            this.snapshot = snapshot;
        }

        public void Test()
        {
            var wc=snapshot.Value;
            Console.WriteLine(wc.connl.ConnectionString);
            Console.WriteLine(wc.Config.Age);
            Console.WriteLine(wc.Config.name);
            Console.WriteLine(wc.Config.Proxy.Address);
            Console.WriteLine(wc.Config.Proxy.port);
           
        }
    }
}
