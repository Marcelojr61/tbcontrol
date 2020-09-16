using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class SalesOrderMap : IEntityTypeConfiguration<SalesOrder>
    {
        public void Configure(EntityTypeBuilder<SalesOrder> builder)
        {

            builder
                .ToTable("sales_order");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450)
                .IsRequired();

            builder
                .Property(x => x.Rebate)
                .HasColumnName("rebate")
                .HasColumnType("decimal");

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
                .WithOne(x => x.SalesOrder)
                .IsRequired();

            builder
                .HasOne(x => x.FormOfPayment)
                .WithMany(x => x.SalesOrders)
                .HasForeignKey(x => x.FormOfPaymentId)
                .IsRequired();

            builder
                .HasOne(x => x.Client)
                .WithMany(x => x.SalesOrders)
                .HasForeignKey(x => x.ClientId)
                .IsRequired();
        }
    }
}
