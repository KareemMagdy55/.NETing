namespace HelloWorld
{
    public class Lec2
    {
        public static void Main()
        {
            Console.WriteLine("\nHello world, Kareem is here !");

            #region CommonTypeSystem
            
            // Value type example (using stack)
            int x = 5; // C# keyword (primitive)
            Int32 y = 8; // Base class library type 

            y = x; // value of y = value of x, with different IDS
            Console.WriteLine(y.GetHashCode());
            Console.WriteLine(x.GetHashCode());
            

            // All are the same 
            Object o1 = new object(); // C# keyword
            Object o2 = new Object(); // BCL type
            Object o3 = new(); // C# (9.0)

            o2 = o1;
            
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
        }
    }
}