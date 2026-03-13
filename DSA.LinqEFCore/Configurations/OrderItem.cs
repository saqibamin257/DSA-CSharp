using DSA.LinqEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");

            builder.HasKey(x => x.Id)
                .HasName("PK_OrderItem_Id");

            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.Property(x => x.UnitPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(x => x.TotalPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.HasOne(x => x.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => new { x.OrderId, x.ProductId })
                .HasDatabaseName("UX_OrderId_ProductId")
                .IsUnique();
        }
    }
}
