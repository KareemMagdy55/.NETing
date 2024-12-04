using System.Configuration;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace EntityFramework.Context;

public class EnterpriseContext  : DbContext{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("data source=.;Initial Catalog=EnterpriseDB;integrated Security=true;TrustServerCertificate=True");

    public virtual DbSet<Employee > Employees { get; set; }
    public virtual DbSet<Department> Departments { get; set; }
}