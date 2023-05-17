using System;

namespace EFCore11
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book>? Books { get; set; }=new();
    }
}
