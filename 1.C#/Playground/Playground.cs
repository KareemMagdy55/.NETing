using System.Diagnostics;

namespace Playground;

public class TryStackFrame
{
    public TryStackFrame()
    {
        StackTrace st = new StackTrace();
        var stackframes = st.GetFrames();

        foreach (var stackframe in stackframes)
            Console.WriteLine(stackframe.GetMethod());
    }

}

class Playground
{
    public static bool AreStringEqual(string s1, string s2)
    {
        return string.Equals(s1, s2, StringComparison.OrdinalIgnoreCase);
    }
    public static void Main()
    {
        Console.WriteLine("hello");
        int[] arr = { 1, 2, 3, 4 };
        Console.WriteLine(arr);


        Console.WriteLine("Hello, world");
        int n = 3;
        int k = 4;

        var res = Convert.ToString(n ^k, 2).Aggregate(0, (s, ch) => s + (ch == '1' ? 1 : 0));

    }
}