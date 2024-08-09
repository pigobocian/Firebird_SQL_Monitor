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
            connStr += "datasource=" + cfg.GetDBHost() + ";";
            connStr += "port=" + cfg.GetDBPort().ToString() + ":";
            connStr += "database=" + cfg.GetDBName() + ";";
            connStr += "user id=" + cfg.GetDBUserName() + ";";
            connStr += "password=" + cfg.GetDBPassword() + ";";
            connStr += "charset=" + cfg.GetDBEncoding();
        }

        public bool Connect()
        {
            bool result = false;
            try
            {
                string tmpstr = "User=SYSDBA;Password=masterkey;Database=c:\\praca\\bazypcb\\wysokinski\\WYSOKINSKI.gdb;DataSource=127.0.0.1;Port=3050;Dialect=3;Charset=WIN1250;Role=;Connection lifetime=15;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;\r\nServerType=0;";
                fbConnection = new FbConnection(tmpstr);
                fbConnection.Open();
                result = true;
            } catch (FbException e) {
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
