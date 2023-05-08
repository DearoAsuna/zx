using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<ulong> student = new Student<ulong>();
            student.Name = "smd";
            student.Id = 100000000001;
        }
    }

    interface IUnque<TId>
    {
        TId Id { get; set; }
    }

    class Student<TId>: IUnque<TId>
    {
       public TId Id { get; set; }
       public string  Name { get; set; }
    }

    
}
