using DiInterfers;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace DIYDi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 反射

            /*var phone = Factory11.Facory11.Create();
            phone.Call();*/

            #endregion

            var collection = new ServiceCollection(); 
            
            collection.AddScoped<IMicroPhone, Micro>();
            collection.AddScoped<IMicroPhone, Micro1>();
            collection.AddScoped<IPower,Power>();
            using (var i=collection.BuildServiceProvider())
            {
                var service = i.GetService<IPower>();
            }
        }
    }
}