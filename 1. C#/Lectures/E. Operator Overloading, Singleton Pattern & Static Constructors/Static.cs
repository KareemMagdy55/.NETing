namespace Lectures.Lec8;


// static class Calculator // will have all its members static
public class Calculator {
    private int x;

    // Allocated in heap before first usage till end of program (or unreachable in case of ref type like arrays)
    private static readonly double PI ;

    // Only called once per class lifetime
    // parameterless 
    // Max only one static ctor per class
    static Calculator() {
        // x = 3; not valid 
        PI = 3.1432534543;
    }
    
    public Calculator() {
        // PI = 3.14; // Valid but not right place to initialize static members. 
        x = 0;
    } 
    
    
    // static functions can only access static variables; 
    public static double GetPI() {
        return PI;
    }
    
}