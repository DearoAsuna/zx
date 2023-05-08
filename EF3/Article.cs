using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3
{
    public class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string Message { get; set; }
        public List<Commnet> Commnets { get; set; } = new List<Commnet>();
        public override string ToString()
        {
            return $"id {id} message {Message} title {title}";
        }
    }
}
