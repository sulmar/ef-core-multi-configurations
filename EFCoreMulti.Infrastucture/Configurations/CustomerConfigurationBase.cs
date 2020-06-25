using EFCoreMulti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreMulti.Infrastucture.Configurations
{
    public abstract class CustomerConfigurationBase : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(p => p.Id).HasColumnName("CustomerId");

            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);

            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);
        }
    }
}
