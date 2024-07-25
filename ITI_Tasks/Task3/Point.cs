namespace Lab1.Task3;

public class Point : IComparable, ICloneable {
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public Point(int x, int y, int z = 0) {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    
    public static void ParseFromString(ref Point p, string s) {
        var arr = s.Split(' ');
        p.X = Convert.ToInt32(arr[0]);
        p.Y = Convert.ToInt32(arr[1]);
        p.Z = Convert.ToInt32(arr[2]);
    }
    
    public static explicit operator string(Point point) {
        return point.ToString() ;
    }

    public override bool Equals(object? obj) {
        Point p = (Point)obj;
        return p != null && p.X == X && p.Y == Y && p.Z == Z; 
    }

    public override string ToString() {
        return $"{X}::{Y}::{Z}";
    }

    public object Clone() {
        return new Point(X, Y, Z);
    }

    public int CompareTo(object? obj) {
        Point p = (Point)obj;
        if (p == null) return 0; 
        if (p.X == X && p.Y == Y) return Z.CompareTo(p.Z);
        if (p.X == X ) return Y.CompareTo(p.Y);
        return X.CompareTo(p.X);
    }
}