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
    public class Employee_UseCaseConfiguration : EntityBaseConfiguration<Employee_UseCase>
    {
        public override void SpecificEntityConfiguration(EntityTypeBuilder<Employee_UseCase> builder)
        {
            builder.HasOne(x => x.User).WithMany(x => x.User_UseCases).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.UseCase).WithMany(x => x.User_UseCases).HasForeignKey(x => x.UseCaseId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
