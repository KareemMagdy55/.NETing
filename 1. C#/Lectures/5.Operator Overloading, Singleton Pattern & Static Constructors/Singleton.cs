namespace Lectures.Lec8;

// Make a graphics card class that produce only the same instance
// each time you make a new object of graphics card class
class GraphicsCard {
    public int Data { get; set; }
    static GraphicsCard graphicsCard;

        GraphicsCard(int data) {
        Data = data;
    }

    static GraphicsCard() {
        graphicsCard = new GraphicsCard(3231);
    }
    public static GraphicsCard GetCard() {
        return graphicsCard;
    }
    // 12-18 can be replace with this one line code : 
    // public static GraphicsCard singleGC { get; } = new GraphicsCard(54678); (readonly static object)

}
public class Singleton {
    public static void MainSingleton() {
        GraphicsCard gc1 = GraphicsCard.GetCard();
        GraphicsCard gc2 = GraphicsCard.GetCard();


        // Hashcode must be the due the requirement above
        Console.WriteLine(gc1.GetHashCode());
        Console.WriteLine(gc2.GetHashCode());

    }
}