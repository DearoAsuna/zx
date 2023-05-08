using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            smd11 c = new smd11("smd", 11);
            c.add(1);
            Console.WriteLine(c.name+"  "+c.age);
            Console.ReadKey();            
        }
        class smd11
        {
            //ctor
            public smd11(string  name,int age)
            {
                this.name = name;
                this.age = age;
            }
            public string name;
            public int age;
            public int add(int a)
            {
                
                age = age + a;

                return age;
            }
        }
        class Person
        {
            public string Name;
             public static List<Person> GetMarry(Person p1,Person p2)
            {
                List<Person> people = new List<Person> { };
                people.Add(p1);
                people.Add(p2);
                for (int i = 0; i < 11; i++)
                {
                    Person child = new Person();
                    child.Name = p1.Name + "&" + p2.Name + "s child";
                    people.Add(child);
                }
                return people;
            }

        }
        
       
    }
}
