using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;
using System.Web;
using DDWebApp.Models.MessageEventArgInfo;
using System.Data;

namespace DDWebApp.Models.Database
{

    public class DatabaseProvider
    {
        public event EventHandler<MessageEventArgs> OnExecuteQuery;

        public void ExecuteQuery(string query)
        {
            using (SqlConnection conn = Connect())
            using (SqlCommand cmd = conn.CreateCommand())
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    //conn.Close(); //Not needed with using.
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool ExecuteQuery(SqlCommand query)
        {
            using (SqlConnection conn = Connect())
            {
                try
                {
                    OnDatabaseQueryEvent(query.CommandText);
                    conn.Open();
                    query.Connection = conn;
                    query.ExecuteNonQuery();

                    return true;

                    //conn.Close(); //Not needed with using.
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }

        public static DataSet ReturnDataset(string query)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = Connect())
            {
                using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    try
                    {
                        using (SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCommand))
                        {
                            sqlDA.Fill(ds);
                        }
                        return ds;
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
            }
        }

        public bool ExecuteStoredProc(SqlCommand query, string StoredProcName)
        {
            using (SqlConnection conn = Connect())
            {
                try
                {
                    OnDatabaseQueryEvent(query.CommandText);
                    conn.Open();
                    query.CommandText = StoredProcName;
                    query.CommandType = CommandType.StoredProcedure;
                    query.Connection = conn;
                    query.ExecuteNonQuery();

                    return true;

                    //conn.Close(); //Not needed with using.
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }


        public static DataSet ReturnDataset(SqlCommand query)
        {
            return ReturnDataset(query.CommandText);
        }

        private static SqlConnection Connect()
        {
            return new SqlConnection(WebConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        }

        protected virtual void OnDatabaseQueryEvent(string query)
        {
            if (OnExecuteQuery != null)
                OnExecuteQuery(this, new MessageEventArgs(query));
        }
    }
}