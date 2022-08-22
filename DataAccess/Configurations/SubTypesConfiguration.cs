using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class SubTypesConfiguration : EntityBaseConfiguration<SubType>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<SubType> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);

            builder.HasMany(x => x.Menus).WithOne(x => x.SubType).HasForeignKey(x => x.SubTypeId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Type).WithMany(x => x.SubTypes).HasForeignKey(x => x.TypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
