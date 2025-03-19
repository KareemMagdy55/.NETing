using System.Text;

namespace Lectures.Lec12.BankExample_EventHandler;

public class BlackList {
    private static List<string> BList= [];
    public static int Size => BList.Count;

    public static void AddToBList(object? sender, OverBalanceEventArgs eventArgs) {
        if (sender is Account acc && !BList.Contains(acc.Name) && Math.Abs(eventArgs.DiffAmount) > 500) {
            BList.Add(acc.Name);
        }
    }

    public static string BListContent() {
        // Here string builder usage is better than string usage
        // because string is immutable datatype,
        // so each append a new object in memory will be created 
        StringBuilder str = new StringBuilder();

        foreach (var ele in BList) 
            str.Append(ele).Append(", ");
        

        return str.ToString();
    }
}