using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace EntityFramework._1.Overview;

public class Example3 {
    public static void Main() {
        SqlConnection sqlCn = new SqlConnection();
        sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;

        SqlCommand sqlCommand = new SqlCommand("select * from Products where UnitsInStock > @UnitsInStock", sqlCn);
        sqlCommand.Parameters.AddWithValue("@UnitsInStock", 5);
        
        // Sql data adapters is used to retrieve data from a data source,
        // edit it and then publish it again to the data source.
        SqlDataAdapter DA = new SqlDataAdapter(sqlCommand);
        DataTable DT = new DataTable();
        

        // Open Connections, execute command and Fetching data into datatable
        // ALl results are available in memory (BAD)
        DA.Fill(DT);
        // DT.Columns["ProductID"].ReadOnly = true; 
        
        Console.WriteLine(DT.Rows[0]["ProductName"] + " " + DT.Rows[0]["UnitsInStock"]);
        Debug.WriteLine(DT.Rows[0].RowState); // Can be seen in the Debug console




        SqlDataAdapter sqlCmdSuppliers;
        SqlCommand sqlCmdGetSuppliers = new SqlCommand(@$"Select SupplierID as SID, CompanyName from Suppliers", sqlCn);
      
        sqlCmdSuppliers = new SqlDataAdapter(sqlCmdGetSuppliers);
        DataTable suppliersDT = new DataTable();
        sqlCmdSuppliers.Fill(suppliersDT);
        
        Console.WriteLine(suppliersDT.Rows[0]["SID"] + " " + suppliersDT.Rows[0]["CompanyName"]);

        

        // Here with data adapters, connection closed automatically.
    }
}