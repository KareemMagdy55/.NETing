namespace Lectures.Lec6;


class NegatvieNumberException : Exception {
    public NegatvieNumberException() : base("-ve num"){}

}


public class Exceptions {
    public static void MainExceptions() {
        // General catch block (if unhandled exception fired)
        try {
            ExceptionExample();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }

       
    }

    public static void ExceptionExample() {
        int x, y, z;

        try {
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            z = x / y;
            if (y < 0) throw new NegatvieNumberException();
        }
        // catch is optional 
        // You can write multiple catches with respect to it arrangement 
        catch (DivideByZeroException e) {
            Console.WriteLine("Y cannot equal zero");
            Console.WriteLine(e.HelpLink ?? "No help link");
        }
        catch (FormatException e) {
            Console.WriteLine("Check string format");
        }
        catch (NegatvieNumberException e) {
            Console.WriteLine(e.Message);
        }
        catch (Exception e) {
            Console.WriteLine("Default error message");
        }

        // "finally" block will executed whether the exceptions (handheld or not)
        finally {
            Console.WriteLine("Finally is here!");
        }
    }

    public static void ProtectiveExample() {
        int x, y, z;
        // TryParse return false if string cannot be parsed, so no exceptions will be thrown
        do {
            
        } while (!int.TryParse(Console.ReadLine(), out x));
    }
}