using System.ComponentModel.DataAnnotations;

namespace FirstStepIntoMVC.Models;

public class Student{
    [Required, MaxLength(50)]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string Name { get; set; }
    
    [MaxLength(4)]
    public string Grade { get; set; }
}