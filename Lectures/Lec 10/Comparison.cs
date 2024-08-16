namespace HelloWorld.Lec_10;

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