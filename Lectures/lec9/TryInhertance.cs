namespace HelloWorld.lec9;

public class TryInhertance {
    public static void Main() {
      
        TypeA BaseRef = new TypeA(1);
        BaseRef.StaticallyBindedShow(); //Base
        BaseRef.DynShow(); //Base
        
        TypeB DerivedRef = new TypeB(2, 3);
        DerivedRef.StaticallyBindedShow(); //Derived
        DerivedRef.DynShow(); //Derived
        
        BaseRef = new TypeB(4, 5);
        //Ref to Base = Derived Object
        //BaseRef.A = 6;
        BaseRef.StaticallyBindedShow();//Base
        //Statically Binded methods (non virtual) Compiler Bind Call based in Reference Type not Object Type
        
        BaseRef.DynShow();//Derived
        //Dynamically Binded Method , CLR will bind Function Call based on Object Type in Runtime  
        
        
        BaseRef = new TypeC(6, 7, 8);
        DerivedRef = new TypeC(9, 10, 11);
        
        BaseRef.DynShow(); //TypeC
        DerivedRef.DynShow(); //TypeC
        
        
        BaseRef = new TypeD();
        BaseRef.DynShow(); //TypeC DynShow() will run because TypeD DynShow()
                           //function that has new keyword (see more in inhertance2.cs)
        
        
        TypeD RefD = new TypeD();
        RefD.DynShow(); //TypeD
    }
}