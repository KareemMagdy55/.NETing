namespace Lectures.Lec12;

// First subscriber 
public class Player {
    public string Name { get; set; }
    public string Team { get; set; }

    public Player(string name, string team) {
        Name = name;
        Team = team;
    }
// Call back method (to be invoked)

    public void Run() {
        Console.WriteLine(ToString() + " Player state : Running");
    }
    public override string ToString()
        => $"Player's Name {Name}, Player's Team {Team}";
}