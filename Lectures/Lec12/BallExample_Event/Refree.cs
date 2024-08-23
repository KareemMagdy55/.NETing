namespace Lectures.Lec12;
// Second subscriber 
public class Referee {
    public string Name { get; set; }

    public Referee(string name) {
        Name = name;
    }
// Call back method (to be invoked)
    public void Look() {
        Console.WriteLine($"Referee {Name} is looking...");
    }
}