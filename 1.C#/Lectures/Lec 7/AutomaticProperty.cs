namespace Lectures.Lec_7;

public class Product {
    public int ID { get; set; } // Automatic property
    // Compiler will generate a private attribute
    // and encapsulate it with public property
    
    
    // Drawback :
    // Accessing hidden attribute (inside class)
    // done by public property only.
}