namespace Lectures.Lec12.BankExample_EventHandler;

public class OverBalanceEventArgs :EventArgs{
    public decimal DiffAmount { get; set; }
    public DateTime TimeStamp { get; set; }
    
}