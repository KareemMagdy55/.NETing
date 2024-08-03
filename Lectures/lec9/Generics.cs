namespace Lectures.Lec_10;

public class Helper {
    public static void Swap<T>(ref T x, ref T y) {
        (x, y) = (y, x);
    }
}

public class Helper2<T> {
    public Helper2() {
        // Valid for T "Any datatype" (Nine statements)

        // 1.Declaration and initialization with default
        T x = default;

        // 2. Assignment operator 
        T y = x;

        // 3. Return statement 
        // T fun(){ return x;}

        // 4. System Object and its methods
        Object o = x;
        x.ToString();
        x.Equals(y);

        
        // Not valid 
        // x = 0 ; not every datatype can initialized with 0
        // y = null; y can be non-nullable datatype
        // x = new T(); struct has always empty ctor, while class cannot have if parameterized ctor already defined.
        
        
        
        
        

    }
}

// Generic class with constraints 
public class Helper3<T>

    where T : 
    // Primary constraints 
    class, // special primary constraint (T must be class)
    // Point , // General primary constraints (specific class, struct or enum), to allow using Point and its childs.
    
    // Secondary constraints (interface constraints)
     IComparable<T> // T must implement IComparable


    // Constructor constraints 
    , new() // T must have accessible parameterless ctor

{
    public Helper3() {
        // After primary constraints this statement is valid 
        T x = null;
        T y = null;
        // After Secondary constraints this statement is valid
        if (x != null && x.CompareTo(y) != 0) {
            // Do something ...
        }
    }
}

public class TryGenerics {
    public static void Main() {
        // var x = 3;
        // var y = 6;

        // var x = 3.33354;
        // var y = 6.48799;

        var x = "3";
        var y = "6";


        Console.WriteLine("Before Swapping");
        Console.WriteLine($"x : {x}");
        Console.WriteLine($"y : {y}");

        // In generic methods, Compiler automatically detect the type
        // In generic classes you must define "T" with specific datatype 
        Helper.Swap(ref x, ref y);

        Console.WriteLine("After Swapping");
        Console.WriteLine($"x : {x}");
        Console.WriteLine($"y : {y}");
    }
}