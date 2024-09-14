namespace Lectures;

public class Lec4 {
    // Value types, pass by value 
    public static void swap(int x, int y) {
        int temp = x;
        x = y;
        y = temp;

        // same as (x, y) = (y, x)
    }


    // Value type, pass by reference 
    public static void addOne(ref int x) {
        x += 1;
    }

    // Reference type, pass by value 
    public static int sumArray(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr?.Length; i++)
            sum += arr[i];
        return sum;
    }

    public static void sumMul(int x, int y, out int s, out int m) {
        // Since 's' and 'm' is out, so they must be initialized before any kind of access.
        s = x + y;
        m = x * y; 
    }

    public static void MainLec4() {
        // Pass by value : read only
        // Pass by reference : read & write 
        // Pass by out : write first 
        
        
        #region Passing by value and passing by reference

        int a = 3, b = 4;

        // Value types, pass by value 
        swap(a, b);

        // nothing changes
        Console.WriteLine($@" a : {a}");
        Console.WriteLine($@" b : {b}");

        // Value types, pass by reference
        addOne(ref a);
        // 'a' changed!
        Console.WriteLine($@" a : {a}");


        int[] arr = { 1, 2, 3, 4, 5 };
        // Arrays passed by reference (by default)
        Console.WriteLine(sumArray(arr));
        
        
        // Pass by value output 
        int x = 1, y = 3, s, m; 
        sumMul(x, y, out s, out m);
        
        
        // If you interested with knowing the mul. value only
        sumMul(x, y, out _, out m);

        #endregion
    }
}