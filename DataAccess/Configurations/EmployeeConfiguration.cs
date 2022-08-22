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
    public class EmployeeConfiguration : EntityBaseConfiguration<Employee>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<Employee> builder)
        {
            builder.HasIndex(x => x.EmailAddress).IsUnique();
            builder.HasIndex(x => x.UserName).IsUnique();

            builder.Property(x => x.EmailAddress).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(40);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(40);
            builder.Property(x => x.Active).HasDefaultValue(false);

            builder.HasMany(x => x.User_UseCases).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.Bills).WithOne(x => x.Weiter).HasForeignKey(x => x.WeiterId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
