namespace LINQ._3._Examples;

using static ListGenerators;


// NOTE THAT: LINQ operators is a topic that I believe you cannot learn it right without researching and coding,
//            So this file may not help you in every LINQ operator, YOU MUST TRY.

// TAKE A LOOK AT "Tasks" PROJECT
public static class LinqToObject {

// Some of 40+ LINQ operators
    public static void Main() {
        #region Where

        IEnumerable<Product> emptyStockProducts = ProductList.Where(p => p.UnitsInStock == 0);
        emptyStockProducts.PrintList();

        emptyStockProducts = from Product1 in ProductList
            where Product1.ProductID > 1
            select Product1;

        #endregion

        #region Select

        // Project from product datatype to string
        IEnumerable<string> result2 = ProductList.Select(p => p.ProductName);
        result2.PrintList();

        // Project from product datatype to anonymous datatype
        var result3 = ProductList.Where(p => p.UnitsInStock == 0)
            .Select((p, i) => new { i, p.ProductID, p.ProductName });
        result3.PrintList();

        var result4 = ProductList.Select(p => new { newPrice = p.UnitPrice * 1.1M }).Where(p => p.newPrice > 20);
        result4.PrintList();

        var result5 = from Product1 in ProductList
            select new { Name = Product1.ProductName, Price = Product1.UnitPrice }
            into newProd
            where newProd.Price > 220
            select newProd;

        #endregion

        #region Select Many

        List<string> names = ["L K", "M N", "S F"];

        // Select projects(transforms) each "name" into a new array splited by space;
        // SelectMany does the same thing, but it flattens(~make it 1 Dimension) the result array(sequence).
        IEnumerable<string[]> selectNamesResult = names.Select(name => name.Split(' ')); // => [[L, K], [M, N], [S, F]];
        IEnumerable<string> selectManyNamesResult = names.SelectMany(name => name.Split(' ')); // => [L, K, M, N, S, F]

        #endregion

        #region Element operators - Imidiate execution

        Product? firstELement = ProductList.FirstOrDefault();
        Product? lastELementOutOfStock = ProductList.LastOrDefault(p => p.UnitsInStock == 23112321); // Default == string("")

        Product? uniquePrice = ProductList.SingleOrDefault(p => p.UnitPrice == 7);

        #endregion

        #region Aggregate - Imidiate execution

        // var mxPrice =  ProductList.Max() ; // Fire exception because Product not implementing IComparable.
        // var mxPrice =  ProductList.Max(p => p.UnitPrice ==5); // returns false


        decimal mxPrice = ProductList.Max(p => p.UnitPrice);
        Console.WriteLine(mxPrice);

        #endregion

        #region Casting operators - Imidiate execution

        List<decimal> prices = ProductList.Select(p => p.UnitPrice).ToList();
        
        Dictionary<long, string> IDwzName = ProductList.ToDictionary(p => p.ProductID, p=> p.ProductName );
        
        
        #endregion

        #region Generator operators

        // Static members from Enumerable class  
        IEnumerable<int> fromOneToTen = Enumerable.Range(1, 10);

        IEnumerable<int> repeat = Enumerable.Repeat(4, 10); // arr[10] = [4, 4, ...., 4]

        #endregion

        #region Union ...

        var seq1 = Enumerable.Range(1, 100);
        var seq2 = Enumerable.Range(50, 150);

        var unionSeq = seq1.Union(seq2); // 1 - 149
        var except = seq1.Except(seq2); // 1 - 49 (values that uniquely exist in seq1 only)
        

        #endregion

        
    }
}