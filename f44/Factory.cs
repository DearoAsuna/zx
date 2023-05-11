using System;
using System.Reflection;
using IPerson1;

namespace f44
{
    public class Factory
    {
        public static IPerson create()
        {
            var assembly = Assembly.LoadFrom("Dao3.dll");
            var type = assembly.GetType("Dao3.Man");
            var o = Activator.CreateInstance(type);

            return (IPerson)o;

            /*return new Dao2.Man();*/
        }
    }
    
}
