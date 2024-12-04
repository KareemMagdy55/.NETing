namespace EntityFramework.Models;


// Entity framework ⇒ each class (entity) must have a primary key.
public class Department {
    public int ID { get; set; }
    public string Name { get; set; }
    
    public virtual ICollection<Employee> Employees { get; set; }

    public Department() {
        Employees = new HashSet<Employee>();
    }

    public override string ToString() {
        return $"ID {ID}, Name {Name}";
    }
}
// Table create by EF core 
// CREATE TABLE [Departments] (
//     [ID] int NOT NULL IDENTITY,
//     [Name] nvarchar(max) NOT NULL,
//     CONSTRAINT [PK_Departments] PRIMARY KEY ([ID])
//     );