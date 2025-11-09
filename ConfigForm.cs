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
using ScintillaNET;

namespace Firebird_SQL_Monitor
{
  public partial class ConfigForm : Form
  {
    private Scintilla scintilla;

    public ConfigForm()
    {
      InitializeComponent();
      scintilla = new Scintilla();
      scintilla.Dock = DockStyle.Fill;
      panel1.Controls.Add(scintilla);

      ConfigureScintilla();
      ConfigureFirebirdSql();
    }

    private void ConfigForm_Load(object sender, EventArgs e)
    {
      HostTextBox.Text = Konfiguracja.GetInstance().GetDBHost();
      PortUpDown.Value = Konfiguracja.GetInstance().GetDBPort();
      DatabaseTextBox.Text = Konfiguracja.GetInstance().GetDBName();
      UsernameTextBox.Text = Konfiguracja.GetInstance().GetDBUserName();
      PasswordTextBox.Text = Konfiguracja.GetInstance().GetDBPassword();
      CharSetComboBox.Text = Konfiguracja.GetInstance().GetDBEncoding();
      scintilla.Text = Konfiguracja.GetInstance().GetSQL();
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

    public string GetSQL()
    {
      return scintilla.Text;
    }

    public bool ShowConfigDialog()
    {
      return this.ShowDialog() == DialogResult.OK;
    }

    private void ConfigureScintilla()
    {
      // Podstawowe ustawienia
      scintilla.Text = "SELECT * FROM tabela;";

      // Czcionka
      scintilla.StyleResetDefault();
      scintilla.Styles[Style.Default].Font = "Consolas";
      scintilla.Styles[Style.Default].Size = 10;
      scintilla.StyleClearAll(); // Zastosuj do wszystkich stylów

      // Numerowanie linii
      scintilla.Margins[0].Width = 40;
      scintilla.Margins[0].Type = MarginType.Number;

      // Zawijanie linii
      scintilla.WrapMode = WrapMode.None;
    }

    private void ConfigureFirebirdSql()
    {
      scintilla.LexerName = "sql";

      // Czcionka i podstawowe style
      scintilla.StyleResetDefault();
      scintilla.Styles[Style.Default].Font = "Consolas";
      scintilla.Styles[Style.Default].Size = 11;
      scintilla.Styles[Style.Default].BackColor = Color.White;
      scintilla.Styles[Style.Default].ForeColor = Color.Black;
      scintilla.StyleClearAll();

      // Kolory składni
      scintilla.Styles[Style.Sql.Comment].ForeColor = Color.FromArgb(0, 128, 0);        // /* */ komentarze
      scintilla.Styles[Style.Sql.CommentLine].ForeColor = Color.FromArgb(0, 128, 0);   // -- komentarze
      scintilla.Styles[Style.Sql.Number].ForeColor = Color.Red;
      scintilla.Styles[Style.Sql.String].ForeColor = Color.FromArgb(163, 21, 21);      // 'tekst'
      scintilla.Styles[Style.Sql.Character].ForeColor = Color.FromArgb(163, 21, 21);
      scintilla.Styles[Style.Sql.Word].ForeColor = Color.Blue;                          // Słowa kluczowe
      scintilla.Styles[Style.Sql.Word].Bold = true;
      scintilla.Styles[Style.Sql.Identifier].ForeColor = Color.Black;                   // Nazwy tabel/kolumn
      scintilla.Styles[Style.Sql.Operator].ForeColor = Color.Gray;                      // =, +, -, etc.

      // Słowa kluczowe Firebird (lista 0)
      scintilla.SetKeywords(0,
          "select insert update delete merge " +
          "from where join inner left right full outer cross " +
          "create alter drop recreate " +
          "table view procedure function trigger generator exception domain " +
          "begin end declare returns as " +
          "and or not null is in between like containing starting similar " +
          "order by group having union all distinct " +
          "case when then else end " +
          "if while for do execute " +
          "commit rollback " +
          "grant revoke " +
          "primary key foreign references check unique " +
          "index ascending descending");

      // Typy danych Firebird (lista 1)
      scintilla.SetKeywords(1,
          "varchar char integer bigint smallint numeric decimal float double " +
          "date time timestamp blob");

      // Funkcje Firebird (lista 2)
      scintilla.SetKeywords(2,
          "count sum avg min max " +
          "upper lower substring trim char_length " +
          "coalesce nullif cast " +
          "current_date current_time current_timestamp " +
          "gen_id extract dateadd datediff");

      // Numerowanie linii
      scintilla.Margins[0].Width = 40;
      scintilla.Margins[0].Type = MarginType.Number;

      // Podświetlanie bieżącej linii
      //scintilla.CaretLineVisible = true;
      scintilla.CaretLineBackColor = Color.White;
      scintilla.CaretLineBackColor = Color.FromArgb(240, 240, 255);
    }

    private void PasswordTextBox_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
