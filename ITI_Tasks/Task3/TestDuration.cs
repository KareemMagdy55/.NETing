namespace Lab1.Task3;

public class TestDuration {
    public static void Main() {
        Duration D1 = new Duration(3, 4, 2);
        Duration D2 = new Duration(4, 2, 5);
        Duration D3 = new Duration(12, 3, 4);
        D3 = D1 + D2;
        D3 = D1 + 7800;
        D3 = 666 + D3;
        D3 = D1++;
        D3 = --D2;
        D1 = -D2;
        if(D1 > D2);
        if(D1 <= D2);
        if(D1);
        DateTime Obj = (DateTime)D1;

        Console.WriteLine(D1.ToString());
        Console.WriteLine(D2.ToString());
        Console.WriteLine(D3.ToString());
    }
}