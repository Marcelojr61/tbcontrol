using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class OrderedItemMap : IEntityTypeConfiguration<OrderedItem>
    {
        public void Configure(EntityTypeBuilder<OrderedItem> builder)
        {
            builder
                .ToTable("ordered_item");

            builder
                .HasKey(x => x.Id);

            builder
               .Property(x => x.Id)
               .HasColumnName("id")
               .HasColumnType("nvarchar(450)")
               .HasMaxLength(450)
               .IsRequired();

            builder
                .HasOne(x => x.PurchaseOrder)
                .WithOne(x => x.OrderedItem);

            builder
                .HasOne(x => x.SalesOrder)
                .WithOne(x => x.OrderedItem);

            builder
                .HasMany(x => x.Products)
                .WithOne(x => x.OrderedItem);

        }
    }
}
