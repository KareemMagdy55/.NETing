using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models;

// POCO class 
// Plain old CLR objects 

// a class that is not linked with any frameworks or technologies 
// src: first response on this post https://stackoverflow.com/questions/250001/poco-definition
public class Employee {
    public int ID { get; set; }
    public string Name { get; set; }
    [EmailAddress]
    public string EmailAddress { get; set; }

    // Entity framework will replace Dept with deptID
    // public int DeptID { get; set; }
    public virtual Department Dept { get; set; }

    // Many to many relationship
    public virtual ICollection<Course> Courses { get; set; }

    public Employee() {
        Courses = new HashSet<Course>();
    }
}

// Table created by EF core

// CREATE TABLE [Employees] (
//     [ID] int NOT NULL IDENTITY,
// [Name] nvarchar(max) NOT NULL,
// [DeptID] int NOT NULL,
// CONSTRAINT [PK_Employees] PRIMARY KEY ([ID]),
// CONSTRAINT [FK_Employees_Departments_DeptID] FOREIGN KEY ([DeptID]) REFERENCES [Departments] ([ID]) ON DELETE CASCADE
//     );