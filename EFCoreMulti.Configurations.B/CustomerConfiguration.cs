using EFCoreMulti.Infrastucture.Configurations;
using EFCoreMulti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EFCoreMulti.Configurations.B
{
    public class CustomerConfiguration : CustomerConfigurationBase, IEntityTypeConfiguration<Customer>
    {
        public new void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);

            builder.Ignore(p => p.Growth);
        }
    }
}
