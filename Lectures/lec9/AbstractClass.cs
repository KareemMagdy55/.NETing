namespace HelloWorld.lec9;

// Abstract class cannot be initiated as object
// Not all methods in abstract class must be abstract

abstract class GeoShape {
    public int Dim1 { get; set; }
    public int Dim2 { get; set; }

    protected GeoShape(int dim1, int dim2) {
        Dim1 = dim1;
        Dim2 = dim2;
    }

    public abstract Double Area();
    public abstract Double Perimeter { get; set; }
}

// Abstract keyword here makes Rectangle class choose what to implement
abstract class Rectangle:GeoShape {

    public override double Area() {
        return Dim1 * Dim2; 
    }

    protected Rectangle(int dim1, int dim2) : base(dim1, dim2) {
    }
}

// Here we implement only the perimeter because parent already implement Area()
class Square : Rectangle {
    public Square(int w, int h) : base(w, h) {
    }

    public override double Perimeter { get; set; }
}


// Interfaces can be used in classes and structs 
// Multiple interfaces vs one abstract class



