namespace Lectures.Lec12.BankExample_EventHandler;

public class BankExampleTrial {
    public static void Main() {
        Account B1 = new Account() {
            ID = 101,
            Balance = 10_000,
            Name = "Joe"
        };
        Account B2 = new Account() {
            ID = 102,
            Balance = 20_000,
            Name = "John"
        };
        Account B3 = new Account() {
            ID = 103,
            Balance = 30_000,
            Name = "Doe"
        };

        CustomerAgent C1 = new CustomerAgent() { Name = "AG01" };
        CustomerAgent C2 = new CustomerAgent() { Name = "AG02" };

        B1.OverBalance += C1.ContactCustomer;
        B1.OverBalance += BlackList.AddToBList; 
        
        
        B2.OverBalance += C2.ContactCustomer;
        B2.OverBalance += BlackList.AddToBList;


        B1.Debit(5000);
        B1.Debit(5600);

        EnterpriseBankAcc CompanyX = new EnterpriseBankAcc() {
            Balance = 1000,
            ID = 213,
            Name = "CompanyX"
        };

        CompanyX.OverBalance += C1.ContactCustomer;
        CompanyX.OverBalance += BlackList.AddToBList;

        CompanyX.Transfer(B2, 2000);    
    
        Console.WriteLine(BlackList.BListContent()); // Prints Joe (First Account) , ComapnyX
    }
}