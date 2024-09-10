using LINQ._3._Examples;

namespace Tasks;

using static ListGenerators;

public class RestrictionOperators {
    public static void MainRestrictionOperators() {
        var allEmptyStockProducts = ProductList.
            Where(product => product.UnitsInStock == 0);

        allEmptyStockProducts =
            from product in ProductList
            where product.UnitsInStock == 0
            select product;
        
        allEmptyStockProducts.PrintList();
        
        // ================================ // 


        var productsCostMoreThan3 = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3);

        productsCostMoreThan3 =
            from product in ProductList
            where product.UnitsInStock > 0 && product.UnitPrice > 3
            select product;
        
        productsCostMoreThan3.PrintList();
        
        // ==================================//
        
        string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var digits = arr.Where((str, i) => str.Length < i );
        
        digits.PrintList();
        




    }
}