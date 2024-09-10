using LINQ._3._Examples;

namespace Tasks;

using static ListGenerators;

public class SetOperators {
    public static void MainSetOperators() {
        var uniqueCategoryProducts = ProductList.DistinctBy(product => product.Category);
        uniqueCategoryProducts.PrintList();

        // ===============//
        var productsFirstLetter = ProductList.Select(p => p.ProductName[0].ToString());
        var customersFirstLetter = CustomerList.Select(c => c.CompanyName[0].ToString());

        var concatList = productsFirstLetter.Concat(customersFirstLetter).Distinct();
        concatList.PrintList();

        // ===============//

        var commonFirstLetters = productsFirstLetter.Intersect(customersFirstLetter).Distinct();
        commonFirstLetters.PrintList();

        var lst = productsFirstLetter.Except(customersFirstLetter);
        lst.PrintList();

        // =============== //
        var productsLastThree = ProductList.Where(p => p.ProductName.Length > 3)
            .Select(p => p.ProductName.Skip(p.ProductName.Length - 3).Take(3));
        var customersLastThree = CustomerList.Where(c => c.CompanyName.Length > 3)
            .Select(c => c.CompanyName.Skip(c.CompanyName.Length - 3).Take(3));

        var res = productsLastThree.Concat(customersLastThree);
        foreach (var re in res) {
            foreach (var c in re)
                Console.Write(c + ", ");
            Console.WriteLine();
        }
        
        
    }
}