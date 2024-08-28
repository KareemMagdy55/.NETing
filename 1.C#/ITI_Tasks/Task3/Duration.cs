using DateTime = System.DateTime;

namespace Lab1.Task3;

public class Duration {
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    public Duration(int hours, int minutes, int seconds) {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Duration() {
        
    }

    public override string ToString() {
        return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}\n";
    }

    public override bool Equals(object? obj) {
        Duration d = (Duration)obj;
        return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
    }

    public override int GetHashCode() {
        return Hours.GetHashCode() + Minutes.GetHashCode() + Seconds.GetHashCode();
    }

    public static Duration operator +(Duration d1, Duration d2) {
        return new Duration {
            Hours = d1.Hours + d2.Hours,
            Minutes = d1.Minutes + d2.Minutes,
            Seconds = d1.Seconds + d2.Seconds
        };
    } 
    
    
    public static Duration operator +(Duration d1, int i) {
        return new Duration {
            Hours = d1.Hours + (i),
            Minutes = d1.Minutes + (i % 60),
            Seconds = d1.Seconds + (i % (60 * 60))
        };
    }   
    public static Duration operator +(int i ,Duration d1) {
        return d1 + i;
    } 
    
    public static Duration operator ++(Duration d1) {
        return new Duration {
            Hours = d1.Hours ,
            Minutes = d1.Minutes + 1,
            Seconds = d1.Seconds 
        };
    }  
    public static Duration operator --(Duration d1) {
        return new Duration {
            Hours = d1.Hours ,
            Minutes = d1.Minutes - 1,
            Seconds = d1.Seconds 
        };
    } 
    public static Duration operator -(Duration d1) {
        return new Duration {
            Hours = -d1.Hours ,
            Minutes =- d1.Minutes ,
            Seconds = -d1.Seconds 
        };
    } 

  
    public static bool operator<(Duration d1, Duration d2) {
        if (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes)
            return d1.Seconds < d2.Seconds;
        if (d1.Hours == d2.Hours )
            return d1.Minutes < d2.Minutes;
        return d1.Seconds < d2.Seconds;
    } 
    public static bool operator<=(Duration d1, Duration d2) {
        return d1 < d2 || Equals(d1, d2); 
    }

    public static bool operator >=(Duration d1, Duration d2) {
        return d1 > d2 || Equals(d1, d2); 
    }

    public static bool operator >(Duration d1, Duration d2) {
        if (d1.Hours == d2.Hours && d1.Minutes == d2.Minutes)
            return d1.Seconds > d2.Seconds;
        if (d1.Hours == d2.Hours )
            return d1.Minutes > d2.Minutes;
        return d1.Seconds > d2.Seconds;
    }

    public static implicit operator bool(Duration d1) {
        return d1.Hours != 0;
    }
    public static explicit operator DateTime(Duration d1) {
        // DateTime dt = (DateTime.Now);
        return new DateTime( 0, 0, 0, d1.Hours, d1.Minutes, d1.Seconds);
    }
    
}