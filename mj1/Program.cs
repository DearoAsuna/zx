using System;


namespace mj1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.l1 = Level.BigBoss | Level.Boos |Level.Employee;
            Console.WriteLine((p1.l1&Level.BigBoss)>0);
        }
    }

    enum Level
    {
        Employee=1,
        Manager,
        Boos,
        BigBoss
    }

    class Person
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Level l1 { get; set; }
    }
}
