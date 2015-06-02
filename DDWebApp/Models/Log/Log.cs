
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;

namespace DDWebApp.Models.Logger
{


public class LogInfo
{
    
    public void OnEvent(object sender, MessageEventArgs e)
    {
        using (SqlCommand cmd = new SqlCommand())
        {
            cmd.CommandText = "INSERT INTO Log(LogDescription,LogDateCreated)VALUES(@LogDescription,@LogDateCreated)";
            cmd.Parameters.AddWithValue("@LogDescription", e.Message);
            cmd.Parameters.AddWithValue("@LogDateCreated", DateTime.Now);

            DatabaseProvider DBP = new DatabaseProvider();
            DBP.ExecuteQuery(cmd);
        }
    }

	public static void WriteLog(string message)
	{
        using (SqlCommand cmd = new SqlCommand())
        {
            cmd.CommandText = "INSERT INTO Log(LogDescription,LogDateCreated)VALUES(@LogDescription,@LogDateCreated)";
            cmd.Parameters.AddWithValue("@LogDescription", message);
            cmd.Parameters.AddWithValue("@LogDateCreated", DateTime.Now);

            DatabaseProvider DBP = new DatabaseProvider();
            DBP.ExecuteQuery(cmd);
        }
	}
}
}