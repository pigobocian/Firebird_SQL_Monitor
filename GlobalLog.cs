using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebird_SQL_Monitor
{
  internal class GlobalLog
  {
    private static ListBox listBox = null;
    private static GlobalLog instance = null;

    // Prywatny konstruktor - singleton
    private GlobalLog() { }

    public static GlobalLog GetInstance()
    {
      if (instance == null)
      {
        instance = new GlobalLog();
      }
      return instance;
    }

    public void SetListBox(ListBox lb)
    {
      listBox = lb;
    }

    public static void LogMessage(string message)
    {
      if (listBox != null)
      {
        listBox.Items.Add(message);
      }
    }

  }
}
