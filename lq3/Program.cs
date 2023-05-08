namespace lq3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r1 = new List<Emplyee>();
            r1.Add(new Emplyee()
            {
                Id = 1,
                Age = 100,
                Gender = true,
                Name = "smd",
                Salary = 112312300
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
                Age = 101,
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
            /*var r1q
             = r1.Where(e => e.Age >= 30).Average(e => e.Salary);
            var r12 = r1.Where(e => e.Age >= 30).Sum(e => e.Salary);
            Console.WriteLine(r12);
            Console.WriteLine(r1q);*/
            /*var groupBy
             = r1.GroupBy(e => e.Salary);
            foreach (var i in groupBy)
            {
                int cout = 0;
                Console.WriteLine(i.Key);
                Console.WriteLine("Max" + i.Max(a => a.Age));
                foreach (var i1 in i)
                {
                    Console.WriteLine(i1);
                    Console.WriteLine(++cout);
                }

                Console.WriteLine("=================");
            }*/
            /*var ints
             = r1.Where(e => e.Salary>1000).Select(e=>e.Gender?"man":"woman");
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }

            var dogs = r1.Select(e => new Dog
            {
                Name = e.Name,
                Id = e.Id,
            });
            foreach (var dog in dogs)
            {
                var s = dog.ToString();
                Console.WriteLine(s);
            }

            var select = r1.Select(e => new
            {
                xingming = e.Name,
                Id = e.Id,
                Gender=e.Gender?"男":"女"
            });
            foreach (var i in select)
            {
                Console.WriteLine(i);
            }*/
            /*var enumerable
                = r1.GroupBy(e => e.Salary).Select(g => new
            {
                Gongzi = g.Key,
                Maxage = g.Max(e => e.Age),
                Minage = g.Min(e => e.Age),
                Maxs = g.Max(e => e.Salary),
                Mins = g.Min(g => g.Salary),
                Sum=g.Count()
            });
            foreach (var e1 in enumerable)
            {
                Console.WriteLine(e1);
            }*/
            /*var  enumerable
             = r1.Where(a => a.Salary > 20);
            var emplyees = enumerable.ToList();
            foreach (var emplyee in emplyees)
            {
                Console.WriteLine(emplyee);
            }*/
            /*var enumerable
                = r1.Where(e => e.Id > 2).GroupBy(e => e.Age).
                    OrderBy(e => e.Key).Take(2).
                    Select(g => new
                {
                    nianling = g.Key,
                    MAXage = g.Max(e => e.Age),
                    MAx=g.Max(e => e.Salary),
                    rs =g.Sum(e=>e.Salary) 
                });
            foreach (var i in enumerable)
            {
                Console.WriteLine(i);
            }*/
            /*var enumerable
             = r1.Where(e => e.Salary > 200).OrderBy(e => e.Age).Select(e => new
            {
                e.Age,
                e.Name,
                xb = e.Gender ? "man" : "woman"
            });
            foreach (var i in enumerable)
            {
                Console.WriteLine(i);
            }
            var e1= from i in r1 where i.Salary > 200 select new 
            {
                i.Age,
                i.Name,
                xb = i.Gender ? "man" : "woman"
            };
            foreach (var i in e1)
            {
                Console.WriteLine(i);
            }*/
            /*var i = "1,231,2312312,31,24,5123,123,123123123,32323,3232,3223";
            var average = i.Split(",").Select(e => Convert.ToInt32(e)).Average();
            Console.WriteLine(average);*/
            /*var a = "sdjasl,asdjasd,smd,smd,sadhasld,sadkajsd";
            var enumerable =a.Where(c => char.IsLetter(c)).Select(c => char.ToLower(c))
                .GroupBy(c=>c).Select(c=>new
                {
                    c.Key,
                    count=c.Count()
                }).OrderByDescending(g=>g.count).Where(g=>g.count>2);
            foreach (var i in enumerable)
            {
                Console.WriteLine(i);
            }*/

            /*var str = new String[]
            {
                "wqeqwe", "qweqwe", "asdad", "qweqwe", "qweqwe"
            };
            var i1 = str.GroupBy(e=>e).Select(c=>new
            {
                c.Key,
                count=c.Count()
            });
            foreach (var i in i1)
            {
                Console.WriteLine(i);
            }*/
            var str = "qweqweqweqwe,qweqwe,qweqwe,qwe,qwe,qwe,qwe,qwe";
            var s1 = str.Split(",").GroupBy(e => e).Select(c => new
            {
                String = c.Key,
                cout = c.Count()
            }); ;
             foreach (var r1r11 in s1)
            {
                Console.WriteLine(r1r11);
            }




        }
        class Emplyee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Gender { get; set; }
            public int Salary { get; set; }
            public override string ToString()
            {
                return $"id={Id},name={Name},age={Age},Gerder={Gender},salary={Salary}";
            }
        }

        class Dog
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name +"     "+ Id;
            }
        }
    }

}