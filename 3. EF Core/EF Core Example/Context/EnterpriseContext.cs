using System.ComponentModel.DataAnnotations;
using System.Configuration;
using EntityFramework.FluentAPIConfigurations;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Context;



// Mapping techniques 
// 1. Automatically mapped (put DbSet<Class> in Context)
// 2. DataAnnotations to customize mapping.
public class EnterpriseContext  : DbContext{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("data source=.;Initial Catalog=EnterpriseDB;integrated Security=true;TrustServerCertificate=True");


    // SaveChanges should be overriden to validate data in runtime (before sending changes)
    public override int SaveChanges() {
        var entities = ChangeTracker.Entries().Select(e => e).Where(e => e.State is EntityState.Added or EntityState.Modified);
        
        foreach (var e in entities) {
            Validator.ValidateObject(e, new ValidationContext(e), true );
        }
        return base.SaveChanges();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
    }

    public virtual DbSet<Employee > Employees { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
    public virtual DbSet<Course> Courses { get; set; }
}