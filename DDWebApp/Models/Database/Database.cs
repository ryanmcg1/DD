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
            _dal.ExecuteStoredProc(Query, StoredProcName);
            OnDatabaseQueryEvent(Query.ToString());

            return true; 
        }



        protected virtual void OnDatabaseQueryEvent(string query)
        {
            if (OnExecuteQuery != null)
                OnExecuteQuery(this, new MessageEventArgs(query));
        }
    }
}