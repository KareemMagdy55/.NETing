namespace Lectures.Lec12.BankExample_EventHandler;

public class EnterpriseBankAcc : Account{

    public bool Transfer(Account BankAcc, int salary) {
        if (salary <= this.Balance && salary > 0) {
            this.Balance -= salary;
            BankAcc.Balance += salary;

            return true; 
        }
        else {
            // Not valid to be accessed in children' class(es)
            // OverBalance?.Invoke(this, new OverBalanceEventArgs());
            
            OnOverBalance(new OverBalanceEventArgs() { DiffAmount = salary - Balance, TimeStamp = new DateTime(2025, 1, 1) });
            return false;
        }
    }
}