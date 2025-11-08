namespace FirebirdSQLMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "sdaf",
            "qqqqqqqqq",
            "wwww",
            "eeeefff"}, -1);
      this.panel1 = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.ButtonCheckIntervalDown = new System.Windows.Forms.Button();
      this.ButtonCheckIntervalUp = new System.Windows.Forms.Button();
      this.LabelCheckInterval = new System.Windows.Forms.Label();
      this.LabelConnectionCount = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.LabelMaxMemUsed = new System.Windows.Forms.Label();
      this.LabelMemAllocated = new System.Windows.Forms.Label();
      this.LabelMemUsed = new System.Windows.Forms.Label();
      this.LabelMemCurrent = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.Timer1 = new System.Windows.Forms.Timer(this.components);
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageFirebirdData = new System.Windows.Forms.TabPage();
      this.ListView1 = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.tabPageErrorLog = new System.Windows.Forms.TabPage();
      this.listBoxErrorLog = new System.Windows.Forms.ListBox();
      this.panel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageFirebirdData.SuspendLayout();
      this.tabPageErrorLog.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.groupBox1);
      this.panel1.Controls.Add(this.LabelConnectionCount);
      this.panel1.Controls.Add(this.label6);
      this.panel1.Controls.Add(this.LabelMaxMemUsed);
      this.panel1.Controls.Add(this.LabelMemAllocated);
      this.panel1.Controls.Add(this.LabelMemUsed);
      this.panel1.Controls.Add(this.LabelMemCurrent);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.Label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 350);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(756, 100);
      this.panel1.TabIndex = 0;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.ButtonCheckIntervalDown);
      this.groupBox1.Controls.Add(this.ButtonCheckIntervalUp);
      this.groupBox1.Controls.Add(this.LabelCheckInterval);
      this.groupBox1.Location = new System.Drawing.Point(259, 28);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(202, 47);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Częstotliwość sprawdzania";
      // 
      // ButtonCheckIntervalDown
      // 
      this.ButtonCheckIntervalDown.Location = new System.Drawing.Point(137, 18);
      this.ButtonCheckIntervalDown.Name = "ButtonCheckIntervalDown";
      this.ButtonCheckIntervalDown.Size = new System.Drawing.Size(42, 23);
      this.ButtonCheckIntervalDown.TabIndex = 2;
      this.ButtonCheckIntervalDown.Text = "-1";
      this.ButtonCheckIntervalDown.UseVisualStyleBackColor = true;
      this.ButtonCheckIntervalDown.Click += new System.EventHandler(this.ButtonCheckIntervalDown_Click);
      // 
      // ButtonCheckIntervalUp
      // 
      this.ButtonCheckIntervalUp.Location = new System.Drawing.Point(89, 18);
      this.ButtonCheckIntervalUp.Name = "ButtonCheckIntervalUp";
      this.ButtonCheckIntervalUp.Size = new System.Drawing.Size(42, 23);
      this.ButtonCheckIntervalUp.TabIndex = 1;
      this.ButtonCheckIntervalUp.Text = "+1";
      this.ButtonCheckIntervalUp.UseVisualStyleBackColor = true;
      this.ButtonCheckIntervalUp.Click += new System.EventHandler(this.ButtonCheckIntervalUp_Click);
      // 
      // LabelCheckInterval
      // 
      this.LabelCheckInterval.AutoSize = true;
      this.LabelCheckInterval.Location = new System.Drawing.Point(16, 23);
      this.LabelCheckInterval.Name = "LabelCheckInterval";
      this.LabelCheckInterval.Size = new System.Drawing.Size(23, 13);
      this.LabelCheckInterval.TabIndex = 0;
      this.LabelCheckInterval.Text = "1 S";
      // 
      // LabelConnectionCount
      // 
      this.LabelConnectionCount.AutoSize = true;
      this.LabelConnectionCount.Location = new System.Drawing.Point(362, 3);
      this.LabelConnectionCount.Name = "LabelConnectionCount";
      this.LabelConnectionCount.Size = new System.Drawing.Size(25, 13);
      this.LabelConnectionCount.TabIndex = 12;
      this.LabelConnectionCount.Text = "000";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(265, 3);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(91, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Connection count";
      // 
      // LabelMaxMemUsed
      // 
      this.LabelMaxMemUsed.AutoSize = true;
      this.LabelMaxMemUsed.Location = new System.Drawing.Point(129, 78);
      this.LabelMaxMemUsed.Name = "LabelMaxMemUsed";
      this.LabelMaxMemUsed.Size = new System.Drawing.Size(25, 13);
      this.LabelMaxMemUsed.TabIndex = 10;
      this.LabelMaxMemUsed.Text = "000";
      // 
      // LabelMemAllocated
      // 
      this.LabelMemAllocated.AutoSize = true;
      this.LabelMemAllocated.Location = new System.Drawing.Point(129, 53);
      this.LabelMemAllocated.Name = "LabelMemAllocated";
      this.LabelMemAllocated.Size = new System.Drawing.Size(25, 13);
      this.LabelMemAllocated.TabIndex = 9;
      this.LabelMemAllocated.Text = "000";
      // 
      // LabelMemUsed
      // 
      this.LabelMemUsed.AutoSize = true;
      this.LabelMemUsed.Location = new System.Drawing.Point(129, 28);
      this.LabelMemUsed.Name = "LabelMemUsed";
      this.LabelMemUsed.Size = new System.Drawing.Size(25, 13);
      this.LabelMemUsed.TabIndex = 8;
      this.LabelMemUsed.Text = "000";
      // 
      // LabelMemCurrent
      // 
      this.LabelMemCurrent.AutoSize = true;
      this.LabelMemCurrent.Location = new System.Drawing.Point(129, 3);
      this.LabelMemCurrent.Name = "LabelMemCurrent";
      this.LabelMemCurrent.Size = new System.Drawing.Size(25, 13);
      this.LabelMemCurrent.TabIndex = 7;
      this.LabelMemCurrent.Text = "000";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(22, 78);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(78, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "Max mem used";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(22, 53);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(98, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Max mem allocated";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 28);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(56, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Mem used";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(22, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(66, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Mem current";
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Location = new System.Drawing.Point(265, 78);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(35, 13);
      this.Label1.TabIndex = 2;
      this.Label1.Text = "label1";
      // 
      // Timer1
      // 
      this.Timer1.Interval = 1000;
      this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageFirebirdData);
      this.tabControl1.Controls.Add(this.tabPageErrorLog);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(756, 350);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPageFirebirdData
      // 
      this.tabPageFirebirdData.Controls.Add(this.ListView1);
      this.tabPageFirebirdData.Location = new System.Drawing.Point(4, 22);
      this.tabPageFirebirdData.Name = "tabPageFirebirdData";
      this.tabPageFirebirdData.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageFirebirdData.Size = new System.Drawing.Size(748, 324);
      this.tabPageFirebirdData.TabIndex = 0;
      this.tabPageFirebirdData.Text = "Dane Firebird";
      this.tabPageFirebirdData.UseVisualStyleBackColor = true;
      // 
      // ListView1
      // 
      this.ListView1.AutoArrange = false;
      this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListView1.FullRowSelect = true;
      this.ListView1.GridLines = true;
      this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.ListView1.HideSelection = false;
      this.ListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
      this.ListView1.LabelWrap = false;
      this.ListView1.Location = new System.Drawing.Point(3, 3);
      this.ListView1.MultiSelect = false;
      this.ListView1.Name = "ListView1";
      this.ListView1.Size = new System.Drawing.Size(742, 318);
      this.ListView1.TabIndex = 2;
      this.ListView1.UseCompatibleStateImageBehavior = false;
      this.ListView1.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Width = 107;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Width = 107;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Width = 99;
      // 
      // tabPageErrorLog
      // 
      this.tabPageErrorLog.Controls.Add(this.listBoxErrorLog);
      this.tabPageErrorLog.Location = new System.Drawing.Point(4, 22);
      this.tabPageErrorLog.Name = "tabPageErrorLog";
      this.tabPageErrorLog.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageErrorLog.Size = new System.Drawing.Size(748, 324);
      this.tabPageErrorLog.TabIndex = 1;
      this.tabPageErrorLog.Text = "Log błędów";
      this.tabPageErrorLog.UseVisualStyleBackColor = true;
      // 
      // listBoxErrorLog
      // 
      this.listBoxErrorLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listBoxErrorLog.FormattingEnabled = true;
      this.listBoxErrorLog.Location = new System.Drawing.Point(3, 3);
      this.listBoxErrorLog.Name = "listBoxErrorLog";
      this.listBoxErrorLog.Size = new System.Drawing.Size(742, 318);
      this.listBoxErrorLog.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(756, 450);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Firebird SQL Monitor";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPageFirebirdData.ResumeLayout(false);
      this.tabPageErrorLog.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabelMaxMemUsed;
        private System.Windows.Forms.Label LabelMemAllocated;
        private System.Windows.Forms.Label LabelMemUsed;
        private System.Windows.Forms.Label LabelMemCurrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelConnectionCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonCheckIntervalDown;
        private System.Windows.Forms.Button ButtonCheckIntervalUp;
        private System.Windows.Forms.Label LabelCheckInterval;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageFirebirdData;
		private System.Windows.Forms.TabPage tabPageErrorLog;
		private System.Windows.Forms.ListView ListView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ListBox listBoxErrorLog;
	}
}

