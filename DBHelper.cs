using Firebird_SQL_Monitor;
using FirebirdSql.Data.FirebirdClient;
using System;

namespace FirebirdSQLMonitor
{
	public class DBHelper
	{
		FbConnection fbConnection;
		String connStr = "";

		private static DBHelper instance = null;

    public DBHelper(Konfiguracja cfg)
		{
			connStr = "User=" + cfg.GetDBUserName() + ";" +
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

      if (instance == null)
			{
				instance = new DBHelper(configuration);
			}
			return instance;
    }

    public bool Connect()
		{
			bool result = false;
			try
			{
				fbConnection = new FbConnection(connStr);
				fbConnection.Open();
				string dbgStr = fbConnection.ServerVersion;
        result = IsOpen();
      }
			catch (FbException e)
			{
        GlobalLog.LogMessage(e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message);
			}
			catch (Exception e)
			{
        GlobalLog.LogMessage(e.GetType().Name + " - " + e.Message);
			}
			
			return result;
		}

		bool IsOpen()
		{
			bool result = false;
			if (fbConnection != null)
			{
				result = fbConnection.State == System.Data.ConnectionState.Open;
			}
			return result;
    }

    public void Close()
		{
			try
			{
				fbConnection.Close();
			}
			catch (FbException e)
			{
        GlobalLog.LogMessage(e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message);
			}
			catch (Exception e)
			{
        GlobalLog.LogMessage(e.GetType().Name + " - " + e.Message);
			}
		}

		public FbCommand GetSQLCommand(String sql)
		{
			FbCommand fbCommand = null;
			try
			{
				fbCommand = new FbCommand(sql, fbConnection);
			}
			catch (FbException e)
			{
        GlobalLog.LogMessage(e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message);
			}
			catch (Exception e)
			{
        GlobalLog.LogMessage(e.GetType().Name + " - " + e.Message);
			}
			return fbCommand;
		}
	}
}
