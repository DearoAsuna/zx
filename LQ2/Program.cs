using System.ComponentModel.DataAnnotations;

namespace LQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r1 = new List<Emplyee>();
            r1.Add(new Emplyee()
            {
                Id=1,Age = 100,Gender = true,
                Name =  "smd",Salary = 112312300
            });
            r1.Add(new Emplyee()
            {
                Id = 2,
                Age = 100,
                Gender = true,
                Name = "smd",
                Salary = 11230
            });
            r1.Add(new Emplyee()
            {
                Id = 3,
                Age = 100,
                Gender = true,
                Name = "smd",
                Salary = 10
            });
            r1.Add(new Emplyee()
            {
                Id = 4,
                Age = 100,
                Gender = true,
                Name = "md",
                Salary = 10
            });
            Console.WriteLine(r1.Count(e =>e.Age>15&&e.Id>5 ));
            Console.WriteLine(r1.Any(e=>e.Gender=false));
            Console.WriteLine(r1.Any(e=>e.Gender=true));
            var e1 = r1.Where(e => e.Id > 2);
            foreach (var i in e1)
            {
               // Console.WriteLine(i);
            }

            var employee = r1.Single(a => a.Id == 1);
            Console.WriteLine(employee);
            var employee1 = r1.SingleOrDefault(a => a.Id == 1);
            Console.WriteLine(employee1);
            var first = r1.First(a => a.Age > 10);
            Console.WriteLine(first);
            var orderBy = r1.OrderBy(e => e.Age);
            var orderByd = r1.OrderByDescending(e => e.Id);
            var orderedEnumerable = r1.OrderBy(e => e.Name[0])
                .ThenBy(e=>e.Salary).Skip(3).Take(1);
            Console.WriteLine("=============");
            foreach (var i in orderedEnumerable)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("=============");
            
            foreach (var i in orderBy)
            {
                Console.WriteLine(i);
            }
            foreach (var i in orderByd)
            {
                Console.WriteLine(i);
            }
            int[] num1={1,5,6,8,3,2,5,10,222,111,226,156};
            var ints = num1.OrderBy(i => i);
            Console.WriteLine("==============");
            foreach (var i in ints)
            {
                Console.Write(i+"  ");
            }

            Console.WriteLine("==============");

            var r11 = r1.OrderByDescending(a => a.Id).Take(1);
            foreach (var i in r11)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==============");

            int max = r1.Where(e => e.Id >2 ).Max(e => e.Salary);
            Console.WriteLine(max);
        }

        class  Emplyee
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Gender { get; set; }
            public int Salary { get; set; }
            public override string ToString()
            {
                return $"id={Id},name={Name},age={Age},Gerder={Gender},salary={Salary}";
            }
        }
    }
}