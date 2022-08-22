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
    public class MenuConfiguration : EntityBaseConfiguration<Menu>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<Menu> builder)
        {

            builder.HasIndex(x => x.Name).IsUnique();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.SubTypeId).IsRequired();
            builder.Property(x => x.PictureSrc).IsRequired().HasMaxLength(255);

            builder.HasMany(x => x.BillDetails).WithOne(x => x.Menu).HasForeignKey(x => x.MenuId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.SubType).WithMany(x => x.Menus).HasForeignKey(x => x.SubTypeId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
