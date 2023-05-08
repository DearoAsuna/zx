using Microsoft.Extensions.DependencyInjection;

namespace ioc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddSingleton
                (typeof(ITest), typeof(Test));
            /*collection.AddScoped<ITest, Test>();*/
            using (var sp=collection.BuildServiceProvider())
            {
                var service = sp.GetService<ITest>();
                service.name = "smd";
                service.Say();
                Console.WriteLine(service.GetType());
            }
        }
    }
    interface ITest
    {
        public string name { get; set; }
        void Say();
    }
    class Test : ITest
    {
        public string name { get; set; }

        public void Say()
        {
            Console.WriteLine($"{name} Hi");
        }
    }
}