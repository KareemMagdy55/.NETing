using Microsoft.EntityFrameworkCore;
using WebApplication1.Entities.Models;

namespace WebApplication1.Data_Access.context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {
        }
       
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        
        

    }
}
