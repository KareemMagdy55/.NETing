using LINQ._3._Examples;

namespace Tasks;

using static ListGenerators;

public class ProjectionOperators {
    public static void MainProjectionOperators() {
        var productsNames = ProductList.Select(product => product.ProductName);
        productsNames.PrintList();

        // ================================= //
        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        var upperLower = words.Select(word => (word.ToUpper(), word.ToLower()));
        foreach (var valueTuple in upperLower)
            Console.WriteLine(valueTuple);

        // ============================== //
        var newProductsScheama =
            ProductList.Select(p => new { Name = p.ProductName, ID = p.ProductID, Price = p.UnitPrice });

        // ================================== //
        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var numMatchPos = Arr.Select((i, number) => new string($"{number} : {i == number}"));
        numMatchPos.PrintList();
        // =========================================== //
        int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        int[] numbersB = { 1, 3, 5, 7, 8 };

        
        
        // Fluent syntax will be more complex than Query syntax 
        
        //   var lessThanPairs = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b })
        //               .Where(@t => @t.a < @t.b)
        //               .Select(@t => $"{@t.a} is less than {@t.b}");
        var lessThanPairs =
            from a in numbersA
            from b in numbersB
            where a < b
            select $"{a} is less than {b}";
        
        lessThanPairs.PrintList();
        
        //============================================================================================//

        var ordersLessThan50000 =
            CustomerList.SelectMany(c => c.Orders.Where(o => o.Total <= 500_00).Select(o => o.OrderID));
        
        foreach (var i in ordersLessThan50000) 
            Console.WriteLine(i);
        
        // ========================================================================================//
        var ordersin1998orLater =
            CustomerList.SelectMany(c => c.Orders.Where(o => o.OrderDate >= new DateTime(1998, 1, 1)).Select(o => o.OrderID));
        
        foreach (var i in ordersin1998orLater) 
            Console.WriteLine(i);
        
        
        
    }
}