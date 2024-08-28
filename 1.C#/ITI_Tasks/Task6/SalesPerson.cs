namespace Lab1.Task6;

class SalesPerson : Employee {
    public int AchievedTarget { get; set; }

    public bool CheckTarget(int Quota) {
        if (Quota > AchievedTarget) {
            OnEmployeeLayOff(new SalesLayOffEventArgs() { Cause = SalesLayOffArgs.DidNotAchieveTarget });
            return false;
        }
        else {
            return true; 
        }
    }

    public bool RequestVacation() {
        return true;
    }
}

public enum SalesLayOffArgs {
    DidNotAchieveTarget,
}
class SalesLayOffEventArgs : EmployeeLayOffEventArgs {
    public new SalesLayOffArgs Cause { get; set; }
}