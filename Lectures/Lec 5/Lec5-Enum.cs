namespace Lectures;


// Byte can carry from 0 to 255 and value exceeds will cause fitting error
// By default its 'int' not 'byte'
enum Grades:byte {
    A, B, C, D, F 
}


// r w x d 
// 1 0 0 1 -> user can delete and read 
// 0 1 1 0 -> user can execute and write
// But how to represent it as a single entity in 4 bits not array of bools ? 
// How to do bitwise operations to represent multiple rights in single entity? 

// Solution => Bit flag enum
[Flags]
enum FileAccessRight:byte {
    Read = 1, 
    Write = 2, 
    Execute = 4, 
    Delete = 8
}
public class Lec5_Enum {
    
    public static void Main() {
        #region Enum example 01

        Grades grade = Grades.A;
        
        // only explicit casting works in this case
        grade = (Grades)2;

        
        // Will be A (0 by default)
        grade = new Grades();
        Console.WriteLine(grade);

        #endregion

        FileAccessRight FAR = FileAccessRight.Read;
        FAR ^= FileAccessRight.Execute;
        Console.WriteLine(FAR);
        // > Read, Execute

        FAR = (FileAccessRight)15;
        Console.WriteLine(FAR);
        // > Read, Write, Execute, Delete
        
        // Check the bit of 'Read' access
        if((FAR & FileAccessRight.Read) == FileAccessRight.Read)
            Console.WriteLine("ACCESS RIGHTS HAS READ");

         

    }
}