using Microsoft.Extensions.DependencyInjection;

namespace DI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new ServiceCollection();
            collection.AddScoped(typeof(Controller));
            collection.AddScoped(typeof(IPerson),typeof(Man));
            using (var i=collection.BuildServiceProvider())
            {
                var o = i.GetRequiredService<Controller>();
                o.Say();
            }
        }
    }

    class Controller
    {
        public IPerson Person { get; set; }

        public Controller(IPerson person)
        {
            this.Person= person;
        }

       public void Say()
        {
            Person.Say();
        }
    }
}