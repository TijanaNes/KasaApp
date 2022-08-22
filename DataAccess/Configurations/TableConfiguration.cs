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
    public class TableConfiguration : EntityBaseConfiguration<Table>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<Table> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);

            builder.HasMany(x => x.Bills).WithOne(x => x.Table).HasForeignKey(x => x.TableId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
