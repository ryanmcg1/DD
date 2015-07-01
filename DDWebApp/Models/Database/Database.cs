using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;
using System.Web;
using DDWebApp.Models.MessageEventArgInfo;
using System.Data;
using System.Reflection;

namespace DDWebApp.Models.Database
{

    public class DatabaseProvider
    {
        private Idal _dal;
        public event EventHandler<MessageEventArgs> OnExecuteQuery;

        #region Constructors

        public DatabaseProvider()
        {
            _dal = new SqlServer();
        }

        public DatabaseProvider(Idal dal)
        {
            _dal = dal;
        } 
        #endregion
        


        
        public void ExecuteQuery(string query)
        {         
                _dal.ExecuteQuery(query);
        }

        public DataSet ReturnDataset(string Query)
        {
            return _dal.ReturnDataset(Query);
        }

        public bool ExecuteStoredProc(Dictionary<string, object> Query, string StoredProcName)
        {
            try
            {
                _dal.ExecuteStoredProc(Query, StoredProcName);
                OnDatabaseQueryEvent(Query.ToString());

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }



        protected virtual void OnDatabaseQueryEvent(string query)
        {
            if (OnExecuteQuery != null)
                OnExecuteQuery(this, new MessageEventArgs(query));
        }


        //public static DataSet ReturnDataset(SqlCommand query)
        //{
        //    return ReturnDataset(query.CommandText);
        //}


        //private static SqlConnection Connect()
        //{
        //    return new SqlConnection(WebConfigurationManager.ConnectionStrings["conString"].ConnectionString);
        //}


        //public bool ExecuteQuery(SqlCommand query)
        //{
        //    using (SqlConnection conn = Connect())
        //    {
        //        try
        //        {
        //            OnDatabaseQueryEvent(query.CommandText);
        //            conn.Open();
        //            query.Connection = conn;
        //            query.ExecuteNonQuery();

        //            return true;

        //            //conn.Close(); //Not needed with using.
        //        }
        //        catch (SqlException ex)
        //        {
        //            throw ex;
        //        }
        //    }
        //}

    }
}