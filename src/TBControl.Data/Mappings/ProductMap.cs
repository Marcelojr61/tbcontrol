using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .ToTable("product");

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
                .HasColumnType("Varchar(30)")
                .HasMaxLength(30)
                .IsRequired();


            builder
                .Property(x => x.Description)
                .HasColumnName("description")
                .HasColumnType("Varchar(150)")
                .HasMaxLength(150)
                .IsRequired();


            builder
                .Property(x => x.ModelProduct)
                .HasColumnName("modelproduct")
                .HasColumnType("Varchar(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder
                .Property(x => x.Color)
                .HasColumnName("color")
                .HasColumnType("Varchar(10)")
                .HasMaxLength(10)
                .IsRequired();


            builder
                .Property(x => x.Brand) 
                .HasColumnName("brand")
                .HasColumnType("Varchar(16)")
                .HasMaxLength(16)
                .IsRequired();

            builder
                .Property(x => x.Category)
                .HasColumnName("category")
                .HasColumnType("Varchar(16)")
                .HasMaxLength(16)
                .IsRequired();


            builder
                .Property(x => x.SerialNumber)
                .HasColumnName("serial_number")
                .HasColumnType("Varchar(45)")
                .HasMaxLength(45)
                .IsRequired();

            builder
                .Property(x => x.Quantity)
                .HasColumnName("quantity")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.Cost)
                .HasColumnName("cost")
                .HasColumnType("decimal")
                .IsRequired();

            builder
                .Property(x => x.Price)
                .HasColumnName("price")
                .HasColumnType("decimal")
                .IsRequired();

            builder
                .Property(x => x.Image)
                .HasColumnName("image")
                .HasColumnType("varbinary(255)")
                .HasMaxLength(255)
                .IsRequired();


            builder
                .HasOne(x => x.OrderedItem)
                .WithMany(x => x.Products);

        }
    }
}
