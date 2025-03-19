using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Entities.Models;

public class Course {
    public int ID { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Column(TypeName = "TEXT")] // handling very long text case
    public string Description { get; set; } = string.Empty;
}