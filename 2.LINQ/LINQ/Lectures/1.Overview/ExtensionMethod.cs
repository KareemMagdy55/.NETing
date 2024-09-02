namespace LINQ._1.Overview;

// But, how they put a new functions in the "list" class ?  
static class ExtensionMethod {
   public static int FirstElement(this List<int> lst) {
      return lst[0];
   }

   public static void TRIAL() {
      List<int> x = [1, 2 ,4];
      int y = x.FirstElement();
      // == ExtensionMethod.Mirror(x);

      Console.WriteLine(y); // Prints 1 
      Console.WriteLine(ExtensionMethod.FirstElement(x)); // Prints 1 
      
   }
    
}