using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Json
{
   public class DiController
   {
       private readonly IOptionsSnapshot<Config> config;

       public DiController(IOptionsSnapshot<Config> config)
       {
           this.config = config;
       }

       public void Test()
       {
            Console.WriteLine(config.Value.Age);
       }
   }
}
