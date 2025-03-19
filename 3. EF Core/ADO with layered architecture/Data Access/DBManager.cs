using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADOUsageExample.Data_Access;

public class DBManager {
    private SqlConnection sqlConnection;
    private SqlCommand sqlCommand;
    private SqlDataAdapter sqlDataAdapter;
    private DataTable dataTable;


    public DBManager() {
        sqlConnection = new SqlConnection();
        sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["NorthWindCN"].ConnectionString;
        
        sqlCommand = new SqlCommand();
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection = sqlConnection;
        
        sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        dataTable = new DataTable();

    }
    public int ExecuteNonQuery(string commandText) {
        int rowsAffected = -1; 
        try {
            if (sqlConnection?.State == ConnectionState.Closed) {
                sqlCommand.CommandText = commandText;
                sqlCommand.Parameters.Clear();

                rowsAffected = sqlCommand.ExecuteNonQuery();
                
                sqlConnection.Close();
            }
        }
        catch (Exception e)
        {
        
        }

        return rowsAffected;
    } 
    
    public object ExecuteScalar(string commandText) {
        object row = -1; 
        try {
            if (sqlConnection?.State == ConnectionState.Closed) {
                sqlCommand.CommandText = commandText;
                sqlCommand.Parameters.Clear();

                row = sqlCommand.ExecuteNonQuery();
                
                sqlConnection.Close();
            }
        }
        catch (Exception e)
        {
        
        }

        return row;
    }    
    public DataTable ExecuteDataTable(string commandText) {
        dataTable.Clear();
        try {
                sqlCommand.CommandText = commandText;
                sqlCommand.Parameters.Clear();
                
 
                sqlDataAdapter.Fill(dataTable);      
                sqlConnection.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return dataTable;
    }

    public void Update() {
          
        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
        sqlDataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
        sqlDataAdapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();
        sqlDataAdapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();

        sqlDataAdapter.Update(dataTable);
    }
    

}