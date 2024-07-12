namespace ITI_Tasks.Lab2;

public class MainClass {
    public static void Main() {
        Employee[] employees = new Employee[3];
        
        // ReSharper disable once InvalidXmlDocComment
        /// <summary>
        /// HELLO THERE!</summary>
        /// <param name="id">The unique identifier of the employee.</param>
        ///   /// <param name="securityLevel">The security level of the employee.</param>
        /// <param name="hiringDate">The date when the employee was hired.</param>
        /// <param name="salary">The salary of the employee.</param>

        employees[0] = new Employee(1, SecurityLevel.DBA, new HiringDate(9, 5, 2003), 23000);
        employees[1] = new Employee(2, SecurityLevel.GUEST, new HiringDate(9, 6, 1995), 23000);
        employees[2] = new Employee(3, 
            SecurityLevel.DBA | SecurityLevel.SECERTARY | SecurityLevel.DEVELOPER | SecurityLevel.GUEST, 
            new HiringDate(9, 7, 2003), 23000);
        
        Array.Sort(employees, (emp1, emp2) => emp1.HiringDate.CompareTo(emp2.HiringDate));

        foreach (var emp in employees) {
            Console.WriteLine(emp.ToString());
        }
    }
}