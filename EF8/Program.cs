using Microsoft.EntityFrameworkCore;

namespace EF8
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var myDbcontext = new MyDbcontext())
            {
                #region add

                /*var student = new Student() { Name = "smd1" };
                var student1 = new Student() { Name = "smd2" };
                var student2 = new Student() { Name = "smd3" };

                var teacher = new Teacher() { Name = "菜狗" };
                var teacher1 = new Teacher() { Name = "菜狗11" };

                student.Teachers.Add(teacher1);
                student.Teachers.Add(teacher);
                student1.Teachers.Add(teacher1);
                student2.Teachers.Add(teacher);

                myDbcontext.Students.Add(student);
                myDbcontext.Students.Add(student1);
                myDbcontext.Students.Add(student2);

                var async = await myDbcontext.SaveChangesAsync();
                Console.WriteLine(async);*/

                #endregion

                #region select

                var queryable = myDbcontext.Students
                    .Include(a => a.Teachers);
                foreach (var i in queryable)
                {
                    Console.WriteLine(i.Name);
                    foreach (var i1 in i.Teachers)
                    {
                        Console.WriteLine("\t"+i1.Name);
                    }
                }

                #endregion
            }

        }
    }
}