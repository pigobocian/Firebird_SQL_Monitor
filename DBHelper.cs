using System;
using FirebirdSql.Data.FirebirdClient;

namespace FirebirdSQLMonitor
{
	public class DBHelper
	{
		FbConnection fbConnection;
		String connStr = "";

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

		public bool Connect()
		{
			bool result = false;
			try
			{
				fbConnection = new FbConnection(connStr);
				fbConnection.Open();
				result = true;
			}
			catch (FbException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message);
			}
			catch (ArgumentException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (ObjectDisposedException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (InvalidOperationException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (SystemException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
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
				CommonData.log.Items.Add(e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message);
			}
			catch (ArgumentException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (ObjectDisposedException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (InvalidOperationException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (SystemException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
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
				CommonData.log.Items.Add(e.GetType().Name + ", Error code: " + e.ErrorCode + " - " + e.Message);
			}
			catch (ArgumentException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (ObjectDisposedException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (InvalidOperationException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			catch (SystemException e)
			{
				CommonData.log.Items.Add(e.GetType().Name + " - " + e.Message);
			}
			return fbCommand;
		}
	}
}
