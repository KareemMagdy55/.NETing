using LINQ._3._Examples;

namespace Tasks;

using static ListGenerators;

public class OrderingOperators {
    public static void MainOrderingOperators() {
        var productsSortedByName = ProductList.OrderBy(product => product.ProductName);
        productsSortedByName.PrintList();
        // ==================================================== //
        
        string[] Arr1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        var sortedArrCaseInsensitive = Arr1.OrderBy(_ =>StringComparer.OrdinalIgnoreCase );
        sortedArrCaseInsensitive.PrintList();
        
        // ============================================== //

        var sortedByUnits = ProductList.OrderBy(product => product.UnitsInStock);
        sortedByUnits.PrintList();
        
        // =========================================== //
        string[] Arr2 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        var sortedByLen = Arr2.OrderBy(str => str.Length).ThenBy(str => str);
        sortedByLen.PrintList();
        
        // ============================================= //
        var productsByCategoryThenPrice = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
        productsByCategoryThenPrice.PrintList();
        
        // ======================================= //
        string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        var sortedArr3 = Arr3.OrderBy(s => s.Length).ThenByDescending(_ => StringComparer.OrdinalIgnoreCase);
        sortedArr3.PrintList();
        
        // ======================================//
        string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var sortedBySecondLetterI = Arr4.Reverse().Where(str => str[1] == 'i');
        sortedBySecondLetterI.PrintList();

    }
}