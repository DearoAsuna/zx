using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF4
{
    internal class MyDbcontext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Remark> Remarks  { get; set; }


        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connSet = "Server=.;Data Source=LAPTOP-5AQ8PCDO\\SQLEXPRESS; " +
                             "Database = demo5;" +
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
