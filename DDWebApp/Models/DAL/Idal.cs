using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDWebApp.Models.Database
{
    public interface Idal 
    {
        void ExecuteQuery(string query);
        DataSet ReturnDataset(string Query);
        void ExecuteStoredProc(Dictionary<string, object> Query, string StoredProcName);
    }
}
