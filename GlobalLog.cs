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
    private static ListBox ListBox = null;
    private static GlobalLog Instance = null;
    private static int ErrorCount = 0;
    private static int WarningCount = 0;

    // Prywatny konstruktor - singleton
    private GlobalLog() { }

    public static GlobalLog GetInstance()
    {
      if (Instance == null)
      {
        Instance = new GlobalLog();
      }
      return Instance;
    }

    public void SetListBox(ListBox lb)
    {
      ListBox = lb;
    }

    public static void LogError(string message)
    {
      ErrorCount++;

      ListBox?.Items.Add("E: " + message);
    }

    public static void LogWarning(string message)
    {
      WarningCount++;
      ListBox?.Items.Add("W: " + message);
    }

    public static void LogInfo(string message)
    {
      ListBox?.Items.Add("I: " + message);
    }

    public static int GetErrorCount()
    {
      return ErrorCount;
    } 

    public static int GetWarningCount()
    {
      return WarningCount;
    } 
  }
}