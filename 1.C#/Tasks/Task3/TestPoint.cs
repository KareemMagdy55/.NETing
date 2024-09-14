namespace Lab1.Task3;

public class TestPoint {
    public static void MainTestPoint() {
        Random random = new Random();
        Point[] points = new Point[15];

        for (int i = 0; i < points.Length; i++) {
            points[i] = new Point(0, 0, 0);
            points[i].X = random.Next(255);
            points[i].Y = random.Next(255);
            points[i].Z = random.Next(255);
            Console.WriteLine(points[i]);
        }

        Console.WriteLine("--------------------------------------------------------------------");
        
        Array.Sort(points);
        foreach (Point point in points) 
            Console.WriteLine(point);
        
        
    }
}