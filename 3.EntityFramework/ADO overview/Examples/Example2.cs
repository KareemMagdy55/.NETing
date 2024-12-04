using System.Configuration;
using System.Data.SqlClient;

namespace EntityFramework._1.Overview;

public class Example2 {
    public static void MainExample2() {
        SqlConnection sqlCn = new SqlConnection();
        sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;

        SqlCommand getProducts = new SqlCommand("select ProductName from Products", sqlCn);
        sqlCn.Open();

        SqlDataReader dr = getProducts.ExecuteReader();

        while (dr.Read()) 
            Console.WriteLine(dr["ProductName"].ToString());
        

        // Connection must be closed when use data readers
        sqlCn.Close();
        Console.WriteLine(ConfigurationManager.AppSettings["BranchID"]);
    }
}