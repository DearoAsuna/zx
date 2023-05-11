using System.Reflection;
using DiInterfers;

namespace Factory11
{
    public class Facory11
    {
        public static IPhone Create()
        {
            var ass = Assembly.LoadFrom("Service.dll");
            var type = ass.GetType("Service.Apple");
            var instance = Activator.CreateInstance(type);

            return (IPhone)instance;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}