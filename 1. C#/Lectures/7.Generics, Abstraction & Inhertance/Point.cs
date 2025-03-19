namespace HelloWorld.lec9;

public class Point  {
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point(int x, int y, int z = 0) {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    

    public override bool Equals(object? obj) {
        //     if (obj is Point p)
        //         return p != null && p.X == X && p.Y == Y && p.Z == Z; 
        if (obj is null) return false;
       
        if (this.GetType() != obj.GetType()) return false;
        
        Point? p = obj as Point; // returns null if casting fails
        
        if (ReferenceEquals(p, this)) return true; // More performance. 
        
        return p.X == X && p.Y == Y && p.Z == Z;

        // Is & as keywords can lead to same logic, these keywords only works for ref types.
    }

  
}