namespace Lectures.Lec11;

public class AnonymousAndLambdaFunctions {
    public static void MainLec11() {
        // Anonymous function is function fired on fly without making the function member of a class.
       
        // C# 2.0 feature : Anonymous method
        Func<int, bool> isEvenAnoFunc = delegate(int x) { return x % 2 == 0; };
        // Can be written as SomeFunction( delegate(int x) {return x % 2 == 0 ;} );
        
        // -----------------------------------------------------------//
        
        // C# 3.0 Feature, Lambda Expression 
        // Using lambda syntax compiler will generate anonymous method
        // => : Called fat arrow , read as "goes to"
        Func<int, bool> isEvenLamFunc = x => x % 2 == 0;
        
        // var isEvenLamFunc = x => x % 2 == 0;
        // var is not valid keyword here because compiler cannot guess input datatype.
//37
    }

    // Lambda Expression
    public int MyProp { get; set; }
}