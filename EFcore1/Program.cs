using System.Threading.Channels;
using Microsoft.IdentityModel.Tokens;

namespace EFcore1
{
    public class Program
    {
        public static async Task Main()
        {
            using (var a= new DbContext1())
            {
                var random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    var person = new Person();
                    int c=random.Next(1,10);
                    person.name = $"smd{c}";
                    a.Persons.Add(person);
                }

                int async = await a.SaveChangesAsync();
                Console.WriteLine(async);
            }
        }

    }
}