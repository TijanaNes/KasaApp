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
    public class BillConfiguration : EntityBaseConfiguration<Bill>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<Bill> builder)
        {

            builder.Property(x => x.BillOpened).IsRequired();
            builder.Property(x => x.WeiterId).IsRequired();

            builder.HasMany(x => x.BillDetails).WithOne(x => x.Bill).HasForeignKey(x => x.BillId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Table).WithMany(x => x.Bills).HasForeignKey(x => x.TableId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Weiter).WithMany(x => x.Bills).HasForeignKey(x => x.WeiterId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
