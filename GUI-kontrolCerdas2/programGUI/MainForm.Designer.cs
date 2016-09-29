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
            this.richTextBoxDataTerima = new System.Windows.Forms.RichTextBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.textBoxKirim = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelSetPoint = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelPWM = new System.Windows.Forms.Label();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxNotif = new System.Windows.Forms.RichTextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxBaud = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageQuickCommand = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonPeriode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPeriode = new System.Windows.Forms.TextBox();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonIB = new System.Windows.Forms.Button();
            this.buttonPW = new System.Windows.Forms.Button();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxIB = new System.Windows.Forms.TextBox();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.textBoxKirimSetPoin = new System.Windows.Forms.TextBox();
            this.buttonDollar = new System.Windows.Forms.Button();
            this.buttonSetPoin = new System.Windows.Forms.Button();
            this.tabPageQuickSet = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.textBoxSimpan = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerLoop = new System.Windows.Forms.Timer(this.components);
            this.labelAddon = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.checkBoxAcak = new System.Windows.Forms.CheckBox();
            this.checkBoxSetPointPeriodik = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageQuickCommand.SuspendLayout();
            this.tabPageQuickSet.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 19200;
            this.serialPort.RtsEnable = true;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // richTextBoxDataTerima
            // 
            this.richTextBoxDataTerima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDataTerima.EnableAutoDragDrop = true;
            this.richTextBoxDataTerima.Location = new System.Drawing.Point(5, 135);
            this.richTextBoxDataTerima.Name = "richTextBoxDataTerima";
            this.richTextBoxDataTerima.Size = new System.Drawing.Size(282, 83);
            this.richTextBoxDataTerima.TabIndex = 0;
            this.richTextBoxDataTerima.Text = "";
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
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxDataTerima);
            this.splitContainer1.Panel2.Controls.Add(this.buttonKirim);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 625);
            this.splitContainer1.SplitterDistance = 705;
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
            this.splitContainer2.Panel1.Controls.Add(this.labelError);
            this.splitContainer2.Panel1.Controls.Add(this.labelAddon);
            this.splitContainer2.Panel1.Controls.Add(this.labelSetPoint);
            this.splitContainer2.Panel1.Controls.Add(this.labelSpeed);
            this.splitContainer2.Panel1.Controls.Add(this.labelPWM);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.zedGraphControl);
            this.splitContainer2.Size = new System.Drawing.Size(705, 625);
            this.splitContainer2.SplitterDistance = 97;
            this.splitContainer2.TabIndex = 0;
            // 
            // labelSetPoint
            // 
            this.labelSetPoint.AutoSize = true;
            this.labelSetPoint.BackColor = System.Drawing.Color.Blue;
            this.labelSetPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetPoint.Location = new System.Drawing.Point(377, 5);
            this.labelSetPoint.MaximumSize = new System.Drawing.Size(600, 60);
            this.labelSetPoint.Name = "labelSetPoint";
            this.labelSetPoint.Size = new System.Drawing.Size(165, 25);
            this.labelSetPoint.TabIndex = 3;
            this.labelSetPoint.Text = "Set Point : 0000";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Red;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(3, 5);
            this.labelSpeed.MaximumSize = new System.Drawing.Size(600, 60);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(193, 25);
            this.labelSpeed.TabIndex = 2;
            this.labelSpeed.Text = "Speed : 0000 RPM";
            // 
            // labelPWM
            // 
            this.labelPWM.AutoSize = true;
            this.labelPWM.BackColor = System.Drawing.Color.Green;
            this.labelPWM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPWM.Location = new System.Drawing.Point(202, 5);
            this.labelPWM.MaximumSize = new System.Drawing.Size(600, 60);
            this.labelPWM.Name = "labelPWM";
            this.labelPWM.Size = new System.Drawing.Size(169, 25);
            this.labelPWM.TabIndex = 1;
            this.labelPWM.Text = "PWM (%) : 0000";
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Location = new System.Drawing.Point(0, 3);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0D;
            this.zedGraphControl.ScrollMaxX = 0D;
            this.zedGraphControl.ScrollMaxY = 0D;
            this.zedGraphControl.ScrollMaxY2 = 0D;
            this.zedGraphControl.ScrollMinX = 0D;
            this.zedGraphControl.ScrollMinY = 0D;
            this.zedGraphControl.ScrollMinY2 = 0D;
            this.zedGraphControl.Size = new System.Drawing.Size(698, 518);
            this.zedGraphControl.TabIndex = 0;
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
            this.textBoxBaud.Text = "19200";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(5, 272);
            this.textBoxPort.Multiline = true;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(111, 30);
            this.textBoxPort.TabIndex = 5;
            this.textBoxPort.Text = "COM7";
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
            this.tabControl1.Location = new System.Drawing.Point(5, 344);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(286, 281);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageQuickCommand
            // 
            this.tabPageQuickCommand.Controls.Add(this.checkBoxSetPointPeriodik);
            this.tabPageQuickCommand.Controls.Add(this.checkBoxAcak);
            this.tabPageQuickCommand.Controls.Add(this.label2);
            this.tabPageQuickCommand.Controls.Add(this.comboBox1);
            this.tabPageQuickCommand.Controls.Add(this.buttonPeriode);
            this.tabPageQuickCommand.Controls.Add(this.label1);
            this.tabPageQuickCommand.Controls.Add(this.label7);
            this.tabPageQuickCommand.Controls.Add(this.label6);
            this.tabPageQuickCommand.Controls.Add(this.label5);
            this.tabPageQuickCommand.Controls.Add(this.label4);
            this.tabPageQuickCommand.Controls.Add(this.textBoxPeriode);
            this.tabPageQuickCommand.Controls.Add(this.buttonD);
            this.tabPageQuickCommand.Controls.Add(this.buttonIB);
            this.tabPageQuickCommand.Controls.Add(this.buttonPW);
            this.tabPageQuickCommand.Controls.Add(this.textBoxD);
            this.tabPageQuickCommand.Controls.Add(this.textBoxIB);
            this.tabPageQuickCommand.Controls.Add(this.textBoxPW);
            this.tabPageQuickCommand.Controls.Add(this.textBoxKirimSetPoin);
            this.tabPageQuickCommand.Controls.Add(this.buttonDollar);
            this.tabPageQuickCommand.Controls.Add(this.buttonSetPoin);
            this.tabPageQuickCommand.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuickCommand.Name = "tabPageQuickCommand";
            this.tabPageQuickCommand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuickCommand.Size = new System.Drawing.Size(278, 255);
            this.tabPageQuickCommand.TabIndex = 1;
            this.tabPageQuickCommand.Text = "QuickCommand";
            this.tabPageQuickCommand.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.MaximumSize = new System.Drawing.Size(600, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sinyal Set Poin";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "manual",
            "periodik"});
            this.comboBox1.Location = new System.Drawing.Point(6, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonPeriode
            // 
            this.buttonPeriode.Location = new System.Drawing.Point(231, 53);
            this.buttonPeriode.Name = "buttonPeriode";
            this.buttonPeriode.Size = new System.Drawing.Size(40, 24);
            this.buttonPeriode.TabIndex = 22;
            this.buttonPeriode.Text = "SET";
            this.buttonPeriode.UseVisualStyleBackColor = true;
            this.buttonPeriode.Click += new System.EventHandler(this.buttonPeriode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.MaximumSize = new System.Drawing.Size(600, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Periode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 173);
            this.label7.MaximumSize = new System.Drawing.Size(270, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cyan;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 145);
            this.label6.MaximumSize = new System.Drawing.Size(270, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "I/B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 115);
            this.label5.MaximumSize = new System.Drawing.Size(270, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "P/W";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 83);
            this.label4.MaximumSize = new System.Drawing.Size(600, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Set Poin";
            // 
            // textBoxPeriode
            // 
            this.textBoxPeriode.Location = new System.Drawing.Point(127, 51);
            this.textBoxPeriode.Multiline = true;
            this.textBoxPeriode.Name = "textBoxPeriode";
            this.textBoxPeriode.Size = new System.Drawing.Size(98, 24);
            this.textBoxPeriode.TabIndex = 16;
            this.textBoxPeriode.Text = "20";
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(230, 171);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(40, 24);
            this.buttonD.TabIndex = 15;
            this.buttonD.Text = "SET";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonIB
            // 
            this.buttonIB.Location = new System.Drawing.Point(230, 141);
            this.buttonIB.Name = "buttonIB";
            this.buttonIB.Size = new System.Drawing.Size(40, 24);
            this.buttonIB.TabIndex = 14;
            this.buttonIB.Text = "SET";
            this.buttonIB.UseVisualStyleBackColor = true;
            this.buttonIB.Click += new System.EventHandler(this.buttonIB_Click);
            // 
            // buttonPW
            // 
            this.buttonPW.Location = new System.Drawing.Point(230, 111);
            this.buttonPW.Name = "buttonPW";
            this.buttonPW.Size = new System.Drawing.Size(40, 24);
            this.buttonPW.TabIndex = 13;
            this.buttonPW.Text = "SET";
            this.buttonPW.UseVisualStyleBackColor = true;
            this.buttonPW.Click += new System.EventHandler(this.buttonPW_Click);
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(127, 171);
            this.textBoxD.Multiline = true;
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(98, 24);
            this.textBoxD.TabIndex = 12;
            this.textBoxD.Text = "0";
            // 
            // textBoxIB
            // 
            this.textBoxIB.Location = new System.Drawing.Point(127, 141);
            this.textBoxIB.Multiline = true;
            this.textBoxIB.Name = "textBoxIB";
            this.textBoxIB.Size = new System.Drawing.Size(98, 24);
            this.textBoxIB.TabIndex = 11;
            this.textBoxIB.Text = "0";
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(127, 111);
            this.textBoxPW.Multiline = true;
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.Size = new System.Drawing.Size(98, 24);
            this.textBoxPW.TabIndex = 10;
            this.textBoxPW.Text = "0";
            // 
            // textBoxKirimSetPoin
            // 
            this.textBoxKirimSetPoin.Location = new System.Drawing.Point(127, 81);
            this.textBoxKirimSetPoin.Multiline = true;
            this.textBoxKirimSetPoin.Name = "textBoxKirimSetPoin";
            this.textBoxKirimSetPoin.Size = new System.Drawing.Size(97, 24);
            this.textBoxKirimSetPoin.TabIndex = 9;
            this.textBoxKirimSetPoin.Text = "0";
            // 
            // buttonDollar
            // 
            this.buttonDollar.Location = new System.Drawing.Point(7, 207);
            this.buttonDollar.Name = "buttonDollar";
            this.buttonDollar.Size = new System.Drawing.Size(265, 42);
            this.buttonDollar.TabIndex = 8;
            this.buttonDollar.Text = "STOP KIRIM DATA ($)";
            this.buttonDollar.UseVisualStyleBackColor = true;
            this.buttonDollar.Visible = false;
            this.buttonDollar.Click += new System.EventHandler(this.buttonDollar_Click);
            // 
            // buttonSetPoin
            // 
            this.buttonSetPoin.Location = new System.Drawing.Point(230, 81);
            this.buttonSetPoin.Name = "buttonSetPoin";
            this.buttonSetPoin.Size = new System.Drawing.Size(40, 24);
            this.buttonSetPoin.TabIndex = 7;
            this.buttonSetPoin.Text = "SET";
            this.buttonSetPoin.UseVisualStyleBackColor = true;
            this.buttonSetPoin.Click += new System.EventHandler(this.buttonSetPoin_Click);
            // 
            // tabPageQuickSet
            // 
            this.tabPageQuickSet.Controls.Add(this.label8);
            this.tabPageQuickSet.Controls.Add(this.buttonStop);
            this.tabPageQuickSet.Controls.Add(this.buttonRecord);
            this.tabPageQuickSet.Controls.Add(this.textBoxSimpan);
            this.tabPageQuickSet.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuickSet.Name = "tabPageQuickSet";
            this.tabPageQuickSet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuickSet.Size = new System.Drawing.Size(278, 255);
            this.tabPageQuickSet.TabIndex = 0;
            this.tabPageQuickSet.Text = "QuickSetting";
            this.tabPageQuickSet.UseVisualStyleBackColor = true;
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
            this.timerLoop.Interval = 10;
            this.timerLoop.Tick += new System.EventHandler(this.timerLoop_Tick);
            // 
            // labelAddon
            // 
            this.labelAddon.AutoSize = true;
            this.labelAddon.BackColor = System.Drawing.Color.Magenta;
            this.labelAddon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddon.Location = new System.Drawing.Point(5, 74);
            this.labelAddon.MaximumSize = new System.Drawing.Size(600, 60);
            this.labelAddon.Name = "labelAddon";
            this.labelAddon.Size = new System.Drawing.Size(40, 18);
            this.labelAddon.TabIndex = 4;
            this.labelAddon.Text = "????";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Yellow;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(3, 40);
            this.labelError.MaximumSize = new System.Drawing.Size(600, 60);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(241, 25);
            this.labelError.TabIndex = 5;
            this.labelError.Text = "Rata2 Error : 0000 RPM";
            // 
            // checkBoxAcak
            // 
            this.checkBoxAcak.AutoSize = true;
            this.checkBoxAcak.Location = new System.Drawing.Point(127, 28);
            this.checkBoxAcak.Name = "checkBoxAcak";
            this.checkBoxAcak.Size = new System.Drawing.Size(94, 17);
            this.checkBoxAcak.TabIndex = 25;
            this.checkBoxAcak.Text = "Set Poin Acak";
            this.checkBoxAcak.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetPointPeriodik
            // 
            this.checkBoxSetPointPeriodik.AutoSize = true;
            this.checkBoxSetPointPeriodik.Location = new System.Drawing.Point(127, 6);
            this.checkBoxSetPointPeriodik.Name = "checkBoxSetPointPeriodik";
            this.checkBoxSetPointPeriodik.Size = new System.Drawing.Size(107, 17);
            this.checkBoxSetPointPeriodik.TabIndex = 26;
            this.checkBoxSetPointPeriodik.Text = "Set Poin Periodik";
            this.checkBoxSetPointPeriodik.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prak. Kontrol Cerdas 2 | github.com/nitbot/nitbotLabs";
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
            this.tabControl1.ResumeLayout(false);
            this.tabPageQuickCommand.ResumeLayout(false);
            this.tabPageQuickCommand.PerformLayout();
            this.tabPageQuickSet.ResumeLayout(false);
            this.tabPageQuickSet.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.RichTextBox richTextBoxDataTerima;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.TextBox textBoxKirim;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.TextBox textBoxBaud;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Timer timerLoop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelSetPoint;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelPWM;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxNotif;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageQuickCommand;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonIB;
        private System.Windows.Forms.Button buttonPW;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxIB;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.TextBox textBoxKirimSetPoin;
        private System.Windows.Forms.Button buttonDollar;
        private System.Windows.Forms.Button buttonSetPoin;
        private System.Windows.Forms.TabPage tabPageQuickSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.TextBox textBoxSimpan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPeriode;
        private System.Windows.Forms.Button buttonPeriode;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAddon;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.CheckBox checkBoxAcak;
        private System.Windows.Forms.CheckBox checkBoxSetPointPeriodik;
    }
}

