using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore11
{
    internal class BookConfig:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("T_Book");
            builder.HasOne(a => a.Person)
                .WithMany(a => a.Books);
        }
    }
}
