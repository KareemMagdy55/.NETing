using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entities.Models;

public class Student 
{
    public int ID { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(255)]
    public string EmailAddress { get; set; }

    // Why virtual 
    // EF Core creates proxy classes to handle relationships between objects in .NET and the database.
    // , which leads to that EF triggers a query to load related data when it is accessed (lazy loading).

    public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();

}