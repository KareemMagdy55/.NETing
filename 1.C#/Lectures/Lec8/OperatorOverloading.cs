namespace Lectures.Lec8;

// In C# We cannot overload = or [] or compound ops (+=, -=, *=, ...)
// Overloading only done by static member functions
// Overloading comparison operators done in pairs (e.g. overload < then you must overload >)
class Complex {
    public int Real { get; set; }
    public int Imag { get; set; }

    public static Complex operator +(Complex c1, Complex c2) {
        return new Complex {
            Real = c1.Real + c2.Real,
            Imag = c1.Imag + c2.Imag
        };
    }  
    // public static Complex operator +(Complex c1, int i) {} valid
    
    public static Complex operator -(Complex c1, Complex c2) {
        return new Complex {
            Real = c1.Real - c2.Real,
            Imag = c1.Imag - c2.Imag
        };
    }

    public override string ToString() {
        return $"{Real}+{Imag}i";
    }

    // To convert from complex to int
    // implicit : use implicit keyword.
    // explicit : use explicit keyword.
    public static explicit operator int(Complex C) {
        return C?.Real ?? 0;
    }
}

class Program {
    public static void MainOp() {
        Complex c1 = new Complex() {
            Real = 2,
            Imag = 2
        };
        Complex c2 = new Complex() {
            Real = 4,
            Imag = 3
        };
        Complex c3, c4;
        c3 = c2 + c1;
        c4 = c3 - c1;
        int x = 3;
        x = (int)c3;
        Console.WriteLine(c3);
        Console.WriteLine(c4);
    }
}