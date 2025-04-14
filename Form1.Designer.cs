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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "sdaf",
            "qqqqqqqqq",
            "wwww",
            "eeeefff"}, -1);
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonCheckIntervalDown = new System.Windows.Forms.Button();
			this.buttonCheckIntervalUp = new System.Windows.Forms.Button();
			this.labelCheckInterval = new System.Windows.Forms.Label();
			this.labelConnectionCount = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.labelMaxMemUsed = new System.Windows.Forms.Label();
			this.labelMemAllocated = new System.Windows.Forms.Label();
			this.labelMemUsed = new System.Windows.Forms.Label();
			this.labelMemCurrent = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageFirebirdData = new System.Windows.Forms.TabPage();
			this.tabPageErrorLog = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			this.panel1.Controls.Add(this.labelConnectionCount);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.labelMaxMemUsed);
			this.panel1.Controls.Add(this.labelMemAllocated);
			this.panel1.Controls.Add(this.labelMemUsed);
			this.panel1.Controls.Add(this.labelMemCurrent);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 350);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(756, 100);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonCheckIntervalDown);
			this.groupBox1.Controls.Add(this.buttonCheckIntervalUp);
			this.groupBox1.Controls.Add(this.labelCheckInterval);
			this.groupBox1.Location = new System.Drawing.Point(259, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(202, 47);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Częstotliwość sprawdzania";
			// 
			// buttonCheckIntervalDown
			// 
			this.buttonCheckIntervalDown.Location = new System.Drawing.Point(137, 18);
			this.buttonCheckIntervalDown.Name = "buttonCheckIntervalDown";
			this.buttonCheckIntervalDown.Size = new System.Drawing.Size(42, 23);
			this.buttonCheckIntervalDown.TabIndex = 2;
			this.buttonCheckIntervalDown.Text = "-1";
			this.buttonCheckIntervalDown.UseVisualStyleBackColor = true;
			this.buttonCheckIntervalDown.Click += new System.EventHandler(this.buttonCheckIntervalDown_Click);
			// 
			// buttonCheckIntervalUp
			// 
			this.buttonCheckIntervalUp.Location = new System.Drawing.Point(89, 18);
			this.buttonCheckIntervalUp.Name = "buttonCheckIntervalUp";
			this.buttonCheckIntervalUp.Size = new System.Drawing.Size(42, 23);
			this.buttonCheckIntervalUp.TabIndex = 1;
			this.buttonCheckIntervalUp.Text = "+1";
			this.buttonCheckIntervalUp.UseVisualStyleBackColor = true;
			this.buttonCheckIntervalUp.Click += new System.EventHandler(this.buttonCheckIntervalUp_Click);
			// 
			// labelCheckInterval
			// 
			this.labelCheckInterval.AutoSize = true;
			this.labelCheckInterval.Location = new System.Drawing.Point(16, 23);
			this.labelCheckInterval.Name = "labelCheckInterval";
			this.labelCheckInterval.Size = new System.Drawing.Size(23, 13);
			this.labelCheckInterval.TabIndex = 0;
			this.labelCheckInterval.Text = "1 S";
			// 
			// labelConnectionCount
			// 
			this.labelConnectionCount.AutoSize = true;
			this.labelConnectionCount.Location = new System.Drawing.Point(362, 3);
			this.labelConnectionCount.Name = "labelConnectionCount";
			this.labelConnectionCount.Size = new System.Drawing.Size(25, 13);
			this.labelConnectionCount.TabIndex = 12;
			this.labelConnectionCount.Text = "000";
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
			// labelMaxMemUsed
			// 
			this.labelMaxMemUsed.AutoSize = true;
			this.labelMaxMemUsed.Location = new System.Drawing.Point(129, 78);
			this.labelMaxMemUsed.Name = "labelMaxMemUsed";
			this.labelMaxMemUsed.Size = new System.Drawing.Size(25, 13);
			this.labelMaxMemUsed.TabIndex = 10;
			this.labelMaxMemUsed.Text = "000";
			// 
			// labelMemAllocated
			// 
			this.labelMemAllocated.AutoSize = true;
			this.labelMemAllocated.Location = new System.Drawing.Point(129, 53);
			this.labelMemAllocated.Name = "labelMemAllocated";
			this.labelMemAllocated.Size = new System.Drawing.Size(25, 13);
			this.labelMemAllocated.TabIndex = 9;
			this.labelMemAllocated.Text = "000";
			// 
			// labelMemUsed
			// 
			this.labelMemUsed.AutoSize = true;
			this.labelMemUsed.Location = new System.Drawing.Point(129, 28);
			this.labelMemUsed.Name = "labelMemUsed";
			this.labelMemUsed.Size = new System.Drawing.Size(25, 13);
			this.labelMemUsed.TabIndex = 8;
			this.labelMemUsed.Text = "000";
			// 
			// labelMemCurrent
			// 
			this.labelMemCurrent.AutoSize = true;
			this.labelMemCurrent.Location = new System.Drawing.Point(129, 3);
			this.labelMemCurrent.Name = "labelMemCurrent";
			this.labelMemCurrent.Size = new System.Drawing.Size(25, 13);
			this.labelMemCurrent.TabIndex = 7;
			this.labelMemCurrent.Text = "000";
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(265, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			this.tabPageFirebirdData.Controls.Add(this.listView1);
			this.tabPageFirebirdData.Location = new System.Drawing.Point(4, 22);
			this.tabPageFirebirdData.Name = "tabPageFirebirdData";
			this.tabPageFirebirdData.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFirebirdData.Size = new System.Drawing.Size(748, 324);
			this.tabPageFirebirdData.TabIndex = 0;
			this.tabPageFirebirdData.Text = "Dane Firebird";
			this.tabPageFirebirdData.UseVisualStyleBackColor = true;
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
			// listView1
			// 
			this.listView1.AutoArrange = false;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.HideSelection = false;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listView1.LabelWrap = false;
			this.listView1.Location = new System.Drawing.Point(3, 3);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(742, 318);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMaxMemUsed;
        private System.Windows.Forms.Label labelMemAllocated;
        private System.Windows.Forms.Label labelMemUsed;
        private System.Windows.Forms.Label labelMemCurrent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelConnectionCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCheckIntervalDown;
        private System.Windows.Forms.Button buttonCheckIntervalUp;
        private System.Windows.Forms.Label labelCheckInterval;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageFirebirdData;
		private System.Windows.Forms.TabPage tabPageErrorLog;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ListBox listBoxErrorLog;
	}
}

