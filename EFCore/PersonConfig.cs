using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore
{
    internal class PersonConfig:IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("T_Person");
            builder.Property(a => a.Name2).
                HasColumnName("nametwo").HasColumnType("varchar(8)");
            builder.Property(a => a.Name).IsRequired();
        }
        
    }
}
