using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install ODP
//using Oracle.DataAccess.Client; // ODP.NET Oracle managed provider
//using Oracle.DataAccess.Types;
//http://www.oracle.com/technetwork/topics/dotnet/index-085163.html

namespace DDWebApp.Models.Database
{
    class OracleServer : Idal
    {


        public void Idal()
        {
            throw new NotImplementedException();
        }

        public void ReturnDataset()
        {
            throw new NotImplementedException();
        }

        public void ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataSet ReturnDataset(string Query)
        {
            throw new NotImplementedException();
        }

        public void ExecuteStoredProc(Dictionary<string, object> Query, string StoredProcName)
        {
            throw new NotImplementedException();
        }
    }
}