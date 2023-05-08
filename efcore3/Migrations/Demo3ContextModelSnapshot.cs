﻿// <auto-generated />
using EFcore3;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFcore3.Migrations
{
    [DbContext(typeof(Demo3Context))]
    partial class Demo3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFcore3.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Age")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("age")
                        .IsFixedLength();

                    b.Property<string>("Name")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("name")
                        .IsFixedLength();

                    b.Property<string>("Sex")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("sex")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.ToTable("T_Person", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
