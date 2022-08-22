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
    public class BillDetailConfiguration : EntityBaseConfiguration<BillDetails>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<BillDetails> builder)
        {
            builder.Property(x => x.Amount).IsRequired();

            builder.HasOne(x => x.Bill).WithMany(x => x.BillDetails).HasForeignKey(x => x.BillId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Menu).WithMany(x => x.BillDetails).HasForeignKey(x => x.MenuId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
