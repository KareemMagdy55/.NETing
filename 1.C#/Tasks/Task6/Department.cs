using System.Text;

namespace Lab1.Task6;

class Department {
    public int DeptID { get; set; }
    public string DeptName { get; set; }

    List<Employee> Staff = new List<Employee>();

    public void AddStaff(Employee emp) {
        Console.WriteLine(emp + $" Added to the department {DeptName}");
        Staff.Append(emp);
    }

    ///CallBackMethod
    public void RemoveStaff(object? sender, EmployeeLayOffEventArgs? e) {
        if (sender is Employee emp && e is not null) {
            Console.WriteLine(emp + $" Removed from department {DeptName}");
            Staff.Remove(emp);
        }
    }

    public string Content() {
        // Here string builder usage is better than string usage
        // because string is immutable datatype,
        // so each append a new object in memory will be created 
        StringBuilder str = new StringBuilder();
        // str.Append("Hello");

        foreach (var ele in Staff)
            str.Append(Convert.ToString(ele.EmployeeID)).Append(", ");
        // Console.WriteLine(ele.EmployeeID);


        return str.ToString();
    }
}