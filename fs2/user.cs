using System;

namespace fs2
{
    public class user
    {
        public user(string name, string age)
        {
            this.name = name;
            this.age = age;
        }

        public string name { get; set; }
        public string age { get; set; }

        public void Say()
        {
            Console.WriteLine($"name {name} age {age}");
        }

    }
}
