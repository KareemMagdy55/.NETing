using LINQ._3._Examples;

namespace Tasks;

using static ListGenerators;

public class Quantifiers {
    public static void MainQuantifiers() {
        var englishWords = LoadWordsFromFile("dictionary_english.txt ");
        var words = englishWords.Where(word => word.Contains("ei"));

        words.PrintList();
        // ==========================================================================//
        var categories = ProductList.GroupBy(p => p.Category);

        var res = categories.Where(g => g.Any(p => p.UnitPrice == 0));

        foreach (var products in res)
            foreach (var product in products)
                Console.WriteLine(products.Key + " " + product.ProductName);

        // ============================================================================ //
        res = categories.Where(g => g.All(p => p.UnitPrice > 0));

        foreach (var products in res)
            foreach (var product in products)
                Console.WriteLine(products.Key + " " + product.ProductName);
        
    }
}