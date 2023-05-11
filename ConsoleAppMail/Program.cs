using System.Diagnostics;
using ConfigService;
using LogServices;
using MailService;
using Microsoft.Extensions.DependencyInjection;
namespace ConsoleAppMail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
           // collection.AddScoped<IconfigService, ConfigService1>();
           /*collection.AddScoped(typeof(IconfigService)
               ,s
                   => new iniFileCoinfigService()
                       { FilePath = "mail.txt" });*/
            collection.AddScoped<IconfigService, ConfigService1>();
           // collection.AddScoped<IconfigService, ceshi>();
            collection.ADDconfig("mail.txt");
            collection.AddLayeredconfig();
          //  collection.AddScoped<ILogProvider, ConsoleLogProvider>();
            collection.ADDConsoleLog();
            collection.AddScoped<IMailService,MailServiceImpl>(); 
            using (var sp = collection.BuildServiceProvider())
            {
                var o = sp.GetRequiredService<IMailService>();
                o.send("cqust","smd","nmmsl");
            }

           
        }
    }
}