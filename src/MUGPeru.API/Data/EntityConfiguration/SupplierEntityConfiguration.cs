﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MUGPeru.API.Models;

namespace MUGPeru.API.Data.EntityConfiguration
{
    public class SupplierEntityConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.ToTable("Supplier");


            builder.HasIndex(e => e.CompanyName)
                    .HasName("IndexSupplierName");

            builder.HasIndex(e => e.Country)
                    .HasName("IndexSupplierCountry");

            builder.Property(e => e.City).HasMaxLength(40);

            builder.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40);

            builder.Property(e => e.ContactName).HasMaxLength(50);

            builder.Property(e => e.ContactTitle).HasMaxLength(40);

            builder.Property(e => e.Country).HasMaxLength(40);

            builder.Property(e => e.Fax).HasMaxLength(30);

            builder.Property(e => e.Phone).HasMaxLength(30);

        }
    }
}
