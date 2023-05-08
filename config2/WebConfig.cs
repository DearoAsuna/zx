using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json1;


namespace Json1
{
    public class WebConfig
    {
        public ConnectStr connl { get; set; }
        public ConnectStr ConnTest { get; set; }
        public Config Config { get; set; }


    }

     public class ConnectStr
     {
         public string ConnectionString { get; set; }
         public string ProviderName { get; set; }
     }

  

}
