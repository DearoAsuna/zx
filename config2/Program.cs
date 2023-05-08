using Json1;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Json1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddScoped<DiController>();
            collection.AddScoped<TestWebConfig>();

            var builder = new ConfigurationBuilder();

            builder.Add(new FxConfigSourse()
            {
                Path = "web.config"
            });

            var build = builder.Build();

            collection.AddOptions().
                Configure<WebConfig>(e => build.Bind(e));
            

            using (var provider = collection.BuildServiceProvider())
            {
                var c=provider.GetRequiredService<TestWebConfig>(); 
                c.Test();
            }

        }
    }
    public class Proxy
    {
        public string Address { get; set; }
        public int port { get; set; }
        public int[] ids { get; set; }
    }

    public class Config
    {
        public string name { get; set; }
        public int Age { get; set; }
        public Proxy Proxy { get; set; }
    }
}