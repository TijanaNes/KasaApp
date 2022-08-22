using DataAccess.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context : DbContext
    {
        public DbSet<UseCase> UseCases { get; set; }
        public DbSet<Domain.Entities.Type> Types { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Employee_UseCase> Employee_UseCases { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BillDetails> BillDetailss { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<SubType> SubTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new UseCaseConfiguration());
            modelBuilder.ApplyConfiguration(new TypeConfiguration());
            modelBuilder.ApplyConfiguration(new TableConfiguration());
            modelBuilder.ApplyConfiguration(new SubTypesConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new Employee_UseCaseConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new BillDetailConfiguration());
            modelBuilder.ApplyConfiguration(new BillConfiguration());


            modelBuilder.Entity<UseCase>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Domain.Entities.Type>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Table>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<SubType>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Menu>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Employee_UseCase>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Employee>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<BillDetails>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Bill>().HasQueryFilter(x => !x.IsDeleted);



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSqlLocalDb;Initial Catalog=KasaAppTwo;Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var obj in ChangeTracker.Entries())
            {
                if (obj.Entity is EntityBase entitet)
                {
                    switch (obj.State)
                    {
                        case EntityState.Added:
                            entitet.Date_Deleted = null;
                            entitet.Date_Created = DateTime.UtcNow;
                            entitet.IsDeleted = false;
                            entitet.Date_Updated = null;
                            break;
                        case EntityState.Modified:
                            entitet.Date_Updated = DateTime.UtcNow;
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
