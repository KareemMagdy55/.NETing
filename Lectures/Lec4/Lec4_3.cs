
namespace Lectures;

class TypeB {
    // private by default.
     int _x; 
    
    public TypeB() {
        TypeA k;
        // 'y' must be initialized first
        k.y = 0;
        Console.WriteLine(k.y);
    }
}