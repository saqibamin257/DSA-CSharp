using DSA.LinqEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id)
                   .HasName("PK_Category_Id");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.HasIndex(x => x.Name)
                .HasDatabaseName("UX_Category_Name")
                .IsUnique();

            builder.HasMany(x => x.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
