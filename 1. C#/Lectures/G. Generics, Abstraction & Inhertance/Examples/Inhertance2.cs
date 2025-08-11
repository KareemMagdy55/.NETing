namespace HelloWorld.lec9;

class TypeA
{
    public int A { get; set; }

    public TypeA(int _A=0) { A = _A; }

    public void StaticallyBindedShow ()
    {
        Console.WriteLine("I am Base");
    }
    ///Dynamically Binded
    internal virtual void DynShow () ///non Private Virtual Method
    {
        Console.WriteLine($"Base {A}");
    }
}

class TypeB:TypeA
{
    public int B { get; set; }
    public TypeB(int _A =0 , int _B=0):base(_A)
    {
        B = _B;
    }

    internal override void DynShow()
    {
        Console.WriteLine($"Derived {A} {B}");
    }

    public new void StaticallyBindedShow() { Console.WriteLine("I am Derived"); }
}

class TypeC : TypeB
{
    public int C { get; set; }

    public TypeC(int _a=0 , int _b=0 , int _c=0):base(_a , _b)
    {
        C = _c;
    }

    internal override void DynShow()
    {
        Console.WriteLine($"Type C {A} {B} {C}");
    }
}

class TypeD : TypeC
{
   
    internal new virtual void DynShow() // new dynamically binded implementation,
                                        // that hasn't any relationship with the DynShow() function in above classes.
    {
        Console.WriteLine("Type D");
    }
}
class TypeE: TypeD
{
    ///override on TypeD Implementation
    internal override void DynShow() // Click the button beside function to see the parent, its "TypeD" not "TypeA"
    {
        Console.WriteLine("Type E");
    }
}


