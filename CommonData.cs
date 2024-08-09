using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firebird_SQL_Monitor
{
    public class CommonData
    {
        public static Konfiguracja konfiguracja = new Konfiguracja();
        public static DBHelper dbHelper = new DBHelper(konfiguracja);

        public static DBHelper GetDBHelper() { return dbHelper; }
        public static Konfiguracja GetKonfiguracja() { return konfiguracja; }

    }
}
