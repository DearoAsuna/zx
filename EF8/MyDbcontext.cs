using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF8
{
    internal class MyDbcontext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            base.OnConfiguring(optionsBuilder);
            string connSet = "Server=.;Data Source=LAPTOP-5AQ8PCDO\\SQLEXPRESS; " +
                             "Database = demo8;" +
                             "Encrypt=True;Trusted_Connection=True;" +
                             "TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connSet);
            optionsBuilder.LogTo(a =>
            {
                if (!a.Contains("CommandEx"))
                    return;
                Console.WriteLine(a);
            });
        }
    }
}
