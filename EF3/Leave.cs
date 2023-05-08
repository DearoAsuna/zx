using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF3
{
    public class Leave
    {
        public int id { get; set; }
        public User? Requseter { get; set; }

        public User? Approver { get; set; }
        public string Remarks { get; set; }

    }
}
