namespace Lectures.Lec12;

// Publisher class
public class Ball {
    public int ID { get; set; }
    private Location ballLocation;
    internal Location BallLocation {
        get => ballLocation;
        set {
            if (value != ballLocation) {
                ballLocation = value;
                // Notify subscribers (Invoke each function in Invocation List)
                LocationChanged?.Invoke();
                
            }
        }
    }

    // Saves subs call back function(s)
    // public event Action<Location> LocationChanged; // Take a location as a parameter
    public event Action LocationChanged;
    // You cannot use (=) with event only (+= or -=).

    public override string ToString() => $"Ball {ID} at {BallLocation}";
}