namespace LINQ._2._LINQ_Properties;

public class QueryTypes {
    public static void MainQuerytypes() {
        // Linq queries can be done against any sequence (class implementing IEnumerable<T> interface)
        // Local sequence : L2O (Linq to object) , L2ADO, L2XML
        // Remote sequence (~database) : L2SQL, L2E (LINQ to entity)

        // Input sequences
        List<int> numbers = [4, 3, 5, 7, 12, 124, 98, 48, int.MaxValue];
        List<string> names = ["NAME1", "NAME2", "NAME3"];


        #region Fluent Syntax

        // outputs new sequence
        // IEnumerable<int> outputSequence = numbers.Where(i => i % 4 == 0); same as
        var outputSequence = Enumerable.Where(numbers, i => i % 4 == 0);

        // Outputs single value
        int maxNumber = numbers.Max();
        Console.WriteLine($"Max Number is {maxNumber}");

        #endregion

        #region Query Syntax (Like SQL)

        // This syntax only valid for 40+ Linq operators 
        // Must be start with "from" keyword and ends up with "select" or "Group By" keywrods.
        var resList =
            from num in numbers
            where num % 4 == 0
            select num;

        #endregion
    }
}