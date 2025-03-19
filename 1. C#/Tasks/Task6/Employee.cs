namespace Lab1.Task6;

class Employee {
    public event EventHandler<EmployeeLayOffEventArgs?> EmployeeLayOff;

    protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs? e) {
        EmployeeLayOff.Invoke(this, e);
    }

    public int EmployeeID { get; set; }

    public DateTime BirthDate { get; set; }

    public int VacationStock { get; set; }

    public bool RequestVacation(DateTime From, DateTime To) {
        TimeSpan TotalHours = To - From;
        int TotalVacationDays = TotalHours.Days;

        if (VacationStock >= TotalVacationDays && VacationStock > 0) {
            VacationStock -= TotalVacationDays;
            return true;
        }
        else {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs
                { Cause = LayOffCause.EmptyVacationStock });
            return false;
        }
    }

    public void EndOfYearOperation() {
        DateTime EndOfYear = new DateTime(DateTime.Today.Year, 12, 31);
        int EmpAge = EndOfYear.Year - BirthDate.Year;

        if (EmpAge > 60) {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCause.Above60 });
        }
    }

    public override string ToString() {
        return $"Emp ID : {EmployeeID}";
    }
}

public enum LayOffCause {
    Above60,
    EmptyVacationStock,
}

public class EmployeeLayOffEventArgs {
    public LayOffCause Cause { get; set; }
}