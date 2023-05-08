using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<stu> smd = new List<stu>();
            for (int i = 0; i < 100; i++)
            {
                stu s1 = new stu();
                try
                {
                    s1.Age = 240;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
                s1.name = "smd";
                Console.WriteLine(s1.Canwork);
                smd.Add(s1);
            }
            int sumage=0;
            foreach (var sm in smd)
            {
                sumage += sm.Age;
            }
            stu.aage = sumage / stu.sum;
            stu.pa();
          
            stu.ps();
            Console.ReadKey();

        }
    }
   public class stu
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("age error");
                }
            }
        }


        public string name;
        public static int sum=0;
        public static int aage = 0;
     

        public int Mysum { get => mysum; set => mysum = value; }

        public stu()
        {
           stu.sum++;
        }
        public static void ps()  
        {
            Console.WriteLine(stu.sum);
        }
        public static void pa()
        {
            Console.WriteLine(stu.aage);
        }
        private int mysum;
        private bool canwork;

        public bool Canwork
        {
            get 
            {
                if (this.age > 16)
                    return true;
                else return false;
            }
        }




    }
}
