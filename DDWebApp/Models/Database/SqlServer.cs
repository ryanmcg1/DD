using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace DDWebApp.Models.Database
{
    public class SqlServer : Idal
    {

        //Handles all SqlConnection operations
        public string Name = "SQL";
        SqlConnection sqlConn;

        public SqlServer()
        {
            sqlConn = new SqlConnection(WebConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        }

        public void ExecuteStoredProc(Dictionary<string, object> Query, string StoredProcName)
        {
            try
            {
                
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlConn.Open();

                    foreach (KeyValuePair<string, object> item in Query)
                    {
                        sqlCommand.Parameters.AddWithValue(item.Key, item.Value);
                    }
                    sqlCommand.CommandText = StoredProcName;
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Connection = sqlConn;
                    sqlCommand.ExecuteNonQuery();
                    sqlConn.Close();
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ExecuteQuery(string query)
        {
            try
            {               
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    sqlCommand.CommandText = query;
                    sqlCommand.ExecuteNonQuery();
                    sqlConn.Close();
                }  
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet ReturnDataset(string Query)
        {
            DataSet ds = new DataSet();
            using (SqlCommand sqlCommand = new SqlCommand(Query, sqlConn))
            try
            {
                using (SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCommand))
                {
                    sqlConn.Open();
                    sqlDA.Fill(ds);
                    sqlConn.Close();
                }
                return ds;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

     
    }
}