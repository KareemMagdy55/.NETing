namespace Lectures.Lec12;

public class Location {
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public static bool operator ==(Location? L, Location? R) {
        if (L is not null && R is not null) 
           return (L.X == R.X) && (L.Y == R.Y) && (L.Z == R.Z);
        return false;
    }

    public static bool operator !=(Location? L, Location? R) =>
         !(L == R);
    

    public override string ToString() {
        return $"({X}, {Y}, {Z})";
    }
}