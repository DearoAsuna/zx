using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF5
{
     class OrgUnitConfig:IEntityTypeConfiguration<OrgUnit>
    {
        public void Configure(EntityTypeBuilder<OrgUnit> builder)
        {
            builder.ToTable("T_OrgUnit");
            builder.Property(o => o.Name)
                .IsUnicode().IsRequired().HasMaxLength(50);
            builder.HasOne(a => a.Parent).
                WithMany(a => a.Children);

        }
    }
}
