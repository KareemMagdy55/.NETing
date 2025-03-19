namespace ADOUsageExample.Entities;

public class Product : EntityBase {
    // Matched with NorthWindDB product table columns name.
    public int ProductID { get; set; }

    private string productName; 
    public string ProductName {
        get => productName;
        set {
            if (ProductName != value) {
                productName = value;
                if(EntityState != EntityState.Added)
                    EntityState = EntityState.Modified;
            }
        }
    }

    public int? SupplierID { get; set; }
    public int? CategoryID { get; set; }
    public string QuantityPerUnit { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }
    public short? UnitsOnOrder { get; set; }
    public short? ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
}