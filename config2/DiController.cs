using Microsoft.Extensions.Options;

namespace Json1
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
