using LINQ._3._Examples;

namespace Tasks;

using static ListGenerators;

public class GroupingOperators {
    public static void Main() {
        var numbers = Enumerable.Range(0, 15);
        var groupByRemainder = numbers.GroupBy(num => num % 5);
        foreach (var grouping in groupByRemainder) {
            Console.WriteLine($"Numbers with a remainder of {grouping.Key} when divided by 5:");

            foreach (var i in grouping) 
                Console.WriteLine(i);
            
        }
        
        // =========================================================== //
        var words = LoadWordsFromFile("dictionary_english.txt");
        var groupByFirstWord = words.GroupBy(word => word.First());
        // foreach (var grouping in groupByFirstWord) {
        //     Console.WriteLine("First letter " + grouping.Key);
        //     foreach (var se in grouping) {
        //         Console.WriteLine(se);
        //     }
        //
        //     Console.WriteLine("==================================");
        // }
        
        
        // ======================================== //
        string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

        var groupBySameChars = Arr.GroupBy(word => new string(word.OrderBy(ch => ch).ToArray()));
        
        foreach (var groupBySameChar in groupBySameChars) 
            foreach (var se in groupBySameChar) 
                Console.WriteLine(se);
         

    }
}