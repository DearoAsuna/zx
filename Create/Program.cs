using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Name = "smd1"; 
            p2.Name = "smd2";
            List<Person> nation = p1+p2;
            Console.WriteLine(nation);
            foreach(var p in nation)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name;
        public static List<Person> operator +(Person p1, Person p2)
        {
            List<Person> people = new List<Person> { };
            people.Add(p1);
            people.Add(p2);
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + "&" + p2.Name + "s child"+i;
                people.Add(child);
            }
            return people;
        }

    }
}
