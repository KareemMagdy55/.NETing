namespace LINQ._2._LINQ_Properties;

public class DefferdExecution {
    public static void MainDefferdExecution() {
        List<int> numbers = [1, 2, 3, 4, 5, 7, 8, 9, 10];

        #region Defferd Execution

        // var result = numbers.Where(i => i % 2 == 0);
        // Console.WriteLine(result.GetType()); // System.Linq.Enumerable+WhereListIterator`1[System.Int32]
        // // WhereList iterator holds reference to data and the anonymous function in Where operator.
        //
        // numbers.AddRange([11, 12, 13, 14, 15, 16]);
        //
        // // Here the execution of numbers.Where(i => i % 2 == 0) done
        // // So, the even numbers after 10 to 16 will be included in the result
        // foreach (var number in result) 
        //     Console.Write(number + ", "); // Prints: 2, 4, 8, 10, 12, 14, 16,
        
        

        #endregion

        #region Imeidiate Excution

        var result = numbers.Where(i => i % 2 == 0).ToList();
        
        numbers.AddRange([11, 12, 13, 14, 15, 16]);
       
        // // The even numbers after 10 to 16 will not be included in the result
        foreach (var number in result) 
            Console.Write(number + ", "); // Prints: 2, 4, 8, 10, 12, 14, 16,

        #endregion
    }
}