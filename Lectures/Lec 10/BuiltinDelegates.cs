namespace HelloWorld.Lec_10;

public class Helper() {
    public static bool trialFunc(int k) {
        return k % 2 == 0;
    }
}
public class BuiltinDelegates {
    BuiltinDelegates() {
        
        // Predicate class => public delegate bool Predicate<in T>(T obj); 
        Predicate<int> predicate = new Predicate<int>(Helper.trialFunc);

        // Func can work with function up to 16 input parameter
        Func<int, int, bool> func = Comparison.GreaterThan;
        
    }
}