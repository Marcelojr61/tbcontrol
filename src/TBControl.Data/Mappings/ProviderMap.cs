using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class ProviderMap : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {

            builder
                .ToTable("provider");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450)
                .IsRequired();
           
            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(45)")
                .HasMaxLength(45)
                .IsRequired();
            
            builder
                .Property(x => x.Document)
                .HasColumnName("document")
                .HasColumnType("varchar(17)")
                .HasMaxLength(17)
                .IsRequired();

            builder
                .Property(x => x.Active)
                .HasColumnName("is_active")
                .HasColumnType("bit")
                .IsRequired();

            builder
                .HasMany(x => x.PurchaseOrders)
                .WithOne(x => x.Provider);

            builder
                .HasOne(x => x.AddressProvider)
                .WithOne(x => x.Provider);

        }
    }
}
