using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stu stu = null;
            bool v = Stuf.Create("smd", 21,out stu);
            if (v==true)
            {
                Console.WriteLine(stu.age+stu.name);
            }
            Console.ReadKey();

        }
    }
    class Stu
    {
        public int age { get; set; }
        public string  name { get; set; }
    }
    class Stuf
    {
        public   static bool Create(string stuName,int stuAge,out Stu result)
        {
            result = null;
            if(string.IsNullOrEmpty(stuName))
            {
                return false;
            }
            if (stuAge<20||stuAge>80)
            {
                return false;
            }
            result = new Stu() { name = stuName, age = stuAge };
            return true;

        }
    }
}
