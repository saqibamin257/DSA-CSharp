using DSA.LinqEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Configurations
{
    public class CustomerConfiguration:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(x => x.Id)
                   .HasName("PK_Customer_Id");

            builder.Property(x => x.FirstName)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.LastName)
                   .HasMaxLength(50);

            builder.Property(x => x.Email)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasIndex(x => x.Email)
                   .HasDatabaseName("UX_Customer_Email")
                   .IsUnique();

            builder.Property(x => x.City)
                   .HasMaxLength(200);

            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("GETUTCDATE()")
                .ValueGeneratedOnAdd();

            builder.Property(x => x.IsActive)
            .HasDefaultValue(true);

            builder.HasMany(x => x.Orders)
                .WithOne(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
