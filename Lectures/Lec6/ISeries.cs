namespace Lectures.Lec6;


// interface for mathematical series (i.e. fib series)
public interface ISeries {
    int Current { get; }
    void GetNext();
    void Reset();
}

// In the prev example you can implement any Mathematical series
// and start using it withing you project entities 
// Here, Interface acts like a contract or blueprint of 
// how the "mathematical series" should be implemented 
