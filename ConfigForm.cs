using FirebirdSQLMonitor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebird_SQL_Monitor
{
  public partial class ConfigForm : Form
  {
    public ConfigForm()
    {
      InitializeComponent();
    }

    private void ConfigForm_Load(object sender, EventArgs e)
    {
      HostTextBox.Text = Konfiguracja.GetInstance().GetDBHost();
      PortUpDown.Value = Konfiguracja.GetInstance().GetDBPort();
      DatabaseTextBox.Text = Konfiguracja.GetInstance().GetDBName();
      UsernameTextBox.Text = Konfiguracja.GetInstance().GetDBUserName();
      PasswordTextBox.Text = Konfiguracja.GetInstance().GetDBPassword();
      CharSetComboBox.Text = Konfiguracja.GetInstance().GetDBEncoding();
    }

    public string GetHost()
    {
      return HostTextBox.Text;
    }

    public int GetPort()
    {
      return (int)PortUpDown.Value;
    }

    public string GetDatabase()
    {
      return DatabaseTextBox.Text;
    }

    public string GetUsername()
    {
      return UsernameTextBox.Text;
    }

    public string GetPassword()
    {
      return PasswordTextBox.Text;
    }

    public string GetCharSet()
    {
      return CharSetComboBox.Text;
    }

    public bool ShowConfigDialog()
    {
           return this.ShowDialog() == DialogResult.OK;
    }
  }
}
