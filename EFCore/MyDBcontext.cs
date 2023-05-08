using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace EFCore
{
    public class MyDBcontext:DbContext
    {
        public DbSet<Rabbit> Rabbit { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Person> Person{ get; set; }

        public DbSet<Bird> Birds { get; set; }
        public DbSet<Cat> Cat { get; set; }

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connSet = "Server=.;Data Source=LAPTOP-5AQ8PCDO\\SQLEXPRESS; Database = demo1;" +
                             "Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer (connSet);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}