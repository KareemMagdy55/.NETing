using LINQ._3._Examples;

namespace Tasks;

using static ListGenerators;

public class AggregateOperators {
    
    public static void MainAggregateOperators() {
        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var oddNumbersCnt = Arr.Count(number => number % 2 == 1);
        Console.WriteLine(oddNumbersCnt);
        
        // ============================================================================== //

        var eachCustomerOrders =
            CustomerList.Select(customer => (customer.CompanyName, customer.CustomerID, customer.Orders));


        var eachCategoryProducts =
            from c in ProductList.GroupBy(p => p.Category)
            select (c.Key, c.Count());
                
        
        foreach (var (category, count) in eachCategoryProducts) 
            Console.WriteLine("(" +category + " : " + count +")");
        
        
        // =============================================================================== //
        var totalNumbersInArr = Arr.Aggregate(0, (s, n) => s + n);
        Console.WriteLine(totalNumbersInArr);
        
        // ================================================================================ // 

        var englishWords = LoadWordsFromFile("dictionary_english.txt");
        int totalNumberOfChars = englishWords.Aggregate(0, (s, n) => s += n.Length);

        Console.WriteLine(totalNumberOfChars);
        // ============================================================================= // 
        
        var totalUnits =   
            from c in ProductList.GroupBy(p => p.Category)
            select (c.Key, c.Sum(p => p.UnitsInStock));
        
        
        foreach (var (category, units) in totalUnits) 
            Console.WriteLine("(" +category + " : " + units +")");

        // ============================================================================== //

        var shortestWordLength = englishWords.Min().Length;
        Console.WriteLine(shortestWordLength);
        
        // ============================================================================ // 
        var cheapestPrice = 
            from c in ProductList.GroupBy(p => p.Category)
            select (c.Key, c.Min(p => p.UnitPrice));
        
        foreach (var (category, price) in cheapestPrice) 
            Console.WriteLine("(" +category + " : " + price +")");
        
        // ============================================================================ // 

        var cheapestProducts =
            from category in ProductList.GroupBy(p => p.Category)
            let cheapest = (category.Key, category.Min(p => p.UnitPrice)).Item2
            select (category.Key, category.First(p => p.UnitPrice == cheapest));
        
        foreach (var (category, product) in cheapestProducts) 
            Console.WriteLine("(" +category + " : " + product +")");

        // ================================================================================== //
        var longestWordLength = englishWords.Max().Length;
        Console.WriteLine(longestWordLength);
        
        // ========================================================================== // 
        
        var mostExpensivePrices = 
            from c in ProductList.GroupBy(p => p.Category)
            select (c.Key, c.Max(p => p.UnitPrice));
        
        foreach (var (category, price) in mostExpensivePrices) 
            Console.WriteLine("(" +category + " : " + price +")");
        
        // ====================================================================== //
        var mostExpensiveProducts = 
            from category in ProductList.GroupBy(p => p.Category)
            let mostExpensive = (category.Key, category.Max(p => p.UnitPrice)).Item2
            select (category.Key, category.First(p => p.UnitPrice == mostExpensive).ProductName);
        
        foreach (var (category, product) in mostExpensiveProducts) 
            Console.WriteLine("(" +category + " : " + product +")");
        
        // ======================================================================== //

        var avgWordLength = englishWords.Average(word => word.Length);
        Console.WriteLine(avgWordLength);
        
        // ======================================================================== //
        
        var avgPricesEachCategory = 
            from category in ProductList.GroupBy(p => p.Category)
            select (category.Key, category.Average(p => p.UnitPrice));
        
        foreach (var (category, product) in avgPricesEachCategory) 
            Console.WriteLine("(" +category + " : " + product +")");
        

    }
}