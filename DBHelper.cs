using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace Firebird_SQL_Monitor
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
                Console.WriteLine(e.Message);
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
                Console.WriteLine($"{e.Message}");
            }
        }

        public FbCommand GetSQLCommand(String sql)
        {
            FbCommand fbCommand = new FbCommand(sql, fbConnection);
            return fbCommand;
        }

    }
}
