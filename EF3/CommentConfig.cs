using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF3
{
    public class CommentConfig:IEntityTypeConfiguration<Commnet>
    {
        public void Configure(EntityTypeBuilder<Commnet> builder)
        {
            builder.ToTable("T_Comment");
            builder.HasOne(a => a.Article)
                .WithMany(a => a.Commnets).
                HasForeignKey(a => a.Articleid).IsRequired();
            builder.Property(c => c.Message).IsRequired();
        }
    }
}
