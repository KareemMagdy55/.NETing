namespace HelloWorld.I._All_About_Delegates;

public class DelegateOverview {
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
