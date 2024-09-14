namespace HelloWorld.lec9;

public class Person {
    public string name { get; set; }
    public virtual int age { get; set; }

    public  Person(string name, int age) {
        this.name = name;
        this.age = age;
    }

    public override string ToString() {
        return $"Name : {name}\nAge : {age}";
    }

    public int func1() {
        return 0; 
    }
}

public class Employee : Person {
    public string EmpID { get; set; }

    
    // Keyword 'base' used only inside derived class.
    public Employee(string name, int age, string empId)
        : base(name, age) {
        EmpID = empId;
    }

    public new int func1() {
        return 0; 
    }
    public override string ToString() {
        return $"{base.ToString()}\nEmployee ID : {EmpID}";
    }
}