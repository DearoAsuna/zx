using Microsoft.Extensions.DependencyInjection;

namespace DI1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddScoped<Controller>();
            collection.AddScoped<ILog,LogImpl>();
            collection.AddScoped<IStorage,StroageImpl>();
   //       collection.AddScoped<IConfig,ConfigImpl>();
            collection.AddScoped<IConfig,DBconfig>();

            using (var provider = collection.BuildServiceProvider())
            {
                var controller = provider.GetRequiredService<Controller>();
                controller.Test();
            }

           
        }

        class Controller
        {
            private readonly ILog log;
            private readonly IStorage storage;

            public Controller(ILog log,IStorage storage)
            {
                this.log = log;
                this.storage = storage;
            }

            public void Test()
            {
                log.Log("上传");
                this.storage.Save("asdasd","1.txt");
                log.Log("完毕");
            }
        }

        interface ILog
        {
            public void Log(string message);

        }

        class LogImpl:ILog
        {
            private string name;
            public LogImpl()
            {
                this.name = "smd";
            }
            public void Log(string message)
            {
                Console.WriteLine($"日志:{message}");
            }
        }

        interface IConfig
        {
            public string GetValue(string key);
        }

        class ConfigImpl:IConfig
        {
            public string GetValue(string key)
            {
                return "smd";
            }
        }

        class DBconfig: IConfig
        {
            public string GetValue(string key)
            {
                Console.WriteLine("数据库读取");
                return "get DB";
            }
        }

        interface IStorage
        {
            public void Save(string name, string content);
        }

        class StroageImpl:IStorage
        {
            private readonly IConfig  config;

            public StroageImpl(IConfig config)
            {
                this.config= config;
            }

            public void Save(string name, string content)
            {
                var value = config.GetValue("Server");
                Console.WriteLine($"Sever:{value} 文件名{name}上传{content}");
            }
        }
    }
}