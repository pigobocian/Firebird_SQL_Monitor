namespace Firebird_SQL_Monitor
{
  partial class ConfigForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
      this.HostTextBox = new System.Windows.Forms.TextBox();
      this.PortUpDown = new System.Windows.Forms.NumericUpDown();
      this.DatabaseTextBox = new System.Windows.Forms.TextBox();
      this.UsernameTextBox = new System.Windows.Forms.TextBox();
      this.PasswordTextBox = new System.Windows.Forms.TextBox();
      this.CharSetComboBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.CancelButton = new System.Windows.Forms.Button();
      this.OKButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.PortUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // HostTextBox
      // 
      this.HostTextBox.Location = new System.Drawing.Point(175, 24);
      this.HostTextBox.Name = "HostTextBox";
      this.HostTextBox.Size = new System.Drawing.Size(120, 20);
      this.HostTextBox.TabIndex = 0;
      // 
      // PortUpDown
      // 
      this.PortUpDown.Location = new System.Drawing.Point(316, 24);
      this.PortUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
      this.PortUpDown.Name = "PortUpDown";
      this.PortUpDown.Size = new System.Drawing.Size(120, 20);
      this.PortUpDown.TabIndex = 1;
      this.PortUpDown.UseWaitCursor = true;
      this.PortUpDown.Value = new decimal(new int[] {
            3050,
            0,
            0,
            0});
      // 
      // DatabaseTextBox
      // 
      this.DatabaseTextBox.Location = new System.Drawing.Point(175, 70);
      this.DatabaseTextBox.Name = "DatabaseTextBox";
      this.DatabaseTextBox.Size = new System.Drawing.Size(261, 20);
      this.DatabaseTextBox.TabIndex = 2;
      // 
      // UsernameTextBox
      // 
      this.UsernameTextBox.Location = new System.Drawing.Point(175, 115);
      this.UsernameTextBox.Name = "UsernameTextBox";
      this.UsernameTextBox.Size = new System.Drawing.Size(120, 20);
      this.UsernameTextBox.TabIndex = 3;
      // 
      // PasswordTextBox
      // 
      this.PasswordTextBox.Location = new System.Drawing.Point(316, 115);
      this.PasswordTextBox.Name = "PasswordTextBox";
      this.PasswordTextBox.Size = new System.Drawing.Size(120, 20);
      this.PasswordTextBox.TabIndex = 4;
      // 
      // CharSetComboBox
      // 
      this.CharSetComboBox.FormattingEnabled = true;
      this.CharSetComboBox.Items.AddRange(new object[] {
            "NONE",
            "ASCII",
            "ISO8859_1",
            "UTF8",
            "WIN1250"});
      this.CharSetComboBox.Location = new System.Drawing.Point(175, 163);
      this.CharSetComboBox.Name = "CharSetComboBox";
      this.CharSetComboBox.Size = new System.Drawing.Size(121, 21);
      this.CharSetComboBox.TabIndex = 5;
      this.CharSetComboBox.Text = "WIN1250";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(175, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Host";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(313, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(26, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Port";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(175, 54);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(127, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Plik bazy wraz ze ścieżką";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(175, 99);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(62, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Użytkownik";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(313, 99);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(36, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Hasło";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(175, 147);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(43, 13);
      this.label6.TabIndex = 11;
      this.label6.Text = "Charset";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(157, 172);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 12;
      this.pictureBox1.TabStop = false;
      // 
      // CancelButton
      // 
      this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelButton.Location = new System.Drawing.Point(361, 205);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(75, 34);
      this.CancelButton.TabIndex = 13;
      this.CancelButton.Text = "Nie";
      this.CancelButton.UseVisualStyleBackColor = true;
      // 
      // OKButton
      // 
      this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OKButton.Location = new System.Drawing.Point(274, 205);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(75, 34);
      this.OKButton.TabIndex = 14;
      this.OKButton.Text = "Tak";
      this.OKButton.UseVisualStyleBackColor = true;
      // 
      // ConfigForm
      // 
      this.AcceptButton = this.OKButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.CancelButton;
      this.ClientSize = new System.Drawing.Size(448, 249);
      this.Controls.Add(this.OKButton);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.CharSetComboBox);
      this.Controls.Add(this.PasswordTextBox);
      this.Controls.Add(this.UsernameTextBox);
      this.Controls.Add(this.DatabaseTextBox);
      this.Controls.Add(this.PortUpDown);
      this.Controls.Add(this.HostTextBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "ConfigForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "ConfigForm";
      this.Load += new System.EventHandler(this.ConfigForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.PortUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox HostTextBox;
    private System.Windows.Forms.NumericUpDown PortUpDown;
    private System.Windows.Forms.TextBox DatabaseTextBox;
    private System.Windows.Forms.TextBox UsernameTextBox;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.ComboBox CharSetComboBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button CancelButton;
    private System.Windows.Forms.Button OKButton;
  }
}