using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class PurchaseOrderMap : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
        {

            builder
                .ToTable("purchase_order");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450)
                .IsRequired();

            builder
                .Property(x => x.DeliveryFee)
                .HasColumnName("delivery_fee")
                .HasColumnType("decimal")
                .IsRequired();

            builder
                .Property(x => x.Quantity)
                .HasColumnName("quantity")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.OrderTotal)
                .HasColumnName("order_total")
                .HasColumnType("decimal")
                .IsRequired();

            builder
                .Property(x => x.Subtotal)
                .HasColumnName("subtotal")
                .HasColumnType("decimal")
                .IsRequired();

            builder
                .HasOne(x => x.OrderedItem)
                .WithOne(x => x.PurchaseOrder)
                .IsRequired();

            builder
                .HasOne(x => x.Tracking)
                .WithOne(x => x.PurchaseOrder)
                .IsRequired();

            builder
                .HasOne(x => x.Provider)
                .WithMany(x => x.PurchaseOrders)
                .HasForeignKey(x => x.ProviderId)
                .IsRequired();
                
        }
    }
}
