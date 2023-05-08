using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional: true, reloadOnChange: true);
            var build = builder.Build();

            #region di
            /*
            var collection = new ServiceCollection();
            collection.AddScoped<DiController>();
            collection.AddScoped<Test2>();
            
            collection.AddOptions()
              .Configure<Config>(e =>build.Bind(e))
              .Configure<Proxy>(e => build.GetSection("Proxy").Bind(e)); 

          using (var provider = collection.BuildServiceProvider())
          {

              while (true)
              {
                  using (var sc= provider.CreateScope()) 
                  {
                      var service = sc.ServiceProvider.GetRequiredService<DiController>();
                      service.Test();
                      var test2 = sc.ServiceProvider.GetRequiredService<Test2>();
                      test2.Test1();
                  }
                  Console.ReadKey();
              }
          }*/


            #endregion

            #region 普通

            string? s = build["name"];
            Console.WriteLine($"name={s}");
            /*var s1 = build.GetSection("Proxy:address").Value;*/
            var s1 = build["Proxy:address"];
            Console.WriteLine(s1);
            var proxy = build.GetSection("Proxy").Get<Proxy>();
            Console.WriteLine(proxy.Port);
            Console.WriteLine(proxy.address);

            #endregion

        }
    }
    public class Proxy
    {
        public string address { get; set; }
        public int Port { get; set; }
    }
    public class Config
    {
        public string name { get; set; }
        public int Age { get; set; }
        public Proxy Proxy { get; set; }
    }
}