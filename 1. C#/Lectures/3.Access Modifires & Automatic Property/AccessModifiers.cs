namespace Lectures.Lec_7;

public class SomeRandomVars {
    public int x; // Can be accessed from all other classes
    private int y; // Cannot be accessed
    internal int z; // Only accessed by classes within the same project/assembly file
    protected int w; // Only accessed by children

    protected internal int l; // Acts like internal and protected at the same time 
    // Outside project files => Only children can access variable 'l' (acts like => protected int l )
    // inside project files => all classes can access variable 'l' (acts like => internal int l )
    
    private protected int m;
    // Can be accessed inside any children in the same project/assembly files only.
}