using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
     class WebConfig
    {
        public ConnectStr connl { get; set; }
        public ConnectStr ConnTest { get; set; }
        public config Config { get; set; }


    }

     public class ConnectStr
     {
         public string ConnectionString { get; set; }
         public string ProviderName { get; set; }
     }

     public class config
     {
         public string Name { get; set; }
         public int Age { get;  set; }
         public Proxy Proxy { get; set; }
     }

     public class Proxy
     {
         public string Address { get; set; }
         public int Prot { get; set; }
         public int[] Ids { get; set; }
     }
}
