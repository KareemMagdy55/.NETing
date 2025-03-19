using LINQ._3._Examples;

namespace Tasks;
using static ListGenerators;
public class ElementOperators {
    public static void MainElementOperators() {
        var firstProductOutOfStock = ProductList.FirstOrDefault(product => product.UnitsInStock == 0);
        Console.WriteLine(firstProductOutOfStock);

        var firstProductMatched = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);
        Console.WriteLine(firstProductMatched);
        
        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var secondNumberGreater5 = Arr.Where(number => number > 5).OrderBy(number => number).ElementAtOrDefault(1);
        Console.WriteLine(secondNumberGreater5);


    }
}