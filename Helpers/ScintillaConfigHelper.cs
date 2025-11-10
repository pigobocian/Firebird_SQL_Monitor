using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Firebird_SQL_Monitor.Helpers
{
    public static class ScintillaConfigHelper
    {
        public static void ConfigureScintilla(this Scintilla scintilla)
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

        public static void ConfigureFirebirdSql(this Scintilla scintilla)
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

    }
}
