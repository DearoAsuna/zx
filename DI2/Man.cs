using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI2
{
    internal class Man:IPerson
    {
        public string msg;

        public Man()
        {
            this.msg = "smd";
        }
        public void Say()
        {
            Console.WriteLine($"my name {msg}");
        }

    }
}
