﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class AddressClientMap : IEntityTypeConfiguration<AddressClient>
    {
        public void Configure(EntityTypeBuilder<AddressClient> builder)
        {
            builder
                .ToTable("address_client");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("guid")
                .IsRequired();

            builder
                .Property(x => x.StreetAddress)
                .HasColumnName("street_address")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(x => x.Number)
                .HasColumnName("number")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.Complement)
                .HasColumnName("complement")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder
                .Property(x => x.City)
                .HasColumnName("city")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(x => x.State)
                .HasColumnName("state")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(x => x.UF)
                .HasColumnName("uf")
                .HasColumnType("varchar(2)")
                .HasMaxLength(2)
                .IsRequired();

            builder
                .Property(x => x.Country)
                .HasColumnName("country")
                .HasColumnType("varchar(16)")
                .HasMaxLength(16)
                .IsRequired();

            builder
                .Property(x => x.ZipeCode)
                .HasColumnName("zip_code")
                .HasColumnType("int")
                .HasMaxLength(8)
                .IsRequired();

            builder
                .HasOne(x => x.Client)
                .WithOne(x => x.AddressClient);
        }
    }
}
