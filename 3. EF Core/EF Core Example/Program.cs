using EntityFramework.Context;
using EntityFramework.Models;



public class Program {

    public static void Main() {
        using EnterpriseContext context = new EnterpriseContext();
        //context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        Department D01 = new Department() { Name = "Deployment" };
        Department D02 = new Department() { Name = "Marketing" };

        // context.Departments.Add(D01); // Valid
        // context.Add(D01); // Valid 
        // context.Departments.Local // Will access the values which are currently in memory

        // var Results = context.Departments.Where(D => D.Name.StartsWith("Dep"));
        // foreach (var department in Results) {
        //     department.Name = "Launching";
        // }
        //
        //
        // context.SaveChanges();
        //
        // Results = context.Departments.Where(D => D.Name == "Launching");
        // foreach (var department in Results) {
        //     Console.WriteLine(department.Name);
        // }
        //
        // context.Departments.Remove(context.Departments.First());
        Employee employee = new Employee() { Name = "Ahmed", Dept = D01, EmailAddress = "lkjfd;lkjaf" };
        context.Add(employee);

        Course course1 = new Course() {  Duration = 9, Title = "Intro to C#",  URL = "www.cs.com" };
        context.Add(course1);
            
        // If we change course entity's attrubitues without delete the prev database
        // the CLR fires expection of 'missing column'
        // Two solutions: Edit database or Migrate
        context.SaveChanges();
    }
}
