namespace programGUI
{
    partial class MainForm
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.textBoxKirim = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxNotif = new System.Windows.Forms.RichTextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxBaud = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageQuickCommand = new System.Windows.Forms.TabPage();
            this.buttonDollar = new System.Windows.Forms.Button();
            this.buttonPersen = new System.Windows.Forms.Button();
            this.tabPageQuickSet = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.textBoxSimpan = new System.Windows.Forms.TextBox();
            this.menuSuhuKelembapan = new System.Windows.Forms.CheckBox();
            this.tabPageBattery = new System.Windows.Forms.TabPage();
            this.labelBaterai7 = new System.Windows.Forms.Label();
            this.labelBaterai5 = new System.Windows.Forms.Label();
            this.labelBaterai3 = new System.Windows.Forms.Label();
            this.labelBaterai1 = new System.Windows.Forms.Label();
            this.labelBaterai6 = new System.Windows.Forms.Label();
            this.labelBaterai2 = new System.Windows.Forms.Label();
            this.labelBaterai4 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerLoop = new System.Windows.Forms.Timer(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageQuickCommand.SuspendLayout();
            this.tabPageQuickSet.SuspendLayout();
            this.tabPageBattery.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.RtsEnable = true;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Location = new System.Drawing.Point(5, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 83);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // buttonKirim
            // 
            this.buttonKirim.Location = new System.Drawing.Point(182, 223);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(105, 43);
            this.buttonKirim.TabIndex = 1;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = true;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // textBoxKirim
            // 
            this.textBoxKirim.Location = new System.Drawing.Point(4, 223);
            this.textBoxKirim.Multiline = true;
            this.textBoxKirim.Name = "textBoxKirim";
            this.textBoxKirim.Size = new System.Drawing.Size(171, 43);
            this.textBoxKirim.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxNotif);
            this.splitContainer1.Panel2.Controls.Add(this.buttonDisconnect);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBaud);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPort);
            this.splitContainer1.Panel2.Controls.Add(this.buttonConnect);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxKirim);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonKirim);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 625);
            this.splitContainer1.SplitterDistance = 704;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label5);
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.zedGraphControl);
            this.splitContainer2.Size = new System.Drawing.Size(704, 625);
            this.splitContainer2.SplitterDistance = 362;
            this.splitContainer2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Image = global::programGUI.Properties.Resources.Temperature_icon;
            this.pictureBox3.Location = new System.Drawing.Point(21, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Aqua;
            this.pictureBox2.Image = global::programGUI.Properties.Resources.humidity;
            this.pictureBox2.Location = new System.Drawing.Point(21, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lime;
            this.pictureBox1.Image = global::programGUI.Properties.Resources.battery_xxl;
            this.pictureBox1.Location = new System.Drawing.Point(21, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(615, 331);
            this.label7.MaximumSize = new System.Drawing.Size(270, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 296);
            this.label6.MaximumSize = new System.Drawing.Size(270, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 260);
            this.label5.MaximumSize = new System.Drawing.Size(270, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 300);
            this.label4.MaximumSize = new System.Drawing.Size(600, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "| bat1 | bat2 | bat3 | bat4 | bat5 |";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 196);
            this.label3.MaximumSize = new System.Drawing.Size(600, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(566, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "| humid1 | humid2 | humid3 | humid4 | humid5 |";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 98);
            this.label2.MaximumSize = new System.Drawing.Size(600, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "| suhu1 | suhu2 | suhu3 | suhu4 | suhu5 |";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 3);
            this.label1.MaximumSize = new System.Drawing.Size(600, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ket : | node1 | node2 | node3 | node4 | node5 |";
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(698, 247);
            this.zedGraphControl.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 108);
            this.label10.MaximumSize = new System.Drawing.Size(270, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mini Terminal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Notifikasi";
            // 
            // richTextBoxNotif
            // 
            this.richTextBoxNotif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBoxNotif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNotif.Location = new System.Drawing.Point(4, 5);
            this.richTextBoxNotif.Name = "richTextBoxNotif";
            this.richTextBoxNotif.Size = new System.Drawing.Size(283, 87);
            this.richTextBoxNotif.TabIndex = 8;
            this.richTextBoxNotif.Text = "";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(126, 308);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(161, 30);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.Text = "disConnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxBaud
            // 
            this.textBoxBaud.Location = new System.Drawing.Point(5, 308);
            this.textBoxBaud.Multiline = true;
            this.textBoxBaud.Name = "textBoxBaud";
            this.textBoxBaud.Size = new System.Drawing.Size(111, 30);
            this.textBoxBaud.TabIndex = 6;
            this.textBoxBaud.Text = "9600";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(5, 272);
            this.textBoxPort.Multiline = true;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(111, 30);
            this.textBoxPort.TabIndex = 5;
            this.textBoxPort.Text = "COM5";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(126, 272);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(161, 30);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageQuickCommand);
            this.tabControl1.Controls.Add(this.tabPageQuickSet);
            this.tabControl1.Controls.Add(this.tabPageBattery);
            this.tabControl1.Location = new System.Drawing.Point(5, 351);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(286, 265);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageQuickCommand
            // 
            this.tabPageQuickCommand.Controls.Add(this.buttonDollar);
            this.tabPageQuickCommand.Controls.Add(this.buttonPersen);
            this.tabPageQuickCommand.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuickCommand.Name = "tabPageQuickCommand";
            this.tabPageQuickCommand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuickCommand.Size = new System.Drawing.Size(278, 239);
            this.tabPageQuickCommand.TabIndex = 1;
            this.tabPageQuickCommand.Text = "QuickCommand";
            this.tabPageQuickCommand.UseVisualStyleBackColor = true;
            // 
            // buttonDollar
            // 
            this.buttonDollar.Location = new System.Drawing.Point(7, 117);
            this.buttonDollar.Name = "buttonDollar";
            this.buttonDollar.Size = new System.Drawing.Size(265, 116);
            this.buttonDollar.TabIndex = 8;
            this.buttonDollar.Text = "STOP KIRIM DATA ($)";
            this.buttonDollar.UseVisualStyleBackColor = true;
            this.buttonDollar.Click += new System.EventHandler(this.buttonDollar_Click);
            // 
            // buttonPersen
            // 
            this.buttonPersen.Location = new System.Drawing.Point(6, 6);
            this.buttonPersen.Name = "buttonPersen";
            this.buttonPersen.Size = new System.Drawing.Size(266, 105);
            this.buttonPersen.TabIndex = 7;
            this.buttonPersen.Text = "START KIRIM DATA (%)";
            this.buttonPersen.UseVisualStyleBackColor = true;
            this.buttonPersen.Click += new System.EventHandler(this.buttonPersen_Click);
            // 
            // tabPageQuickSet
            // 
            this.tabPageQuickSet.Controls.Add(this.comboBox1);
            this.tabPageQuickSet.Controls.Add(this.label11);
            this.tabPageQuickSet.Controls.Add(this.label8);
            this.tabPageQuickSet.Controls.Add(this.buttonStop);
            this.tabPageQuickSet.Controls.Add(this.buttonRecord);
            this.tabPageQuickSet.Controls.Add(this.textBoxSimpan);
            this.tabPageQuickSet.Controls.Add(this.menuSuhuKelembapan);
            this.tabPageQuickSet.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuickSet.Name = "tabPageQuickSet";
            this.tabPageQuickSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuickSet.Size = new System.Drawing.Size(278, 239);
            this.tabPageQuickSet.TabIndex = 0;
            this.tabPageQuickSet.Text = "QuickSetting";
            this.tabPageQuickSet.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 detik",
            "2 detik",
            "5 detik",
            "10 detik"});
            this.comboBox1.Location = new System.Drawing.Point(101, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Periode Sampling";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "isikan nama file penyimpanan";
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(6, 200);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(266, 37);
            this.buttonStop.TabIndex = 9;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRecord
            // 
            this.buttonRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecord.Location = new System.Drawing.Point(6, 154);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(266, 42);
            this.buttonRecord.TabIndex = 8;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // textBoxSimpan
            // 
            this.textBoxSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSimpan.Location = new System.Drawing.Point(6, 123);
            this.textBoxSimpan.Name = "textBoxSimpan";
            this.textBoxSimpan.Size = new System.Drawing.Size(266, 26);
            this.textBoxSimpan.TabIndex = 7;
            this.textBoxSimpan.Text = "simpan.csv";
            // 
            // menuSuhuKelembapan
            // 
            this.menuSuhuKelembapan.AutoSize = true;
            this.menuSuhuKelembapan.Checked = true;
            this.menuSuhuKelembapan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuSuhuKelembapan.Location = new System.Drawing.Point(9, 8);
            this.menuSuhuKelembapan.Name = "menuSuhuKelembapan";
            this.menuSuhuKelembapan.Size = new System.Drawing.Size(234, 17);
            this.menuSuhuKelembapan.TabIndex = 1;
            this.menuSuhuKelembapan.Text = "Centang = Suhu | noCentang = Kelembapan";
            this.menuSuhuKelembapan.UseVisualStyleBackColor = true;
            this.menuSuhuKelembapan.CheckedChanged += new System.EventHandler(this.menuSuhuKelembapan_CheckedChanged);
            // 
            // tabPageBattery
            // 
            this.tabPageBattery.Controls.Add(this.labelBaterai7);
            this.tabPageBattery.Controls.Add(this.labelBaterai5);
            this.tabPageBattery.Controls.Add(this.labelBaterai3);
            this.tabPageBattery.Controls.Add(this.labelBaterai1);
            this.tabPageBattery.Controls.Add(this.labelBaterai6);
            this.tabPageBattery.Controls.Add(this.labelBaterai2);
            this.tabPageBattery.Controls.Add(this.labelBaterai4);
            this.tabPageBattery.Location = new System.Drawing.Point(4, 22);
            this.tabPageBattery.Name = "tabPageBattery";
            this.tabPageBattery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBattery.Size = new System.Drawing.Size(278, 239);
            this.tabPageBattery.TabIndex = 2;
            this.tabPageBattery.Text = "BatteryStatus";
            this.tabPageBattery.UseVisualStyleBackColor = true;
            // 
            // labelBaterai7
            // 
            this.labelBaterai7.AutoSize = true;
            this.labelBaterai7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.labelBaterai7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaterai7.Location = new System.Drawing.Point(17, 198);
            this.labelBaterai7.MaximumSize = new System.Drawing.Size(270, 60);
            this.labelBaterai7.Name = "labelBaterai7";
            this.labelBaterai7.Size = new System.Drawing.Size(145, 31);
            this.labelBaterai7.TabIndex = 11;
            this.labelBaterai7.Text = "Bat7 = ???";
            // 
            // labelBaterai5
            // 
            this.labelBaterai5.AutoSize = true;
            this.labelBaterai5.BackColor = System.Drawing.Color.Purple;
            this.labelBaterai5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaterai5.Location = new System.Drawing.Point(17, 136);
            this.labelBaterai5.MaximumSize = new System.Drawing.Size(270, 60);
            this.labelBaterai5.Name = "labelBaterai5";
            this.labelBaterai5.Size = new System.Drawing.Size(145, 31);
            this.labelBaterai5.TabIndex = 10;
            this.labelBaterai5.Text = "Bat5 = ???";
            // 
            // labelBaterai3
            // 
            this.labelBaterai3.AutoSize = true;
            this.labelBaterai3.BackColor = System.Drawing.Color.GreenYellow;
            this.labelBaterai3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaterai3.Location = new System.Drawing.Point(17, 74);
            this.labelBaterai3.MaximumSize = new System.Drawing.Size(270, 60);
            this.labelBaterai3.Name = "labelBaterai3";
            this.labelBaterai3.Size = new System.Drawing.Size(145, 31);
            this.labelBaterai3.TabIndex = 9;
            this.labelBaterai3.Text = "Bat3 = ???";
            // 
            // labelBaterai1
            // 
            this.labelBaterai1.AutoSize = true;
            this.labelBaterai1.BackColor = System.Drawing.Color.DeepPink;
            this.labelBaterai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaterai1.Location = new System.Drawing.Point(17, 12);
            this.labelBaterai1.MaximumSize = new System.Drawing.Size(270, 60);
            this.labelBaterai1.Name = "labelBaterai1";
            this.labelBaterai1.Size = new System.Drawing.Size(145, 31);
            this.labelBaterai1.TabIndex = 8;
            this.labelBaterai1.Text = "Bat1 = ???";
            // 
            // labelBaterai6
            // 
            this.labelBaterai6.AutoSize = true;
            this.labelBaterai6.BackColor = System.Drawing.Color.Cyan;
            this.labelBaterai6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaterai6.Location = new System.Drawing.Point(17, 167);
            this.labelBaterai6.MaximumSize = new System.Drawing.Size(270, 60);
            this.labelBaterai6.Name = "labelBaterai6";
            this.labelBaterai6.Size = new System.Drawing.Size(145, 31);
            this.labelBaterai6.TabIndex = 7;
            this.labelBaterai6.Text = "Bat6 = ???";
            // 
            // labelBaterai2
            // 
            this.labelBaterai2.AutoSize = true;
            this.labelBaterai2.BackColor = System.Drawing.Color.Lime;
            this.labelBaterai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaterai2.Location = new System.Drawing.Point(17, 43);
            this.labelBaterai2.MaximumSize = new System.Drawing.Size(270, 60);
            this.labelBaterai2.Name = "labelBaterai2";
            this.labelBaterai2.Size = new System.Drawing.Size(145, 31);
            this.labelBaterai2.TabIndex = 6;
            this.labelBaterai2.Text = "Bat2 = ???";
            // 
            // labelBaterai4
            // 
            this.labelBaterai4.AutoSize = true;
            this.labelBaterai4.BackColor = System.Drawing.Color.Tomato;
            this.labelBaterai4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaterai4.Location = new System.Drawing.Point(17, 105);
            this.labelBaterai4.MaximumSize = new System.Drawing.Size(270, 60);
            this.labelBaterai4.Name = "labelBaterai4";
            this.labelBaterai4.Size = new System.Drawing.Size(145, 31);
            this.labelBaterai4.TabIndex = 5;
            this.labelBaterai4.Text = "Bat4 = ???";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.recordToolStripMenuItem.Text = "Record";
            this.recordToolStripMenuItem.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timerLoop
            // 
            this.timerLoop.Tick += new System.EventHandler(this.timerLoop_Tick);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(182, 108);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(98, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear Terminal";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Wireless Sensor Network UI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageQuickCommand.ResumeLayout(false);
            this.tabPageQuickSet.ResumeLayout(false);
            this.tabPageQuickSet.PerformLayout();
            this.tabPageBattery.ResumeLayout(false);
            this.tabPageBattery.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.TextBox textBoxKirim;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageQuickCommand;
        private System.Windows.Forms.TextBox textBoxBaud;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Timer timerLoop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageQuickSet;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxNotif;
        private System.Windows.Forms.CheckBox menuSuhuKelembapan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.TextBox textBoxSimpan;
        private System.Windows.Forms.Button buttonPersen;
        private System.Windows.Forms.TabPage tabPageBattery;
        private System.Windows.Forms.Label labelBaterai7;
        private System.Windows.Forms.Label labelBaterai5;
        private System.Windows.Forms.Label labelBaterai3;
        private System.Windows.Forms.Label labelBaterai1;
        private System.Windows.Forms.Label labelBaterai6;
        private System.Windows.Forms.Label labelBaterai2;
        private System.Windows.Forms.Label labelBaterai4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDollar;
        private System.Windows.Forms.Button buttonClear;
    }
}

