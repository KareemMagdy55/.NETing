using Tasks.Lab2;

namespace Lab1;

class EmployeeSearch {
    private int[] NationalIDs;
    private Employee[] Employees;
    

    public object this[String name] {
        get {
            List<Employee> emps = new List<Employee>(); 
            foreach (var emp in Employees) {
                if (emp.Name == name)
                    emps.Add(emp);
            }

            return emps.Count != 0 ? emps: "Employee not found" ;
        }
    }

    public object this[HiringDate hiringDate] {
        get {
            List<Employee> emps = new List<Employee>(); 
            foreach (var emp in Employees) {
                if (emp.HiringDate.Equals(hiringDate))
                    emps.Add(emp);
            }

            return emps.Count != 0 ? emps: "Employee not found" ;
        }
    }
    public object this[int ID] {
        get {
            List<Employee> emps = new List<Employee>(); 
            foreach (var emp in Employees) {
                if (emp.NationalID.Equals(ID))
                    emps.Add(emp);
            }

            return emps.Count != 0 ? emps: "Employee not found" ;
        }
    }
    
}