using System.Collections;

namespace HelloWorld.Lec_10;

internal class GenericsCollections {
    static void Main(string[] args) {

        #region Non Generic Collections (ArrayList)
        // Before generics
        ArrayList arrayList = new ArrayList();
        
        
        // The following statement is an example of "boxing"
        // because int values is going to be saved in heap
        // because Add() takes object as a parameter.
        arrayList.Add(3); 

        // Going to accept any type (Compiler cannot enforce type safety at compile time).
        arrayList.Add("N/A");
        arrayList.Add(3.5);
        arrayList.AddRange(new int[] { 4, 5, 6, 7 });

        int sum = 0; 
        for (var i = 0; i < arrayList.Count; i++) {
            var element = arrayList[i];
            sum += (int)element; // Unboxing (NOT SAFE)
        }

        Console.WriteLine(sum); // Fires exception

        #endregion


        #region Generic Collection (List)

        List<int> lst = new List<int>();

        Console.WriteLine($"Size {lst.Count}, Capacity {lst.Capacity}");

        lst.Add(1);
        lst.Add(2);
        // lst.Add("N/A"); // Compiler Enforce type safety during compilation time
        lst.AddRange(new []{3, 4, 5, 6});
        
        lst.TrimExcess(); // Make the capacity = size (No wasting)

        #endregion
        
        #region Generic Collection (Dictionary)

        Dictionary<string, long> PhoneBook = new Dictionary<string, long>();
        PhoneBook.Add("ABC", 123); 
        PhoneBook.Add("DEF", 456);

        // PhoneBook.Add("ABC", 123); ... Fires exception : key must be unique 

        PhoneBook["ABC"] = 528; // Update
        PhoneBook["LEO"] = 198; // Add 
        
        // More safe ways
        if (PhoneBook.ContainsKey("ABC"))
            PhoneBook.Add("ABC", 123);
        
        if (PhoneBook.TryGetValue("ABC", out long v))
            Console.WriteLine(v);

        foreach (KeyValuePair<string, long> item in PhoneBook) {
            Console.WriteLine($"{item.Key}:::{item.Value}");
        }
        

        #endregion

    }
}