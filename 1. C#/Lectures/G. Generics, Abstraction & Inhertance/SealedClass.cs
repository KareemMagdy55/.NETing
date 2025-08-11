namespace HelloWorld.lec9;

public abstract class HW {
    public abstract int isAvaliable { set; get; }
    
}

// Sealed class cannot have children
public sealed class Memory : HW{
    public override int isAvaliable { get; set; }
}

// NOT VALID
// public class SubMemory : Memory {
//     
// }
public class CPU : HW {
    
    public sealed override int isAvaliable { get; set; }
}

public class Cores : CPU {
    // public sealed override int isAvaliable { get; set; } Not valid
    
}