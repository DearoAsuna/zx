using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3
{
    public class Commnet
    {
        public long id { get; set; }
        public string Message { get; set; }
        public Article Article { get; set; }
        public int Articleid { get; set; }
        public override string ToString()
        {
            return $"id={id} message={Message} art={Article.id}";
        }
    }
}
