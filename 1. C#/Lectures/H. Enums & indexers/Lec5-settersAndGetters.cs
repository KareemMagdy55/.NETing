namespace Lectures;

public struct Student {
    private string id;
    private string name; 
    
    // ID property is the only gate to manipulate 'id' 
    public string ID {
        set => id = value;
        get => id;
    }

    // Name property is the only gate to manipulate 'name' 
    public string Name {
        set => name = value;
        internal get => name;
    }
    // student.ID = 123 ; valid (use setter)
    // Console.writeline(student.Name) ; valid (use getter)

    // Age property without age variable in Student struct
    public int Age {
        get => int.Parse(id.Substring(3, 5));
    }
    
    
}
//21