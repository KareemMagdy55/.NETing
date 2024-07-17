namespace ITI_Tasks.Lab2;


public class Employee : IComparable{
    private int id;
    private SecurityLevel securityLevel;
    private HiringDate hiringDate;
    private float salary;


    public Employee(int id, SecurityLevel securityLevel, HiringDate hiringDate, float salary) {
        this.id = id;
        this.securityLevel = securityLevel;
        this.hiringDate = hiringDate;
        this.salary = salary;
    }

    public override string ToString() {
        return $"ID: {id} \nSecurity level: {securityLevel} \nHiring date: {hiringDate}\nSalary: {salary:C}\n";
    }

    public int CompareTo(object? obj) {
        var other = (Employee)obj;
        return hiringDate.CompareTo(other.hiringDate);
    }

    public int Id {
        get => id;
        set => id = value;
    }

    public SecurityLevel SecurityLevel {
        get => securityLevel;
        set => securityLevel = value;
    }
    public HiringDate HiringDate {
        get => hiringDate;
        set => hiringDate = value ?? throw new ArgumentNullException(nameof(value));
    }

    public float Salary {
        get => salary;
        set => salary = value;
    }
}