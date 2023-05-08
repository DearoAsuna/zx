using System;
using System.Threading;
using System.Threading.Tasks;


namespace a3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { id=1,PenColor=ConsoleColor.Green};
            Student s2 = new Student() { id=2,PenColor=ConsoleColor.White};
            Student s3 = new Student() { id=3,PenColor=ConsoleColor.Yellow};
            
            Task task = new Task(new Action(s1.zzy));
            Task task1 = new Task(new Action(s2.zzy));
            Task task2 = new Task(new Action(s3.zzy));
            Console.ReadKey();
            /*            s1.zzy();
                        s2.zzy();
                        s3.zzy();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Main thread {0}",i);
                            Thread.Sleep(100);
                        }*/




        }
    }
    class Student
    {
        public int id { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void zzy()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} doing {1}",id,i);
                Thread.Sleep(1000);
            }
        }
    }
}
