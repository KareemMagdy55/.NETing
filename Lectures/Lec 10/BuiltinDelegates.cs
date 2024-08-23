namespace HelloWorld.Lec_10;

public class Helper() {
    public static bool trialFunc(int k) {
        return k % 2 == 0;
    }

    public static void ActionTrial(int val) {
        Console.WriteLine($"Hello, The val is {val}");
    }
}
public class BuiltinDelegates {
    BuiltinDelegates() {
        
        // Predicate class => public delegate bool Predicate<in T>(T obj); 
        Predicate<int> predicate = new Predicate<int>(Helper.trialFunc);

        // Func can work with function up to 16 input parameter
        Func<int, int, bool> func = Comparison.GreaterThan;

        // Action is same as "Func" but works with the void return function.
        Action<int> action = Helper.ActionTrial;
    }
}