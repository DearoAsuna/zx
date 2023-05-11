using System;

using System.Reflection;



namespace f45
{
    public class Simple
    {
        public static IPerson.IPerson create()
        {
            var assembly = Assembly.Load("Dao2");
            var type = assembly.GetType("Dao2.Man");
            var o = Activator.CreateInstance(type);

            return (IPerson.IPerson)o;

            /*return new Dao2.Man();*/
        }

    }
   
}
