using LINQ._3._Examples;

namespace Tasks;

using static ListGenerators;

public class PartitioningOperators {
    public static void MainPartitioningOperators() {
        var firstThreeAtWA = CustomerList.Where(customer => customer.Region == "WA").Take(3).Select(c => c.CompanyName.Split().First());
        firstThreeAtWA.PrintList();
        
        // =============================================== //
        var allExceptFirst2 = CustomerList.Where(customer => customer.Region == "WA").Skip(2).Select(c => c.CompanyName.Split().First());
        allExceptFirst2.PrintList();
        
        // ============================================= //
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        var indexedNumbers = numbers.Select((num, idx) => new { Num = num, Index = idx });

        var result = indexedNumbers
            .TakeWhile(x => x.Num >= x.Index)
            .Select(x => x.Num);
        
        foreach (var num in result)
            Console.Write(num + ", ");
        Console.WriteLine();
        
        // ============================================== //

        result = numbers.SkipWhile(x => x % 3 != 0);
        foreach (var num in result)
            Console.Write(num + ", ");
        Console.WriteLine();
        // ====================================== //
        var res = indexedNumbers.SkipWhile(x => x.Num >= x.Index).Select(x=> x.Num);
        foreach (var num in res)
            Console.Write(num + ", ");
        
        // ============================================= //
        




    }
}