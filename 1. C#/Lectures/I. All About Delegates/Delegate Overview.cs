namespace HelloWorld.I._All_About_Delegates;

/*
  Delegate datatype is pointing to any function that has the signature in the initialization ,
  in the example below it can point to any function that have (int, int) as a parameters and bool as return type
  regardless of function name or access modifier
 */ 

public delegate bool ComparisionFunctionDelDT(int l, int r);
/*
 public delegate T3 ComparisionFunctionDelDT<in T1, in T2, out T3>(int x, int y);
 Generic delegate, "in/out" is a mode specification for T in delegates
 in => parameter type, out = return type .
*/

internal class BubbleSort {
    public static void Sort(int[] arr, ComparisionFunctionDelDT CFD) {
        for (int i = 0; i < arr?.Length; i++)
            for (int j = 0; j < arr?.Length - i - 1; j++)
                if (CFD is not null && CFD.Invoke(arr[j], arr[j + 1]))
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }
}

public class PointerToFunctionTrial {
    static void MainLec10(string[] args) {
        #region Delegate Example 1

        ComparisionFunctionDelDT fptr;
        fptr = new ComparisionFunctionDelDT(Comparison.GreaterThan);

        // Calling the function.
        // bool result = fptr.Invoke(5, 6);
        bool result = fptr(5, 6);

        Console.WriteLine(result); // false 

        #endregion

        int[] arr = { 5, 7, -1, 2, 9, 7 };
        BubbleSort.Sort(arr, Comparison.SmallerThan);
        foreach (var x in arr) {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }
}
public class Comparison {
    public static bool GreaterThan(int x, int y) {
        return x > y;
    }
    public static bool SmallerThan(int x, int y) {
        return x < y;
    }
    public static bool Equal(int x, int y) {
        return !SmallerThan(x, y) && !GreaterThan(x, y);
    }

}


// Delegate is more flexible than interface
// It can point to static method
// It can point to functions regardless of any changes to its name