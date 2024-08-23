namespace Lectures.Lec12;

public class TrialBallExample {
    public static void MainBallExample() {
        Ball ball = new Ball();

        Player p1 = new Player("Mo", "FC1");
        Player p2 = new Player("Leo", "FC2");
        Player p3 = new Player("Tok", "FC3");
        Player p4 = new Player("Nui", "FC4");

        Referee R1 = new Referee("REF");
        
        ball.BallLocation = new Location {
            X = 20,
            Y = 59,
            Z = 32
        };

        Console.WriteLine(ball);
        // Registration 
        // Add Pointer to subs' call back method to publisher event Invocation list 
        ball.LocationChanged += p1.Run;
        ball.LocationChanged += p2.Run;
        ball.LocationChanged += p3.Run;
        ball.LocationChanged += p4.Run;

        ball.LocationChanged += new Action(R1.Look);
        ball.LocationChanged += () => Console.WriteLine("Dummy");

        
        ball.BallLocation = new Location {
            X = 22,
            Y = 59,
            Z = 32
        };
        Console.WriteLine(ball);
        
        // UnRegistration 
        ball.LocationChanged -= p2.Run;
        
         
        ball.BallLocation = new Location {
            X = 27,
            Y = 59,
            Z = 32
        };
        Console.WriteLine(ball);


    }
}