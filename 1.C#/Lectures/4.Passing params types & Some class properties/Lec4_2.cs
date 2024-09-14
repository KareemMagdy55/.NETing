namespace Lectures;
// Default access modifier inside namespace is internal
struct TypeA {
    // Private by default
    int x;

    // Internal means the variable is
    // Accessible inside the same project
    internal int y;

    // Constructor works in C# by using new
    // TypeA A = new TypeA(1, 3);
    // Still a value type (Allocated in stack).
    public TypeA(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public override string ToString() {
        return $"({x}, {y})";
    }
}