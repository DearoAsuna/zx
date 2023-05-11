using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiInterfers;

namespace Service
{
    public class Micro1:IMicroPhone
    {
        public Micro1()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
