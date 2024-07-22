namespace Lectures.Lec_7;

public class SomeRandomVars {
    public int x; // Can be accessed from all classes
    private int y; // Cannot 
    internal int z; // only by classes within the same project/assembly file
    protected int w; // by children

    protected internal int l; // Acts like internal and protected at the same time 
    // Outside project files => children can access 'l'
    // inside project files => all classes can access 'l'


    private protected int m;
    // Can be accessed inside any children in the same assembly file.
}