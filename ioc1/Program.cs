using Microsoft.Extensions.DependencyInjection;

namespace ioc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddScoped<ITest,Test>();
            collection.AddScoped<Controller>();
            using (var sp 
                   = collection.BuildServiceProvider())
            {
                #region 常规

                /*var service = sp.GetRequiredService<Test>();
               service.name = "smd";

                   service.Say();
                  var service1 = sp.GetRequiredService<Test>();
                   service1.name = "smd1";
                   service1.Say();
                   service.Say();*/ 
                #endregion

                var controller = sp.GetRequiredService<Controller>();
                controller.say();
            }

           

        }
    }

    interface ITest
    {
        void Say();
        
    }
    class Test:ITest
    {
        public string name { get; set; }

        public Test()
        {
            this.name = "smd";
        }
        public void Say()
        {
            Console.WriteLine($"{name} Hi");
        }
    }

    class Controller
    {
        private readonly ITest t1;

        public Controller(ITest t1)
        {
            this.t1 = t1;
        }

        public void say()
        {
            t1.Say();
        }
    }
}