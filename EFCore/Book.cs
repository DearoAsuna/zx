using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class Book
    {
        public long Id { get; set; }
        public DateTime PubTime { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string AuthorName { get; set; }
        public int Age { get; set; }
        public int Age1 { get; set; }
        public override string ToString()
        {
            return $"id={Id} PubTime={PubTime} " +
                   $"title={Title} Price={Price} AuthorName={AuthorName}";
        }
    }
}
