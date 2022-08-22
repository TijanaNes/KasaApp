using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class TypeConfiguration : EntityBaseConfiguration<Domain.Entities.Type>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<Domain.Entities.Type> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);

            builder.HasMany(x => x.SubTypes).WithOne(x => x.Type).HasForeignKey(x => x.TypeId).OnDelete(Microsoft.EntityFrameworkCore.DeleteBehavior.Restrict);
        }
    }
}
