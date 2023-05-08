using System.Reflection;

namespace fs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = new Student();
            var type = obj.GetType();
            //type 属性
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);

            /*foreach (var i in type.GetFields())
            {
                Console.WriteLine(i.Name);
                if (i.Name=="age")
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(i.FieldType.FullName);
                    i.SetValue(obj, 12);
                    Console.WriteLine(i.GetValue(obj));
                }
                
            }*/
            /*type.GetField("age")?.SetValue(obj,33);
            Console.WriteLine(type.GetField("age")?.GetValue(obj));*/
            /*foreach 
                (var info in type.GetProperties())
            {
                Console.WriteLine(info.Name);
                Console.WriteLine(info.PropertyType.FullName);
                info.SetValue(obj,15);
                Console.WriteLine(info.GetValue(obj));
            }*/
            /*var info = type.GetProperty("id");
            info.SetValue(obj,15);
            Console.WriteLine(info.GetValue(obj));*/
            foreach (var info in type.GetMethods())
            {
                Console.WriteLine(info.Name);
            }

            type.GetMethod("Show").Invoke(obj, new object[0]);
        }
    }

    public class Student
    {
        public int id { get; set; }
        public int age;

        public void Show()
        {
            Console.WriteLine("this is show");
        }

        public string show2(string name)
        {
            return $"{name} 你好";
        }

    }
}