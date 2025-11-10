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
    public partial class ZapytaniaSQL : Form
    {
        public ZapytaniaSQL()
        {
            InitializeComponent();
        }

        public void DodajTekst(string tekst)
        {
            scintilla1.AppendText(tekst + Environment.NewLine);
        }

        public void DodajTeksty(List<string> teksty)
        {
            foreach (var tekst in teksty)
            {
                scintilla1.AppendText(tekst + Environment.NewLine);
            }
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            scintilla1.ClearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, scintilla1.Text, Encoding.UTF8);
            }
        }

        private void ButtonCheckIntervalUp_Click(object sender, EventArgs e)
        {
            int seconds = timer1.Interval / 1000;
            seconds++;
            timer1.Interval = seconds * 1000;
        }

        private void ButtonCheckIntervalDown_Click(object sender, EventArgs e)
        {
            int seconds = timer1.Interval / 1000;
            seconds--; 
            if (seconds < 1) seconds = 1;
            timer1.Interval = seconds * 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelTimerInterval.Text = (timer1.Interval / 1000).ToString() + " s";
        }

        private void checkBoxTimerIntervalChange_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBoxTimerIntervalChange.Checked;
        }
    }
}
