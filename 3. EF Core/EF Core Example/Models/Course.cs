using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

public class Course {
    
    // Data Annotations for CLR to detect some properties (Primary key, foreign keys,....)
    [Key] // => primary key
    public int ID { get; set; }
    
    [Required] // -> not null
    [MaxLength(50)]
    public string Title { get; set; }
    
    [Column(TypeName = "int")]  
    public short Duration { get; set; }
    
    [Url]
    public string URL { get; set; }
    
    // Why virtual 
        // EF Core creates proxy classes to handle relationships between objects in .NET and the database.
        // which leads to that EF triggers a query to load related data when it is accessed (lazy loading).
        
    public virtual ICollection<Employee> Employees { get; set; }

    public  Course() {
        Employees = new HashSet<Employee>();
    }
}