using System.Text;

namespace Lab1.Task6;

class Club {
    public int ClubID { get; set; }
    public String ClubName { get; set; }
    List<Employee> Members = new List<Employee>();

    public void AddMember(Employee emp) {
            Console.WriteLine(emp + $" Added to the club {ClubName}");
            Members.Append(emp);
    }

    ///CallBackMethod
    public void RemoveMember(object? sender, EmployeeLayOffEventArgs? e) {
        if (sender is Employee emp && e is not null) {
            Console.WriteLine(emp + $" Removed from Club {ClubName}");
            Members.Remove(emp);
        }
    }
    
    
    public string Content() {
        // Here string builder usage is better than string usage
        // because string is immutable datatype,
        // so each append a new object in memory will be created 
        StringBuilder str = new StringBuilder();
        // str.Append("Hello");

        foreach (var ele in Members) 
            str.Append(Convert.ToString(ele.EmployeeID)).Append(", ");
        // Console.WriteLine(ele.EmployeeID);


        return str.ToString();
    }

}