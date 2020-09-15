using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class FormOfPaymentMap : IEntityTypeConfiguration<FormOfPayment>
    {
        public void Configure(EntityTypeBuilder<FormOfPayment> builder)
        {
            builder
                .ToTable("form_of_payment");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("guid")
                .IsRequired();

            builder
                .Property(x => x.Type)
                .HasColumnName("type")
                .HasColumnType("Varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder
                .HasOne(x => x.InstallmentType)
                .WithMany(x => x.FormOfPayments)
                .HasForeignKey(x => x.InstallmentTypeId)
                .IsRequired();

            builder
                .HasMany(x => x.SalesOrders)
                .WithOne(x => x.FormOfPayment);


        }
    }
}
