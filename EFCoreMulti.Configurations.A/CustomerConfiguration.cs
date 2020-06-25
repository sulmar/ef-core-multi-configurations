using EFCoreMulti.Infrastucture.Configurations;
using EFCoreMulti.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EFCoreMulti.Configurations.A
{
    public class CustomerConfiguration : CustomerConfigurationBase, IEntityTypeConfiguration<Customer>
    {
    }
}
