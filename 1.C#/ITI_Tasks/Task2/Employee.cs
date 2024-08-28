namespace ITI_Tasks.Lab2;


public class Employee : IComparable, ICloneable{
    private int nationalID;
    private SecurityLevel securityLevel;
    private HiringDate hiringDate;
    private String name; 
    private float salary;


    public Employee(string name, int nationalId, SecurityLevel securityLevel, HiringDate hiringDate, float salary) {
        this.name = name;
        this.nationalID = nationalId;
        this.securityLevel = securityLevel;
        this.hiringDate = hiringDate;
        this.salary = salary;
    }

    public Employee(Employee other) {
        this.name = other.name;
        this.nationalID = other.nationalID;
        this.securityLevel = other.securityLevel;
        // this.hiringDate = new HiringDate(other.hiringDate); // Assuming HiringDate also has a copy constructor
        this.salary = other.salary;
    }


    public int CompareTo(object? obj) {
        var other = (Employee)obj;
        return hiringDate.CompareTo(other.hiringDate);
    }

    public int NationalID {
        get => nationalID;
        set => nationalID = value;
    }

    public string Name {
        get => name;
        set => name = value; 
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

    public object Clone() {
        return new Employee(this);
    }

    
}