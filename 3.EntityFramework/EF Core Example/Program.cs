using EntityFramework.Context;
using EntityFramework.Models;



public class Program {

    public static void Main() {
        using (EnterpriseContext context = new EnterpriseContext()) {

            context.Database.EnsureCreated(); 
            Department D01 = new Department() { Name = "Deployment" };
            Department D02 = new Department() { Name = "Marketing" };

            // context.Departments.Add(D01); // Valid
            // context.Add(D01); // Valid 
            // context.Departments.Local // Will access the values which are currently in memory

            var Results = context.Departments.Where(D => D.Name.StartsWith("Dep"));
            foreach (var department in Results) {
                department.Name = "Launching";
            }
            
            
            context.SaveChanges();
            
            Results = context.Departments.Where(D => D.Name == "Launching");
            foreach (var department in Results) {
                Console.WriteLine(department.Name);
            }

            context.Departments.Remove(context.Departments.First());
            context.SaveChanges();
        }
    }
}
