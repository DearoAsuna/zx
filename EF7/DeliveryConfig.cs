using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF7
{
    internal class DeliveryConfig:IEntityTypeConfiguration<Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.ToTable("T_Deliver");
            builder.HasOne(a => a.Order).
            WithOne(a => a.Delivery).
            HasForeignKey<Order>(a => a.DeliveryId).IsRequired();
        }
    }
}
