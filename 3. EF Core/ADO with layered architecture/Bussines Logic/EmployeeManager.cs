using System.Data;
using ADOUsageExample.Data_Access;
using ADOUsageExample.Entities;

namespace ADOUsageExample.Bussines_Logic;

public class EmployeeManager {
    static DBManager dbManager = new DBManager();

    public static List<Employee> SelectAllEmployees() {
        try {
            return DataTableToEmployeesList(dbManager.ExecuteDataTable("Select * from Employees"));
        }
        catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    public static DataTable SelectAllEmployeesDT() {
        try {
            return dbManager.ExecuteDataTable("Select * from Employees");
        }
        catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }
    internal static List<Employee> DataTableToEmployeesList(DataTable Dt) {
        try {
            List<Employee> employees = new List<Employee>();
            if (Dt?.Rows?.Count > 0)
                foreach (DataRow row in Dt.Rows) {
                    employees.Add(DataRowToEmployee(row));
                }

            return employees;
        }
        catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    internal static Employee DataRowToEmployee(DataRow dr) {
        try {
            // Mapping 

            Employee employee = new Employee();

            employee.EmployeeID = dr.Field<int>("EmployeeID");
            employee.LastName = dr.Field<string>("LastName");
            employee.FirstName = dr.Field<string>("FirstName");
            employee.Title = dr.Field<string>("Title");
            employee.TitleOfCourtesy = dr.Field<string>("TitleOfCourtesy");
            employee.BirthDate = dr.Field<DateTime>("BirthDate");
            employee.HireDate = dr.Field<DateTime>("HireDate");
            employee.Address = dr.Field<string>("Address");
            employee.City = dr.Field<string>("City");
            employee.Region = dr.Field<string>("Region");
            employee.PostalCode = dr.Field<string>("PostalCode");
            employee.Country = dr.Field<string>("Country");
            employee.HomePhone = dr.Field<string>("HomePhone");
            employee.Extension = dr.Field<string>("Extension");
            employee.Photo = dr.Field<byte[]>("Photo");
            employee.Notes = dr.Field<string>("Notes");
            employee.ReportsTo = dr.Field<int?>("ReportsTo"); // Nullable int
            employee.PhotoPath = dr.Field<string>("PhotoPath");

            return employee;
        }
        catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    public static void Update() => dbManager.Update();
}