using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace EFcore3
{
    public class Program 
    {
        public static async Task Main()
        {
            using (var d =new Demo3Context())
            {
                #region 加入值

                /*var person = new Person();
              person.Age = "12";
              person.Name = "dj";
              person.Sex = "男";
              d.People.Add(person);
              var i = await  d.SaveChangesAsync();
              Console.WriteLine(i);*/

                #endregion

                var queryable = d.People.Where(a => a.Name.Contains("s"));
                var queryString = queryable.ToQueryString();
                Console.WriteLine(queryString);
                foreach (var person in queryable)
                {
                    Console.WriteLine(person.ToString());
                    
                }

                /*
                d.People.Add(new Person
                    {
                    Age = "15",
                    Name="snd",
                    Sex = "man"
                    });
               await  d.SaveChangesAsync(); 
               */
               // Console.WriteLine(d.People.Count());
            }

           
        }
    }
}
