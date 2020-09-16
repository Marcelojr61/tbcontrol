using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class TrackingMap : IEntityTypeConfiguration<Tracking>
    {
        public void Configure(EntityTypeBuilder<Tracking> builder)
        {

            builder
                .ToTable("tracking");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName("id")
                .HasColumnType("nvarchar(450)")
                .HasMaxLength(450)
                .IsRequired();

            builder
                .Property(x => x.TrackCode)
                .HasColumnName("track_code")
                .HasColumnType("varchar(60)")
                .HasMaxLength(60)
                .IsRequired();

            builder
                .HasOne(x => x.PurchaseOrder)
                .WithOne(x => x.Tracking)
                .IsRequired();
        }
    }
}
