using System;
using Microsoft.EntityFrameworkCore;

namespace EF3
{
    public class MyDbcontext:DbContext
    {
        public DbSet<Commnet> Commnets { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Leave> Leaves{ get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connSet = "Server=.;Data Source=LAPTOP-5AQ8PCDO\\SQLEXPRESS; Database = demo4;" +
                             "Encrypt=True;Trusted_Connection=True;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connSet);
            optionsBuilder.LogTo(a =>
            {
                if (!a.Contains("CommandEx"))
                    return;
                Console.WriteLine(a);
            });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
