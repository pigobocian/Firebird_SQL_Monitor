namespace Firebird_SQL_Monitor
{
    partial class ZapytaniaSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonCheckIntervalDown = new System.Windows.Forms.Button();
            this.ButtonCheckIntervalUp = new System.Windows.Forms.Button();
            this.LabelTimerInterval = new System.Windows.Forms.Label();
            this.checkBoxTimerIntervalChange = new System.Windows.Forms.CheckBox();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonZamknij = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.scintilla1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 377);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualny użytkownik";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxTimerIntervalChange);
            this.groupBox1.Controls.Add(this.ButtonCheckIntervalDown);
            this.groupBox1.Controls.Add(this.ButtonCheckIntervalUp);
            this.groupBox1.Controls.Add(this.LabelTimerInterval);
            this.groupBox1.Location = new System.Drawing.Point(460, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 57);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Częstotliwość sprawdzania";
            // 
            // ButtonCheckIntervalDown
            // 
            this.ButtonCheckIntervalDown.Location = new System.Drawing.Point(274, 24);
            this.ButtonCheckIntervalDown.Name = "ButtonCheckIntervalDown";
            this.ButtonCheckIntervalDown.Size = new System.Drawing.Size(42, 23);
            this.ButtonCheckIntervalDown.TabIndex = 2;
            this.ButtonCheckIntervalDown.Text = "-1";
            this.ButtonCheckIntervalDown.UseVisualStyleBackColor = true;
            this.ButtonCheckIntervalDown.Click += new System.EventHandler(this.ButtonCheckIntervalDown_Click);
            // 
            // ButtonCheckIntervalUp
            // 
            this.ButtonCheckIntervalUp.Location = new System.Drawing.Point(226, 24);
            this.ButtonCheckIntervalUp.Name = "ButtonCheckIntervalUp";
            this.ButtonCheckIntervalUp.Size = new System.Drawing.Size(42, 23);
            this.ButtonCheckIntervalUp.TabIndex = 1;
            this.ButtonCheckIntervalUp.Text = "+1";
            this.ButtonCheckIntervalUp.UseVisualStyleBackColor = true;
            this.ButtonCheckIntervalUp.Click += new System.EventHandler(this.ButtonCheckIntervalUp_Click);
            // 
            // LabelTimerInterval
            // 
            this.LabelTimerInterval.AutoSize = true;
            this.LabelTimerInterval.Location = new System.Drawing.Point(181, 29);
            this.LabelTimerInterval.Name = "LabelTimerInterval";
            this.LabelTimerInterval.Size = new System.Drawing.Size(23, 13);
            this.LabelTimerInterval.TabIndex = 0;
            this.LabelTimerInterval.Text = "1 S";
            // 
            // checkBoxTimerIntervalChange
            // 
            this.checkBoxTimerIntervalChange.AutoSize = true;
            this.checkBoxTimerIntervalChange.Location = new System.Drawing.Point(18, 27);
            this.checkBoxTimerIntervalChange.Name = "checkBoxTimerIntervalChange";
            this.checkBoxTimerIntervalChange.Size = new System.Drawing.Size(145, 17);
            this.checkBoxTimerIntervalChange.TabIndex = 3;
            this.checkBoxTimerIntervalChange.Text = "Odświeżaj automatycznie";
            this.checkBoxTimerIntervalChange.UseVisualStyleBackColor = true;
            this.checkBoxTimerIntervalChange.CheckedChanged += new System.EventHandler(this.checkBoxTimerIntervalChange_CheckedChanged);
            // 
            // scintilla1
            // 
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.LexerName = null;
            this.scintilla1.Location = new System.Drawing.Point(0, 0);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(800, 377);
            this.scintilla1.TabIndex = 0;
            this.scintilla1.Text = "scintilla1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonRefresh);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.buttonZamknij);
            this.panel3.Controls.Add(this.buttonClear);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 55);
            this.panel3.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(15, 11);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 32);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonZamknij
            // 
            this.buttonZamknij.Location = new System.Drawing.Point(713, 11);
            this.buttonZamknij.Name = "buttonZamknij";
            this.buttonZamknij.Size = new System.Drawing.Size(75, 32);
            this.buttonZamknij.TabIndex = 1;
            this.buttonZamknij.Text = "Zamknij";
            this.buttonZamknij.UseVisualStyleBackColor = true;
            this.buttonZamknij.Click += new System.EventHandler(this.buttonZamknij_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zapisz do pliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "Dane";
            this.saveFileDialog1.Title = "Zapisz zapytania";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(192, 11);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 32);
            this.buttonRefresh.TabIndex = 16;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // ZapytaniaSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ZapytaniaSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZapytaniaSQL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonCheckIntervalDown;
        private System.Windows.Forms.Button ButtonCheckIntervalUp;
        private System.Windows.Forms.Label LabelTimerInterval;
        private System.Windows.Forms.CheckBox checkBoxTimerIntervalChange;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonZamknij;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonRefresh;
    }
}