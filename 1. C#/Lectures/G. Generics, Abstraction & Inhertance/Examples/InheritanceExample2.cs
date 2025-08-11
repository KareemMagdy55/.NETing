namespace HelloWorld.G._Generics__Abstraction___Inhertance.Examples;

public class InheritanceExample2 {
    public static void MainTryInhertance() {
      
        TypeA Parent = new TypeA(1);
        Parent.StaticallyBindedShow(); //Base
        Parent.DynShow(); //Base
        
        TypeB Child = new TypeB(2, 3);
        Child.StaticallyBindedShow(); //Derived
        Child.DynShow(); //Derived
        
        Parent = new TypeB(4, 5);
        //Ref to Base = Derived Object
        //BaseRef.A = 6;
        Parent.StaticallyBindedShow();//Base
        //Statically Binded methods (non virtual) Compiler Bind Call based in Reference Type not Object Type
        
        Parent.DynShow();//Derived
        //Dynamically Binded Method , CLR will bind Function Call based on Object Type in Runtime  
        
        
        Parent = new TypeC(6, 7, 8);
        Child = new TypeC(9, 10, 11);
        
        Parent.DynShow(); //TypeC
        Child.DynShow(); //TypeC
        
        
        Parent = new TypeD();
        Parent.DynShow(); //TypeC DynShow() will run because TypeD DynShow()
        //function that has new keyword (see more in inhertance2.cs)
        
        
        TypeD RefD = new TypeD();
        RefD.DynShow(); //TypeD
    }
}