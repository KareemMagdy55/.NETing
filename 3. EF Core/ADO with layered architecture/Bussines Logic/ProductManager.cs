using System.Data;
using ADOUsageExample.Data_Access;
using ADOUsageExample.Entities;


// Life before entity framework is hell, isn't it? 
namespace ADOUsageExample.Bussines_Logic;

public class ProductManager {
    static DBManager dbManager = new DBManager();

    public static List<Product> SelectAllProducts() {
        try {
            return DataTableToProductList(dbManager.ExecuteDataTable("SelectAllProducts"));
        }
        catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    internal static List<Product> DataTableToProductList(DataTable Dt) {
        try {
            List<Product> products = new List<Product>();
            if (Dt?.Rows?.Count > 0)
                foreach (DataRow row in Dt.Rows) {
                    products.Add(DataRowToProduct(row));
                }

            return products;
        }
        catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }

    internal static Product DataRowToProduct(DataRow Dr) {
        try {
            // Mapping 
            Product product = new Product();
            
            product.ProductID = Dr.Field<int>("ProductID");
            product.ProductName = Dr.Field<string>("ProductName");
            product.SupplierID = Dr.Field<int?>("SupplierID");
            product.CategoryID = Dr.Field<int?>("CategoryID");
            product.QuantityPerUnit = Dr.Field<string>("QuantityPerUnit");
            product.UnitPrice = Dr.Field<decimal?>("UnitPrice");
            product.UnitsInStock = Dr.Field<short?>("UnitsInStock");
            product.UnitsOnOrder = Dr.Field<short?>("UnitsOnOrder");
            product.ReorderLevel = Dr.Field<short?>("ReorderLevel");
            product.Discontinued = Dr.Field<bool>("Discontinued");
            return product;
        }
        catch (Exception e) {
            Console.WriteLine(e);
            throw;
        }
    }
}