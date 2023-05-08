using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7
{
    internal class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("T_Order");
            builder.HasOne(a => a.Delivery)
                .WithOne(a => a.Order)
                .HasForeignKey<Delivery>(a=>a.OrderId).IsRequired();
        }

      
    }
}
