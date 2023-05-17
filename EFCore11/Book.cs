using System;

namespace EFCore11
{
   public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public DateTime DateTime { get; set; }
        public double Price { get; set; }

        public Person? Person { get; set; }
    }
}
