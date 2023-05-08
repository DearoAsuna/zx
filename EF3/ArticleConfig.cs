using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF3
{
    internal class ArticleConfig:IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("T_Article");
            /*builder.HasMany(a => a.Commnets)
                .WithOne(a => a.Article)
                .HasForeignKey(a => a.Articleid).IsRequired();*/

            builder.Property(a => a.title)
                .IsUnicode().HasMaxLength(255);
        }
    }
}
