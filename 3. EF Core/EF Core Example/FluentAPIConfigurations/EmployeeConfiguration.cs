using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.FluentAPIConfigurations
{

    // That is the 4th way of mapping your classes into SQL tables it is the "Fluent API configuration method"
    // See the way it being used in Context class
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            builder.HasMany(e => e.Courses);
            builder.Property(e => e.EmailAddress).HasAnnotation("EmailAddress", null);

          // builder.HasMany(e => e.Courses)
          //.WithOne(c => c.Title) 
          //.HasForeignKey(c => c.EmployeeId) 
          //.OnDelete(DeleteBehavior.Cascade); 

        }
    }
}
