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
    public virtual ICollection<Employee> Employees { get; set; }

    public  Course() {
        Employees = new HashSet<Employee>();
    }
}