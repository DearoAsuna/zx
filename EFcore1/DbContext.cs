using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFcore1
{
    public class DbContext1:DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connSet = "Server=.;Data Source=LAPTOP-5AQ8PCDO\\SQLEXPRESS; Database = demo2;" +
                             "Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connSet);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }

    
}
