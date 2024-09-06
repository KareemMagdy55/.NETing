namespace LINQ._1.Overview;


// HOW can we represent entities in a database in our code on the fly?
public class AnonymousType {
    public static void TRIAL() {
        // HERE it is so obvious that var keyword is necessary in this context
        var EMP1 = new { ID = 101, Name = "Aly", Salary = 13213 };

        Console.WriteLine(EMP1.GetType().Name); // <>f__AnonymousType0`3 => (3 attributes)

        // EMP.Name = "leo"; // NOT VALID , Immutable object (to be changed you must 

        
        // Same var as long as same property names (case-sensitive), same property type and same sequence
        var EMP2 = new { ID1 = 102, Name = "Kareem", Salary = 13213 };

        // GetHashCode() based on values not identities 
    }
    
    // NOTE THAT: - C# is strongly typed (statically typed) it means that you must decide what is
    // some variable's datatype in an initialization statement 
    
    // - Anonymous type cannot use be as input parameter or return types.

}