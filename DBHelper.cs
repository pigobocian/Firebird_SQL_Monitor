using Firebird_SQL_Monitor;
using FirebirdSql.Data.FirebirdClient;
using System;

namespace FirebirdSQLMonitor
{
	public class DBHelper
	{
		FbConnection FBConnection;
		String ConnStr = "";
		String ErrorMessage = "";

    private static DBHelper Instance = null;

    private DBHelper(Konfiguracja cfg)
		{
			ConnStr = "User=" + cfg.GetDBUserName() + ";" +
								"Password=" + cfg.GetDBPassword() + ";" +
								"Database=" + cfg.GetDBName() + ";" +
								"DataSource=" + cfg.GetDBHost() + ";" +
								"Port=" + cfg.GetDBPort().ToString() + ";" +
								"Dialect=3;" +
								"Charset=" + cfg.GetDBEncoding() + ";" +
								"Connection lifetime=15;" +
								"Pooling=true;" +
								"MinPoolSize=0;" +
								"MaxPoolSize=50;" +
								"ServerType=0;";
		}

		public static DBHelper GetInstance()
		{
			Konfiguracja configuration = Konfiguracja.GetInstance();

      if (Instance == null)
			{
				Instance = new DBHelper(configuration);
			}
			return Instance;
    }

    public bool Connect()
		{
			bool result = false;
			try
			{
				FBConnection = new FbConnection(ConnStr);
				FBConnection.Open();
				string dbgStr = FBConnection.ServerVersion;
        result = IsOpen();
      }
			catch (FbException e)
			{
			ErrorMessage = e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message;

        GlobalLog.LogError(ErrorMessage);
			}
			catch (Exception e)
			{
				ErrorMessage = e.GetType().Name + " - " + e.Message;
        GlobalLog.LogError(ErrorMessage);
			}
			
			return result;
		}

		bool IsOpen()
		{
			bool result = false;
			if (FBConnection != null)
			{
				result = FBConnection.State == System.Data.ConnectionState.Open;
			}
			return result;
    }

    public void Close()
		{
			try
			{
				FBConnection.Close();
			}
			catch (FbException e)
			{
        GlobalLog.LogError(e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message);
			}
			catch (Exception e)
			{
        GlobalLog.LogError(e.GetType().Name + " - " + e.Message);
			}
		}

		public FbCommand GetSQLCommand(String sql)
		{
			FbCommand fbCommand = null;
			try
			{
				fbCommand = new FbCommand(sql, FBConnection);
			}
			catch (FbException e)
			{
        GlobalLog.LogError(e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message);
			}
			catch (Exception e)
			{
        GlobalLog.LogError(e.GetType().Name + " - " + e.Message);
			}
			return fbCommand;
		}

		public string GetErrorMessage()
		{
			return ErrorMessage;
    }	
  }
}
