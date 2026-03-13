using DSA.LinqEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.LinqEFCore.Configurations
{
    public class IdempotencyRequestConfiguration : IEntityTypeConfiguration<IdempotencyRequest>
    {
        public void Configure(EntityTypeBuilder<IdempotencyRequest> builder)
        {
            builder.ToTable("IdempotencyRequests");

            builder.HasKey(x => x.Id)
                .HasName("PK_IdempotencyRequest_Id");

            builder.Property(x => x.IdempotencyKey)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.RequestPath)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.Response)
                .HasColumnType("TEXT");

            builder.HasIndex(x => x.IdempotencyKey)
                .HasDatabaseName("UX_IdempotencyRequest_IdempotencyKey")
                .IsUnique();
        }
    }
}
