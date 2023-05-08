using Microsoft.Extensions.Configuration;

namespace Json1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json",optional:true,reloadOnChange:true);
            var build = builder.Build();


            var s = build["smd:name"];
            Console.WriteLine(s);
        }
    }
}