namespace Lab1.Task3;

public enum NIC_TYPE {
    TYPE1, 
    TYPE2,
    TYPE3
}
// Device has only one NIC card.
public class NIC {
    public string Manufacture { get; set; }
    public string MAC_ADDRESS { get; set; }
    public NIC_TYPE NicType { get; set; }

    private NIC(string manufacture, string macAddress, NIC_TYPE nicType) {
        Manufacture = manufacture;
        MAC_ADDRESS = macAddress;
        NicType = nicType;
    }

    public static NIC GetCard { get; } = new NIC("N/A", "N/A", NIC_TYPE.TYPE1);
}
