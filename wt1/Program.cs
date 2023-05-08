using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wt1
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new MyDele(M1);
            d1 += (new Student().SayHello);
            var myDeleAdd = new MyDeleAdd(Add);
            var deleAdd = myDeleAdd(1, 2);
            Console.WriteLine(deleAdd);


            d1();
        }

        static void M1()
        {
            Console.WriteLine("smd?");
        }
        static void M2()
        {
            Console.WriteLine("smd?");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Student
    {
        public void SayHello()
        {
            Console.WriteLine("Hello smd!");
        }
    }

    delegate void MyDele();

    delegate int MyDeleAdd(int x,int y);

}
