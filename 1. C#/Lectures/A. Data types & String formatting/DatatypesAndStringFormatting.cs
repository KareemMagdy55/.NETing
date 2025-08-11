using System.Text;

namespace Lectures
{
      // Concepts will be mentioned later ... 
     // CLR : Common Language Runtime (CLR) is a core part of the Microsoft .NET 
     //       that handles execution of .NET-supported programming languages such as C#. 

     // BCL :  Base Class Library (BCL) is a core set of pre-built classes and types provided by Microsoft in the .NET.
     // See CTS - Common type system image 
    public class DatatypesAndStringFormatting
    {
        public static void MainLec2()
        {
            Console.WriteLine("\nHello world, Kareem is here !");

             // a region is used to enhance program orgnization only.
            #region CommonTypeSystem 
            
            // Value type example (preserved in the stack)
            int x = 5; // C# keyword (primitive)
            Int32 y = 8; // BCL type 

            y = x; // value of y = value of x, copy of the value not the refernce (different hashcodes)
            Console.WriteLine(y.GetHashCode());
            Console.WriteLine(x.GetHashCode());
            

            // All are the same 
            // All saved as a reference (a pointer) to the object on the heap.
            Object o1 = new object(); // C# keyword
            Object o2 = new Object(); // BCL type (O is capital)
            Object o3 = new(); // C# (9.0 +)

            o2 = o1; // o1 and o2 now point to the same location in the Heap (same hashCode)

            Console.WriteLine(o1.GetHashCode());
            Console.WriteLine(o2.GetHashCode());

            #endregion

            #region anotherDatatypes

            float floatX = 13.2f; // f literal casting must be written
            double doubleX = 1321.322;
            decimal decimalX = 32132.22M; // M literal casting must be written

            int n = 1_000_000; // _ discarded
            n = 0x_00_00_FA_12; // HEX

            sbyte bt = 0b_0101_1100; // Binary

            #endregion

            #region stringFormatting

            int userX, userY;
            // Same 
            userX = int.Parse(Console.ReadLine()); // String to integer 
            userY = Convert.ToInt32(Console.ReadLine()); // String to any type in convert class

            String msg = string.Format("Equation : {0} + {1} = {2}", userX, userY, userX + userY);
            msg = $"Equation : {userX} + {userY} = {userX + userY}";
            // $ : String manipulation operator 
            Console.WriteLine(msg);

            msg = $"Equation : {userX} + {userY} = {userX + userY:C}";
            // C is a Numeric formatting Symbol that represent currency
            // D decimal, E exponential(scientific), X hex, and more....
            
            
            msg = $"Equation : {userX, 5} + {userY, -5} = {userX + userY}";
            // Print userX aligned to right by 5 
            // Print userY aligned to left by 5
            

            #endregion


            #region String Vs StringBuilder
                // String is IMMUTABLE: any change creates a new object in memory
                string s = "Hello";
                s += " World"; // New string created, old one discarded
                Console.WriteLine(s);

                // StringBuilder is MUTABLE: can change the same object in place
                var sb = new StringBuilder("Hello");
                sb.Append(" World"); // Same object, modified directly
                Console.WriteLine(sb.ToString());
            
            #endregion
        }
    }
}
