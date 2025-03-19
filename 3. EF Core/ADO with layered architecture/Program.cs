using ADOUsageExample.Bussines_Logic;

public class Trial {
    public static void Main() {
        var lst = EmployeeManager.SelectAllEmployeesDT();

        lst.Rows[0]["FirstName"] = "Mohammed";
        EmployeeManager.Update();

        lst = EmployeeManager.SelectAllEmployeesDT();

        Console.WriteLine(lst.Rows[0]["FirstName"]);

    }
}