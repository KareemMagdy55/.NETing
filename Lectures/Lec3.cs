namespace HelloWorld;

public class Lec3 {
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
    }
}