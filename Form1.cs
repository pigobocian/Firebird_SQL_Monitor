using Firebird_SQL_Monitor;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace FirebirdSQLMonitor
{
  public partial class Form1 : Form
  {
    private float TopMaxMemUsed = 0;
    private float TopMaxMemAllocated = 0;
    private int TopConnectionCount = 0;


    public Form1()
    {
      InitializeComponent();
    }

    private void InitApp()
    {
      GlobalLog log = GlobalLog.GetInstance();
      log.SetListBox(this.listBoxErrorLog);
      Konfiguracja konfiguracja = Konfiguracja.GetInstance();
      if (konfiguracja.GetConfigFileStatus() == Konfiguracja.ConfigFileStatus.Exists)
      {
        konfiguracja.LoadConfig();
        DBHelper dbHelper = DBHelper.GetInstance();
        if (dbHelper.Connect()) Timer1.Enabled = true;
        else
          GlobalLog.LogError("Błąd połączenia z bazą: " + dbHelper.GetErrorMessage());
      }
      else
      {
        GlobalLog.LogWarning("Utworzono plik konfiguracyjny: " + konfiguracja.GetConfigPath() + ".  Uzupełnij go i uruchom aplikację ponownie.");
        tabControl1.SelectedIndex = 1;
      }
    }

    private void CreateColumns(FbDataReader reader)
    {
      ListView1.Columns.Clear();

      for (int i = 0; i < reader.FieldCount; i++)
      {
        string fieldName = reader.GetName(i);
        var column = ListView1.Columns.Add(fieldName);
      }
    }

    private void RefreshForm()
    {
      try
      {
        ListView1.BeginUpdate();
        ListView1.Items.Clear();
        Konfiguracja konfiguracja = Konfiguracja.GetInstance();
        string sql = konfiguracja.GetSQL();
        DBHelper dbHelper = DBHelper.GetInstance();
        using (FbCommand cmd = dbHelper.GetSQLCommand(sql))
        {
          using (FbDataReader reader = cmd.ExecuteReader())
          {
            float memCurrent = 0;
            float memUsed = 0;
            float maxMemAllocated = 0;
            float maxMemUsed = 0;
            int connectionCount = 0;

            CreateColumns(reader);
            while (reader.Read())
            {
              string dbgStr = reader.GetString(0);
              ListViewItem item = ListView1.Items.Add(dbgStr); // remote host
              dbgStr = reader.GetString(1);
              item.SubItems.Add(dbgStr); // adres IP
              dbgStr = reader.GetString(2);
              item.SubItems.Add(reader.GetFloat(2).ToString()); // Count of connections for host
              item.SubItems.Add(reader.GetFloat(3).ToString()); // Current SQL in MB
              item.SubItems.Add(reader.GetFloat(4).ToString()); // Mem used in GB
              item.SubItems.Add(reader.GetFloat(5).ToString()); // Max mem alocated in GB
              item.SubItems.Add(reader.GetFloat(6).ToString()); // Max mem used in GB

              connectionCount += reader.GetInt32(2);
              memCurrent += reader.GetFloat(3);
              memUsed += reader.GetFloat(4);
              maxMemAllocated += reader.GetFloat(5);
              maxMemUsed += reader.GetFloat(6);
              if (connectionCount > TopConnectionCount) TopConnectionCount = connectionCount;
              if (maxMemAllocated > TopMaxMemAllocated) TopMaxMemAllocated = maxMemAllocated;
              if (maxMemUsed > TopMaxMemUsed) TopMaxMemUsed = maxMemUsed;
            }

            LabelConnectionCount.Text = connectionCount.ToString() + "  top: " + TopConnectionCount.ToString();
            LabelMemCurrent.Text = memCurrent.ToString() + " MB";
            LabelMemUsed.Text = memUsed.ToString() + " GB";
            LabelMemAllocated.Text = maxMemAllocated.ToString() + " GB  top: " + TopMaxMemAllocated.ToString() + " GB";
            LabelMaxMemUsed.Text = maxMemUsed.ToString() + " GB  top: " + TopMaxMemUsed.ToString() + " GB";
          }
        }
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
      }
      catch (Exception e)
      {
        GlobalLog.LogError(e.GetType().Name + " - " + e.Message);
      }
      finally
      {
        ListView1.EndUpdate();
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      InitApp();
      RefreshForm();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      RefreshForm();
    }


    private void Timer1_Tick(object sender, EventArgs e)
    {
      if (GlobalLog.GetErrorCount() >= 3)
      {
        Timer1.Enabled = false;
        GlobalLog.LogError("Zbyt wiele błędów, zatrzymanie automatycznego odświeżania.");
        tabControl1.SelectedIndex = 1;
        return;
      }

      Label1.Text = DateTime.Now.ToString();
      int interval = Timer1.Interval / 1000;
      LabelCheckInterval.Text = interval.ToString() + " sec";
      RefreshForm();
    }

    private void ButtonCheckIntervalUp_Click(object sender, EventArgs e)
    {
      if (Timer1.Interval < 100000) Timer1.Interval += 1000;
      int interval = Timer1.Interval / 1000;
      LabelCheckInterval.Text = interval.ToString() + " sec";
    }

    private void ButtonCheckIntervalDown_Click(object sender, EventArgs e)
    {
      if (Timer1.Interval > 1000) Timer1.Interval -= 1000;
      int interval = Timer1.Interval / 1000;
      LabelCheckInterval.Text = interval.ToString() + " sec";
    }

  }
}
