
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using DDWebApp.Models.MessageEventArgInfo;
using DDWebApp.Models.Database;
using DDWebApp.Models.Log;

namespace DDWebApp.Models.Logger
{


public class DBLog : Logs
{

    public enum LogTypes
    {
        Information = 1,
        Error = 2
    }

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

	public override void WriteToLog(string message)
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
}
}