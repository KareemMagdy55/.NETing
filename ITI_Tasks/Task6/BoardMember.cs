namespace Lab1.Task6;

class BoardMember : Employee {
    public void Resign() {
        OnEmployeeLayOff(new BoardLayOffEventArgs() {Cause = BoardLayOffArgs.Resigned});
    }
}

public enum BoardLayOffArgs {
    Resigned,
}
class BoardLayOffEventArgs : EmployeeLayOffEventArgs {
    public new BoardLayOffArgs Cause { get; set; }
}