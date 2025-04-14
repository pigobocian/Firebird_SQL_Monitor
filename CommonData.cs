using System.Windows.Forms;

namespace FirebirdSQLMonitor
{
    public class CommonData
    {
        public static Konfiguracja konfiguracja = new Konfiguracja();
        public static DBHelper dbHelper = new DBHelper(konfiguracja);

        public static DBHelper GetDBHelper() { return dbHelper; }
        public static Konfiguracja GetKonfiguracja() { return konfiguracja; }

        public static ListBox log;

	}
}
