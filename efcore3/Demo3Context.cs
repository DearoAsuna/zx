using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFcore3;

public partial class Demo3Context : DbContext
{

    /*private static ILoggerFactory loggerFactory = 
        LoggerFactory.Create(b => b.AddConsole());*/
    public Demo3Context()
    {
    }

    public Demo3Context(DbContextOptions<Demo3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("" +
                                    "Server=.;Data Source=LAPTOP-5AQ8PCDO\\" +
                                    "SQLEXPRESS; Database = demo3; Encrypt=True" +
                                    ";Trusted_Connection=True;TrustServerCertificate=True;");
        /*optionsBuilder.UseLoggerFactory(loggerFactory);*/
        optionsBuilder.LogTo(msg =>
        {
            if (!msg.Contains("CommandEx"))
           return;
            Console.WriteLine(msg);
        });

    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("T_Person");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Age)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("age");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("sex");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
