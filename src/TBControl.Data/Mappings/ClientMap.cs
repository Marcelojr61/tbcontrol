using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .ToTable("client");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("guid")
                .IsRequired();

            builder
                .Property(x => x.Name)
                .HasColumnName("name")
                .HasColumnType("varchar(45)")
                .HasMaxLength(45)
                .IsRequired();

            builder
                .Property(x => x.CPF)
                .HasColumnName("cpf")
                .HasColumnType("varchar(11)")
                .HasMaxLength(11)
                .IsRequired();

            builder
              .Property(x => x.Brithday)
              .HasColumnName("brithday")
              .HasColumnType("datetime");

            builder
             .Property(x => x.RegistrationDate)
             .HasColumnName("registration_date")
             .HasColumnType("datetime")
             .IsRequired();


            builder
              .Property(x => x.Active)
              .HasColumnName("is_active")
              .HasColumnType("bit")
              .IsRequired();

            builder
             .HasOne(x => x.AddressClient)
             .WithOne(x => x.Client)
             .IsRequired();

        }
    }
}
