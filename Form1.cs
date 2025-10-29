using Firebird_SQL_Monitor;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Windows.Forms;

namespace FirebirdSQLMonitor
{
	public partial class Form1 : Form
	{
		private bool firstRun = true;
		private float topMaxMemUsed = 0;
		private float topMaxMemAllocated = 0;
		private int topConnectionCount = 0;


		public Form1()
		{
			InitializeComponent();
		}

		private void InitApp()
		{
			GlobalLog log = GlobalLog.GetInstance();
			log.SetListBox(this.listBoxErrorLog);

      try
			{
				if (firstRun)
				{
          firstRun = false;
					Konfiguracja konfiguracja = Konfiguracja.GetInstance();
					konfiguracja.LoadConfig();
					DBHelper dbHelper = DBHelper.GetInstance();
					if (dbHelper.Connect())
					{
						timer1.Enabled = true;
					}					
        }
			}
			catch (Exception e)
			{
				GlobalLog.LogMessage(e.GetType().Name + " - " + e.Message);
			}
		}

		private void CreateColumns(FbDataReader reader)
		{
			listView1.Columns.Clear();

			for (int i = 0; i < reader.FieldCount; i++)
			{
				string fieldName = reader.GetName(i);
				var column = listView1.Columns.Add(fieldName);
				//column.Width = -2;
			}
		}

		private void RefreshForm()
		{
			listView1.BeginUpdate();
			listView1.Items.Clear();
			try
			{
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
              ListViewItem item = listView1.Items.Add(dbgStr); // remote host
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
							if (connectionCount > topConnectionCount) topConnectionCount = connectionCount;
							if (maxMemAllocated > topMaxMemAllocated) topMaxMemAllocated = maxMemAllocated;
							if (maxMemUsed > topMaxMemUsed) topMaxMemUsed = maxMemUsed;
						}

						labelConnectionCount.Text = connectionCount.ToString() + "  top: " + topConnectionCount.ToString();
						labelMemCurrent.Text = memCurrent.ToString() + " MB";
						labelMemUsed.Text = memUsed.ToString() + " GB";
						labelMemAllocated.Text = maxMemAllocated.ToString() + " GB  top: " + topMaxMemAllocated.ToString() + " GB";
						labelMaxMemUsed.Text = maxMemUsed.ToString() + " GB  top: " + topMaxMemUsed.ToString() + " GB";
					}
				}
				listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			}
			catch (Exception e)
			{
        GlobalLog.LogMessage(e.GetType().Name + " - " + e.Message);
			}
			finally
			{
				listView1.EndUpdate();
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

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString();
			int interval = timer1.Interval / 1000;
			labelCheckInterval.Text = interval.ToString() + " sec";
			RefreshForm();
		}

		private void buttonCheckIntervalUp_Click(object sender, EventArgs e)
		{
			if (timer1.Interval < 100000) timer1.Interval += 1000;
			int interval = timer1.Interval / 1000;
			labelCheckInterval.Text = interval.ToString() + " sec";
		}

		private void buttonCheckIntervalDown_Click(object sender, EventArgs e)
		{
			if (timer1.Interval > 1000) timer1.Interval -= 1000;
			int interval = timer1.Interval / 1000;
			labelCheckInterval.Text = interval.ToString() + " sec";
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
