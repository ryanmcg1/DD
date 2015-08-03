
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;
using DDWebApp.Models.Log;

namespace DDWebApp.Models.DBLog
{


public class DBLog : Logs
{
    public static void OnEvent(object sender, MessageEventArgs e)
    {
        using (SqlCommand cmd = new SqlCommand())
        {
            cmd.CommandText = "INSERT INTO Log(LogDescription,LogDateCreated)VALUES(@LogDescription,@LogDateCreated)";
            cmd.Parameters.AddWithValue("@LogDescription", e.Message);
            cmd.Parameters.AddWithValue("@LogDateCreated", DateTime.Now);

            DatabaseProvider DBP = new DatabaseProvider();
            //DBP.ExecuteQuery(cmd);
        }
    }

	public override void WriteToLog(string message,MessageType Severity)
	{
        using (SqlCommand cmd = new SqlCommand())
        {
            cmd.CommandText = "INSERT INTO Log(LogDescription,LogDateCreated)VALUES(@LogDescription,@LogDateCreated)";
            cmd.Parameters.AddWithValue("@LogDescription", message);
            cmd.Parameters.AddWithValue("@LogDateCreated", DateTime.Now);

            DatabaseProvider DBP = new DatabaseProvider();
            //DBP.ExecuteQuery(cmd);
        }
	}

    public override void DeleteFromLog(int LogID)
    {

    }

    public override void ClearLog()
    {
       
    }

    public override void WriteToLog(Exception message, Logs.MessageType Severity)
    {
        throw new NotImplementedException();
    }
}
}