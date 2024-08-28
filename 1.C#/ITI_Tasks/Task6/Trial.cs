namespace Lab1.Task6;

public class Trial {
    public static void Main() {
        Employee emp1 = new Employee() {
            BirthDate = new DateTime(1963, 6, 6),
            EmployeeID = 101,
            VacationStock = 21
        };
        Employee emp2 = new Employee() {
            BirthDate = new DateTime(1990, 7, 6),
            EmployeeID = 102,
            VacationStock = -1
        };
        Employee emp3 = new Employee() {
            BirthDate = new DateTime(1980, 8, 6),
            EmployeeID = 104,
            VacationStock = 21
        };

        Department Dept1 = new Department() {
            DeptID = 1209,
            DeptName = "DEPT1"
        };
        Club Club1 = new Club() {
            ClubID = 908,
            ClubName = "CLUB1"
        };
        
        Dept1.AddStaff(emp1);
        Dept1.AddStaff(emp2);
        Dept1.AddStaff(emp3);
        
        Club1.AddMember(emp1);
        Club1.AddMember(emp2);
        Club1.AddMember(emp3);
        
        emp1.EmployeeLayOff += Dept1.RemoveStaff;
        emp1.EmployeeLayOff += Club1.RemoveMember;

        // ---------------------------------------------//
        emp2.EmployeeLayOff += Dept1.RemoveStaff;
        emp2.EmployeeLayOff += Club1.RemoveMember;

        // ---------------------------------------------//
        
        emp3.EmployeeLayOff += Dept1.RemoveStaff;
        emp3.EmployeeLayOff += Club1.RemoveMember;
        
        
        emp1.EndOfYearOperation();
        emp2.RequestVacation(new DateTime(2024, 12, 6), new DateTime(2024, 12, 10));
        emp3.RequestVacation(new DateTime(2024, 12, 6), new DateTime(2024, 12, 10));

        Console.WriteLine("===================================================================================");


        SalesPerson salesPerson1 = new SalesPerson() {
            AchievedTarget = 32,
            BirthDate = new DateTime(1980, 6, 6),
            EmployeeID = 115,
            VacationStock = 21
        };

        BoardMember boardMember1 = new BoardMember() {
            BirthDate = new DateTime(200, 6, 6),
            EmployeeID = 184,
            VacationStock = 21,
        };
        
        Department Dept2 = new Department() {
            DeptID = 1208,
            DeptName = "DEPT2"
        };
        Club Club2 = new Club() {
            ClubID = 907,
            ClubName = "CLUB3"
        };
        
        Dept2.AddStaff(salesPerson1);
        Dept2.AddStaff(boardMember1);
        
        Club2.AddMember(salesPerson1);
        Club2.AddMember(boardMember1);

        salesPerson1.EmployeeLayOff += Dept2.RemoveStaff;
        salesPerson1.EmployeeLayOff += Club2.RemoveMember;


        boardMember1.EmployeeLayOff += Dept2.RemoveStaff;

        salesPerson1.CheckTarget(100);
        boardMember1.Resign();
        
    }
}