using Firebird_SQL_Monitor;
using System;
using System.IO;
using System.Text;
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
    public const string INI_USERS_SQL = "USERS_SQL";
    public const String INI_DBHOST = "DBHOST";
    public const String INI_DBPORT = "DBPORT";
    public const String INI_DBFILENAME = "DBFILENAME";
    public const String INI_DBUSERNAME = "DBUSERNAME";
    public const String INI_DBPASSWORD = "DBPASSWORD";
    public const String INI_DBENCODING = "DBENCODING";

    /// <summary>
    /// Wartości kluczy pliku INI
    /// </summary>
    private String SQL;
    private String DBHost;
    private int DBPort;
    private String DBFileName;
    private String DBUsername;
    private String DBPassword;
    private String DBEncoding;
    private String ConfigPath;


    private String QueryFile = "";

    public enum ConfigFileStatus
    {
      Created,
      Exists,
      Error
    } 
    readonly ConfigFileStatus configFileStatus;
    

    private static Konfiguracja instance = null;

    // Prywatny konstruktor - singleton
    private Konfiguracja()
    {
      // Ustawienia domyślne
      SQL = "select 'a','b',1,2,3,4 from RDB$DATABASE";
      DBHost = "localhost";
      DBPort = 3050;
      DBFileName = "";

      configFileStatus = CheckMustCreateConfigFile();
    }


    public static Konfiguracja GetInstance()
    {
      if (instance == null)
      {
        instance = new Konfiguracja();
      }
      return instance;
    }

    public ConfigFileStatus GetConfigFileStatus()
    {
      return configFileStatus;
    } 
    
    public String GetSQL()
    {
      return this.SQL;
    }

    public String GetDBHost()
    {
      return this.DBHost;
    }

    public int GetDBPort()
    {
      return this.DBPort;
    }

    public String GetDBName()
    {
      return this.DBFileName;
    }

    public String GetDBUserName()
    {
      return this.DBUsername;
    }

    public String GetDBPassword()
    {
      return this.DBPassword;
    }

    public String GetDBEncoding()
    {
      return this.DBEncoding;
    }

    public String GetConfigPath()
    {
      return this.ConfigPath;
    }

    public void SetSQL(String sql)
    {
      this.SQL = sql;
    } 

    public void SetDBHost(String host)
    {
      this.DBHost = host;
    } 

    public void SetDBPort(int port)
    {
      this.DBPort = port;
    }

    public void SetDBName(String dbName)
    {
      this.DBFileName = dbName;
    }

    public void SetDBUserName(String username)
    {
      this.DBUsername = username;
    }

    public void SetDBPassword(String password)
    {
      this.DBPassword = password;
    }

    public void SetDBEncoding(String encoding)
    {
      this.DBEncoding = encoding;
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
        var ini = new MyIniFile(ConfigPath);
        if (ini.Read())
        {
          if (QueryFile != "")
          {
            // Zapisuję zapytanie do pliku
            File.WriteAllText(QueryFile, SQL);
            // W pliku ini zapisuję tylko nazwę pliku z zapytaniem
            SQL = Path.GetFileName(QueryFile);
          }
          ini.Add(INI_MAIN_SQL, SQL);
          ini.Add(INI_DBHOST, this.DBHost);
          ini.Add(INI_DBPORT, this.DBPort.ToString());
          ini.Add(INI_DBFILENAME, this.DBFileName);
          ini.Add(INI_DBUSERNAME, this.DBUsername);
          ini.Add(INI_DBPASSWORD, this.DBPassword);
          ini.Add(INI_DBENCODING, this.DBEncoding);
          result = ini.Save();
        }
      }
      catch (Exception e)
      {
        GlobalLog.LogError(e.GetType().Name + " - " + e.Message);
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
        var ini = new MyIniFile(ConfigPath);
        if (ini.Read())
        {
          // Sprawdzam czy jako SQL nie podano przypadkiem nazwy pliku
          // jeśli wkazany plik istnieje - należy go wczytać
          SQL = ini.Get(INI_MAIN_SQL, "select 'a','b',1,2,3,4 from RDB$DATABASE");
          SQL = Path.GetDirectoryName(ConfigPath) + "\\" + SQL;
          if (File.Exists(SQL))
          {
            QueryFile = SQL;
            SQL = File.ReadAllText(SQL);
          }

          DBHost = ini.Get(INI_DBHOST, "");
          String buf = ini.Get(INI_DBPORT, "");
          if (buf != null && buf != "") DBPort = Int32.Parse(buf);
          DBFileName = ini.Get(INI_DBFILENAME, "");
          DBUsername = ini.Get(INI_DBUSERNAME, "");
          DBPassword = ini.Get(INI_DBPASSWORD, "");
          DBEncoding = ini.Get(INI_DBENCODING, "");
          result = true;
        }
      }
      catch (Exception e)
      {
        GlobalLog.LogError(e.GetType().Name + " - " + e.Message);
      }
      return result;
    }

    /// <summary>
    /// Tworzy plik konfiguracyjny w katalogu aplikacji w AppData\Local
    /// </summary>
    /// <returns>Zwraca true jeśli został utworzony nowy plik konfiguracyjny</returns>
    public ConfigFileStatus CheckMustCreateConfigFile()
    {
      try
      {
        string appName = Application.ProductName;
        string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string appDirectory = Path.Combine(localAppData, appName);

        // Utwórz katalog jeśli nie istnieje
        if (!Directory.Exists(appDirectory)) Directory.CreateDirectory(appDirectory);

        // Ścieżka do pliku
        ConfigPath = Path.Combine(appDirectory, "config.ini");

        // Utwórz plik tylko jeśli nie istnieje
        if (!File.Exists(ConfigPath))
        {
          string defaultConfig = "SQL=query.SQL\n" +
                                 "DBHOST = 1.1.0.1\n" +
                                 "DBPORT = 3050\n" +
                                 "DBFILENAME = DATA.gdb\n" +
                                 "DBUSERNAME = sysdba\n" +
                                 "DBPASSWORD = masterkey\n" +
                                 "DBENCODING = WIN1250\n";

          File.WriteAllText(ConfigPath, defaultConfig);
          return ConfigFileStatus.Created;
        }        
        return ConfigFileStatus.Exists;
      }
      catch (Exception ex)
      {
        GlobalLog.LogError(ex.GetType().Name + " - " + ex.Message);
        return ConfigFileStatus.Error;
      }
    }

  }
}
