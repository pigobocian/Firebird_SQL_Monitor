using Firebird_SQL_Monitor;
using System;
using System.IO;
using System.Windows.Forms;

namespace FirebirdSQLMonitor
{
	public class Konfiguracja
	{
		public const String INI_FILENAME = "config.ini";

		/// <summary>
		/// Klucze używane w pliku INI
		/// </summary>
		public const String INI_MAIN_SQL = "MAIN_SQL";
		public const string INI_USERS_SQL = "USERS_SQL";s
    public const String INI_DBHOST = "DBHOST";
		public const String INI_DBPORT = "DBPORT";
		public const String INI_DBFILENAME = "DBFILENAME";
		public const String INI_DBUSERNAME = "DBUSERNAME";
		public const String INI_DBPASSWORD = "DBPASSWORD";
		public const String INI_DBENCODING = "DBENCODING";

		/// <summary>
		/// Wartości kluczy pliku INI
		/// </summary>
		private String sql;
		private String dbHost;
		private int dbPort;
		private String dbFileName;
		private String dbUsername;
		private String dbPassword;
		private String dbEncoding;

		private static Konfiguracja instance = null;

    // Prywatny konstruktor - singleton
    private Konfiguracja()
		{
			// Ustawienia domyślne
			sql = "select 'a','b',1,2,3,4 from RDB$DATABASE";
			dbHost = "localhost";
			dbPort = 3050;
			dbFileName = ""; 
		}


    public static Konfiguracja GetInstance()
		{
			if (instance == null)
			{
				instance = new Konfiguracja();
			}
			return instance;
    }


    public void SetSQL(String sql)
		{
			this.sql = sql;
		}

		public void SetDBHost(String dbHost)
		{
			this.dbHost = dbHost;
		}

		public void SetDBPort(int dbPort)
		{
			this.dbPort = dbPort;
		}

		public void SetDBName(String dbName)
		{
			this.dbFileName = dbName;
		}

		public void SetDBUserName(String dbUserName)
		{
			this.dbUsername = dbUserName;
		}

		public void SetDBPassword(String dbPassword)
		{
			this.dbPassword = dbPassword;
		}

		public void SetDBEncoding(String dbEncoding)
		{
			this.dbEncoding = dbEncoding;
		}

		// ------------------------------------------------------

		public String GetSQL()
		{
			return this.sql;
		}

		public String GetDBHost()
		{
			return this.dbHost;
		}

		public int GetDBPort()
		{
			return this.dbPort;
		}

		public String GetDBName()
		{
			return this.dbFileName;
		}

		public String GetDBUserName()
		{
			return this.dbUsername;
		}

		public String GetDBPassword()
		{
			return this.dbPassword;
		}

		public String GetDBEncoding()
		{
			return this.dbEncoding;
		}

		/// <summary>
		/// Zapsuje plik konfiguracyjny. Do nazwy pliku dodawana jest ścieżka 
		/// aktualnie uruchominej aplikacji
		/// </summary>
		/// <returns>Zwraca true jeśli zapis się powiedzie i false w przeciwnym razie</returns>
		public bool SaveConfig()
		{
			bool result = false;
			try
			{
				string exePath = Application.StartupPath;
				if (!exePath.EndsWith(@"\")) exePath += @"\";

				var ini = new MyIniFile(exePath + INI_FILENAME);
				if (ini.Read())
				{
					ini.Add(INI_MAIN_SQL, sql);
					ini.Add(INI_DBHOST, this.dbHost);
					ini.Add(INI_DBPORT, this.dbPort.ToString());
					ini.Add(INI_DBFILENAME, this.dbFileName);
					ini.Add(INI_DBUSERNAME, this.dbUsername);
					ini.Add(INI_DBPASSWORD, this.dbPassword);
					ini.Add(INI_DBENCODING, this.dbEncoding);
					result = ini.Save();
				}
			}
			catch (Exception e)
			{
        GlobalLog.LogMessage(e.GetType().Name + " - " + e.Message);
			}
			return result;
		}

		/// <summary>
		/// Wczytuje konfigurację z pliku 
		/// </summary>
		/// <returns>Zwraca true jeśli odczyt się powiedzie i false w przeciwnym razie</returns>
		public bool LoadConfig()
		{
			bool result = false;
			try
			{
				string exePath = Application.StartupPath;
				if (!exePath.EndsWith(@"\")) exePath += @"\";

				var ini = new MyIniFile(exePath + INI_FILENAME);
				if (ini.Read())
				{
					// Sprawdzam czy jako SQL nie podano przypadkiem nazwy pliku
					// jeśli wkazany plik istnieje - należy go wczytać
					sql = ini.Get(INI_MAIN_SQL, "select 'a','b',1,2,3,4 from RDB$DATABASE");
					if (File.Exists(sql))
					{
						sql = File.ReadAllText(sql);
					}

					dbHost = ini.Get(INI_DBHOST, "");
					String buf = ini.Get(INI_DBPORT, "");
					if (buf != null && buf != "") dbPort = Int32.Parse(buf);
					dbFileName = ini.Get(INI_DBFILENAME, "");
					dbUsername = ini.Get(INI_DBUSERNAME, "");
					dbPassword = ini.Get(INI_DBPASSWORD, "");
					dbEncoding = ini.Get(INI_DBENCODING, "");
					result = true;
				}
			}
			catch (Exception e)
			{
        GlobalLog.LogMessage(e.GetType().Name + " - " + e.Message);
			}
			return result;
		}

	}
}
