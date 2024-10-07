// Used after install SQL client package. 

using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Configuration;

namespace EntityFramework._1.Overview;
// What is ADO .NET? 
// Framework (classes) used to handle relations with databases.
public class Overview {
    public static void MainOverview() {
        SqlConnection sqlCn = new SqlConnection();

        #region Regular connection method

        // // Integrated Security ⇒ true (windows authentication is on)
        // sqlCn.ConnectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security = true";
        //
        // if (sqlCn.State == ConnectionState.Closed)
        //     sqlCn.Open();
        //
        //
        // sqlCn.StateChange += (sender, e) => {
        //     Console.WriteLine($"State Was {e.OriginalState} and changed to {e.CurrentState}");
        // };
        // // Occurs when SQL server returns a warning or information message.
        // sqlCn.InfoMessage += (sender, e) => Console.WriteLine(e.Message);
        //
       

        #endregion


        // Console.WriteLine();

        #region Using App.config

        sqlCn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;
        sqlCn.Open();
        // Console.Read();
        sqlCn.Close();
        Console.WriteLine(ConfigurationManager.AppSettings["BranchID"]);
        

        #endregion
        
        
    }
    
}