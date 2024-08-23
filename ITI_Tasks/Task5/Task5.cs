namespace Lab1.Task5;

public class Book {
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }

    public Book(string isbn, string title, string[] authors, DateTime publicationDate, decimal price) {
        ISBN = isbn;
        Title = title;
        Authors = authors;
        PublicationDate = publicationDate;
        Price = price;
    }

    public override string ToString() {
        throw new NotImplementedException();
    }
}

public class BookFunctions {
    public static string GetTitle(Book B) {
        throw new NotImplementedException();
    }

    public static string GetAuthors(Book B) {
        throw new NotImplementedException();
    }

    public static string GetPrice(Book B) {
        throw new NotImplementedException();
    }
}

public delegate string BookFunctionDelDT(Book book);

public class LibraryEngine {
    public Func<Book, string> BookFunction1; 
    public static void ProcessBooks(List<Book> bList
        ,  Func<Book, string> fPtr) {
        foreach (Book B in bList) {
            Console.WriteLine(fPtr(B));
        }
    }
}

public class trial {
    public static void Main() {
        Book book = new Book("N/A", "N/A", new []{"N/A","N/A","N/A"}, new DateTime(2024, 1, 1), 1.111M);
        var getISBNAnyFunc = () => book.ISBN;
        var getPDAnyFunc = () => book.PublicationDate;
        Console.WriteLine(getISBNAnyFunc());
        Console.WriteLine(getPDAnyFunc());
    }
}