namespace Lectures.Lec6;

public interface IMyType {
    // int x; interface cannot contain properties 

    void fun();
    decimal Salary { get; set; }

    // C# 8.0 feature (default implemented methods)
    // void fun2() {
        // Console.WriteLine("Hello from interface");
    // }
}

struct MyStruct: IMyType {
    public void fun() {
        throw new NotImplementedException();
    }

    public decimal Salary { get; set; }
}
