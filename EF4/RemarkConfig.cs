using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF4
{
    internal class RemarkConfig:IEntityTypeConfiguration<Remark>
    {
        public void Configure(EntityTypeBuilder<Remark> builder)
        {
            builder.ToTable("Remark");
        }
    }
}
