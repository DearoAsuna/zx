using System;

namespace jiegou
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student
            {
                Name = "smd",
                id = 1008611
            };
            var s2 = s1;
            s2.Name = "smd1";
            s2.id = 10086;
            Console.WriteLine(s1.Name+"     "+s1.id);
            Console.WriteLine(s2.Name+"     "+ s2.id);
            s2.Speak();
        }
    }

    class Student:ISpeak
    {
        public int id { get; set; }
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine(id+" "+Name);
        }
    }

    interface ISpeak
    {
        void Speak();
    }

}
