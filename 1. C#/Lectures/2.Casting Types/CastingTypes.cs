namespace Lectures;

public class CastingTypes {
    public void lec3() {
        #region Casting Built in value types

        int x = 5;
        long y = x; // implicit casting 
        // safe casting 

        x = (int)y; // Explicit casting
        // Int32 = Int64
        // Unsafe casting (Data loss in some cases)
        // Can cause overflow 

        // NOTE THAT : CLR does not throw overflowException in normal code block


        checked {
            // CLR will throw overflowException
            y = long.MaxValue;

            // unchecked {
            x = (int)y;
            // }
        }

        #endregion

        #region Boxing and unboxing

        // Appears in relation between
        // System.object & Any valueType

        // Rule : Base ref = child , statement is safe and valid    
        Object o1 = new Object();
        int valueType = 0;

        o1 = x;
        // Base ref = child .
        // This called Boxing 
        // Stack to heap


        x = (int)o1;
        // Unboxing
        // Unsafe, explicit 
        // Heap to stack

        #endregion

        #region Nullable types

        Nullable<int> nx = null;
        int? ny = 5;
        int x1 = 5;


        // Not safe :
        // Console.WriteLine(ny);

        // Protective programming approach

        // HasValue the same as ny != null
        if (ny.HasValue)
            Console.WriteLine(ny);

        x1 = ny.HasValue ? ny.Value : 0;
        x1 = ny ?? 0;

        #endregion

        #region Null operators

        double d = default;
        
        // What about this case ?
        int[] arr = default;
        for (int i = 0; i < arr.Length; i++) {
            Console.WriteLine(arr[i]);
        }
        // Default is NULL, an exception will be thrown.
        
        // Null propagation operator 
        for (int i = 0; i < arr?.Length; i++)
            Console.WriteLine(arr[i]);


        int r1 = arr.Length; // unsafe 
        int? r2 = arr?.Length; // safe 
        int r3 = arr?.Length ?? 0; // safe 

        #endregion

        #region Implicit Typed local variables
        // like auto in c++
        // Compiler will detect var datatype based on initial value. 
        // Var is not defined in IL 
        var x3 = 3;
        
        // In Runtime => int x3 = 3 ;



        #endregion
    }
}