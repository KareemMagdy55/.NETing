namespace Lectures.Lec12.BankExample_EventHandler;

public class Account {
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }


    public bool Credit(int amount) {
        if (amount > 0) {
            Balance += amount;
            return true;
        }

        return false;
    }

    public bool Debit(int amount) {
        if (amount > 0 && amount <= Balance) {
            Balance -= amount;
            return true;
        }

        // Notify subs
        OnOverBalance(
            new OverBalanceEventArgs() { DiffAmount = amount - Balance, TimeStamp = new DateTime(2025, 1, 1) });
        return false;
    }

    public override string ToString() {
        return $"ID{ID}::Name{Name}";
    }

 
    public event EventHandler<OverBalanceEventArgs> OverBalance;
 
    protected virtual void OnOverBalance(OverBalanceEventArgs eventArgs) {
        OverBalance?.Invoke(this, eventArgs);
    }
}