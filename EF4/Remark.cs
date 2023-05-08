using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF4
{
    internal class Remark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Book Book { get; set; }
        public string Msg { get; set; }
    }
}
