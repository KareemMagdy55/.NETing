namespace Lectures;

public class PhoneBook {
    private string[] names;
    private int[] numbers;

    
    // Indexer that takes [name] as input and outputs a 'number'
    // Input parameter can be more than one 
    public int this[string Name] {
        get {
            for(int i = 0 ; i < names?.Length; i ++)
                if (names[i] == Name)
                    return i;
            return -1; 
        }
        set {
            for(int i = 0 ; i < names?.Length; i ++)
                if (names[i] == Name) {
                    numbers[i] = value;
                    break; 
                }
        }
    }
}