using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class InstallmentTypeMap : IEntityTypeConfiguration<InstallmentType>
    {
        public void Configure(EntityTypeBuilder<InstallmentType> builder)
        {
            builder
                .ToTable("installment_type");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450)
                .IsRequired();

            builder
                .Property(x => x.Interest)
                .HasColumnName("interest")
                .HasColumnType("decimal")
                .IsRequired();


            builder
                .Property(x => x.Modality)
                .HasColumnName("modality")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10)
                .IsRequired();

            builder
                .HasMany(x => x.FormOfPayments)
                .WithOne(x => x.InstallmentType);
        }
    }
}
