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
    public class UseCaseConfiguration : EntityBaseConfiguration<UseCase>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<UseCase> builder)
        {
            builder.HasIndex(x => x.Name).IsUnique();
            builder.HasIndex(x => x.UseCaseIdentifier).IsUnique();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UseCaseIdentifier).IsRequired();

            builder.HasMany(x => x.User_UseCases).WithOne(x => x.UseCase).HasForeignKey(x => x.UseCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
