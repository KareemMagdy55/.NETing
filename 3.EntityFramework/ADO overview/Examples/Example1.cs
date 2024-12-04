using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EntityFramework._1.Overview;

public class Example1 {
    public static void MainSQLCommands() {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString);
        SqlCommand sqlCommand = new SqlCommand(); 
        
        sqlConnection.Open();

        sqlCommand.Connection = sqlConnection;
        // sqlCommand.CommandText = "select count(*) from Products";
        
        // ExecuteScalar used for Aggregate functions commands 
        // int totalProducts = (int)sqlCommand.ExecuteScalar();

        // ExcuteNonQuery a command that doesn't return a set of rows (Insert, delete,....), Just returns rows affected
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.CommandText = "UpdateProductNameByProductID";
        
        sqlCommand.Parameters.Add("@ProductID", SqlDbType.Int);
        sqlCommand.Parameters.Add("@ProductName", SqlDbType.NVarChar,40);

        sqlCommand.Parameters["@ProductID"].Value =1 ;
        sqlCommand.Parameters["@ProductName"].Value = "Chai2";

        // Open SQL server profiler to notice changes ...
        int rowsAffected = sqlCommand.ExecuteNonQuery();

        Console.WriteLine(rowsAffected);
        sqlConnection.Close();
    }
}