namespace Lectures.Lec12.BankExample_EventHandler;

public class CustomerAgent {
    public string Name { get; set; }

    public void ContactCustomer(object sender, EventArgs eventArgs) {
        if (sender is Account BankAcc) {
            Console.WriteLine($"Contacting {BankAcc.Name}.....");
        }
    }
    
}