using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Globalization;
using csvFileIO;

namespace programGUI
{
    public partial class MainForm : Form
    {
        int timeSampling=1;
        //tambahkan variable global di sini
        String[] dataUkur1, dataUkur2, dataUkur3, dataUkur4, dataUkur5,dataUkur6,dataUkur7;
        String terima;
        bool ambilData=true, modeTerimaData = false, upDown=false;
        bool recording=false;
        int tickStart, periode=20;
        String dataSimpan, pDataSimpan;
        double kecepatanMotor, setPoint, PWM, bobot, bias, rata2Error=0;
        double proporsional, integral, diferensial, Error;
        System.IO.StreamWriter fileSimpan, periodikFileSimpan;
        int setPointPC=0, P=0, I=0,D=0;
        byte manualPeriodikAcak=0;
        Random rnd = new Random();
        
       
        RollingPointPairList list1 = new RollingPointPairList(1200);
        RollingPointPairList list2 = new RollingPointPairList(1200);
        RollingPointPairList list3 = new RollingPointPairList(1200);
        RollingPointPairList list4 = new RollingPointPairList(1200);
        RollingPointPairList list5 = new RollingPointPairList(1200);
        RollingPointPairList list6 = new RollingPointPairList(1200);
        RollingPointPairList list7 = new RollingPointPairList(1200);

        System.Reflection.PropertyInfo list1item = null;
        System.Reflection.PropertyInfo list2item = null;
        System.Reflection.PropertyInfo list3item = null;
        System.Reflection.PropertyInfo list4item = null;
        System.Reflection.PropertyInfo list5item = null;
        System.Reflection.PropertyInfo list6item = null;
        System.Reflection.PropertyInfo list7item = null;

        CurveItem list1curve;
        CurveItem list2curve;
        CurveItem list3curve;
        CurveItem list4curve;
        CurveItem list5curve;
        CurveItem list6curve;
        CurveItem list7curve;

        public MainForm()
        {
            InitializeComponent();

        }

        #region Grafik
        private void init_zedGraph()
        {
            zedGraphControl.Visible = true;
            GraphPane myPaneAcc = zedGraphControl.GraphPane;

            myPaneAcc.Title.FontSpec.Size = 20.0f;
            myPaneAcc.Title.Text = "Data Rekam Respon Plant";

            myPaneAcc.XAxis.Title.Text = "Waktu, detik";
            myPaneAcc.YAxis.Title.Text = "Kecepatan, RPM";

            LineItem curve1 = myPaneAcc.AddCurve("Set Poin", list1, Color.Blue, SymbolType.None);
            LineItem curve2 = myPaneAcc.AddCurve("PWM", list2, Color.Green, SymbolType.None);
            LineItem curve3 = myPaneAcc.AddCurve("Speed", list3, Color.Red, SymbolType.None);
            //LineItem curve4 = myPaneAcc.AddCurve("n4", list4, Color.Purple, SymbolType.None);
            //LineItem curve5 = myPaneAcc.AddCurve("n5", list5, Color.Yellow, SymbolType.None);
            //LineItem curve6 = myPaneAcc.AddCurve("n6", list6, Color.Pink, SymbolType.None);
            //LineItem curve7 = myPaneAcc.AddCurve("n7", list7, Color.Orange, SymbolType.None);

            curve1.Line.Width = 3.0f;
            curve2.Line.Width = 3.0f;
            curve3.Line.Width = 3.0f;
            //curve4.Line.Width = 3.0f;
            //curve5.Line.Width = 3.0f;
            //curve6.Line.Width = 3.0f;
            //curve7.Line.Width = 3.0f;

            myPaneAcc.XAxis.Scale.Min = 2;
            myPaneAcc.XAxis.Scale.MinorStep = 0.1;
            myPaneAcc.XAxis.Scale.MajorStep = 1;
            zedGraphControl.AxisChange();
            tickStart = Environment.TickCount;
        }

        private void setKurvaGrafik(byte node, double dataGrafik)
        {
            if (zedGraphControl.GraphPane.CurveList.Count <= 0)
                return;

            double time = (Environment.TickCount - tickStart) / 1000.0;

            switch (node)
            { 
                case 1:
                    LineItem curve1 = zedGraphControl.GraphPane.CurveList[0] as LineItem;
                    if (curve1 == null)
                        return;
                    IPointListEdit list1 = curve1.Points as IPointListEdit;
                    if (list1 == null)
                        return;
                    list1.Add(time, Convert.ToDouble(dataGrafik));
                    break;
                case 2:
                    LineItem curve2 = zedGraphControl.GraphPane.CurveList[1] as LineItem;
                    if (curve2 == null)
                        return;
                    IPointListEdit list2 = curve2.Points as IPointListEdit;
                    if (list2 == null)
                        return;
                    list2.Add(time, Convert.ToDouble(dataGrafik));
                    break;
                case 3:
                    LineItem curve3 = zedGraphControl.GraphPane.CurveList[2] as LineItem;
                    if (curve3 == null)
                        return;
                    IPointListEdit list3 = curve3.Points as IPointListEdit;
                    if (list3 == null)
                        return;
                    list3.Add(time, Convert.ToDouble(dataGrafik));
                    
                    break;
                case 4:
                    LineItem curve4 = zedGraphControl.GraphPane.CurveList[3] as LineItem;
                    if (curve4 == null)
                        return;
                    IPointListEdit list4 = curve4.Points as IPointListEdit;
                    if (list4 == null)
                        return;
                    list4.Add(time, Convert.ToDouble(dataGrafik));
                    break;
                case 5:
                    LineItem curve5 = zedGraphControl.GraphPane.CurveList[4] as LineItem;
                    if (curve5 == null)
                        return;
                    IPointListEdit list5 = curve5.Points as IPointListEdit;
                    if (list5 == null)
                        return;
                    list5.Add(time, Convert.ToDouble(dataGrafik));
                    break;
                case 6:
                    LineItem curve6 = zedGraphControl.GraphPane.CurveList[5] as LineItem;
                    if (curve6 == null)
                        return;
                    IPointListEdit list6 = curve6.Points as IPointListEdit;
                    if (list6 == null)
                        return;
                    list6.Add(time, Convert.ToDouble(dataGrafik));
                    break;
                case 7:
                    LineItem curve7 = zedGraphControl.GraphPane.CurveList[6] as LineItem;
                    if (curve7 == null)
                        return;
                    IPointListEdit list7 = curve7.Points as IPointListEdit;
                    if (list7 == null)
                        return;
                    list7.Add(time, Convert.ToDouble(dataGrafik));
                    break;

            }
            Scale xScale = zedGraphControl.GraphPane.XAxis.Scale;

            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = xScale.Max - 30.0;
            }
            zedGraphControl.AxisChange();
            zedGraphControl.Invalidate();
        }
        #endregion

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (modeTerimaData)
            {
                try
                {
                    terima = serialPort.ReadTo("\r");

                }
                catch
                { }
                this.BeginInvoke(new EventHandler(parseData));
            }
        }

        private void parseData(object sender, EventArgs e)
        {
            String[] Data;
            char[] delimiterChars = { ',' };

            richTextBoxDataTerima.AppendText(terima + "\n");
            Data = terima.Split(delimiterChars);
            Console.WriteLine(Data.Length);
            byte i;
            string header;
            try
            {
                for (i = 0; i < Data.Length; i++)
                {
                    header = Data[i].Substring(0, 1);
                    switch (header)
                    {
                        case "R":
                            setPoint = int.Parse(Data[i].Substring(1)); // merah
                            break;
                        case "S":
                            kecepatanMotor = int.Parse(Data[i].Substring(1)); // biru
                            break;
                        case "P":
                            PWM = int.Parse(Data[i].Substring(1));
                            break;
                        case "p":
                            proporsional = double.Parse(Data[i].Substring(1));
                            break;
                        case "i":
                            integral = double.Parse(Data[i].Substring(1));
                            break;
                        case "d":
                            diferensial = double.Parse(Data[i].Substring(1));
                            break;
                        case "W":
                            bobot = double.Parse(Data[i].Substring(1));
                            break;
                        case "B":
                            bias = double.Parse(Data[i].Substring(1));
                            break;
                        case "E":
                            Error = int.Parse(Data[i].Substring(1));
                            break;
                        default :
                            break;
                    }
                }
            }
            catch { }
            /*
            dataUkur1 = Data[0].Split('R');
            Console.WriteLine(dataUkur1[1]);
            dataUkur2 = Data[1].Split('S');
            Console.WriteLine(dataUkur2[1]);
            dataUkur3 = Data[2].Split('P');
            Console.WriteLine(dataUkur3[1]);
            dataUkur4 = Data[3].Split('p');
            Console.WriteLine(dataUkur4[1]);
            dataUkur5 = Data[4].Split('i');
            Console.WriteLine(dataUkur5[1]);
            dataUkur6 = Data[3].Split('d');
            Console.WriteLine(dataUkur6[1]);
            dataUkur7 = Data[4].Split('E');
            Console.WriteLine(dataUkur7[1]);
            */

            labelSpeed.Text = "Speed : " + kecepatanMotor.ToString() + " RPM";
            labelSetPoint.Text = "Set Poin : " + setPoint.ToString();
            labelPWM.Text = "PWM : " + PWM.ToString();
            labelAddon.Text = "P = " + proporsional.ToString() + " I = " + integral.ToString() + " D = " + diferensial.ToString() + " W = " + bobot.ToString() + " B = " + bias.ToString() + " Error = " + Error.ToString() + "\n";

            //kecepatanMotor = double.Parse(dataUkur1[1]);
            //setPoint = double.Parse(dataUkur2[1]);
            //PWM = double.Parse(dataUkur3[1]);
            //bobot = double.Parse(dataUkur4[1]);
            //bias = double.Parse(dataUkur5[1]);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            init_zedGraph();
            comboBox1.SelectedIndex = 0;
            
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.WriteLine(textBoxKirim.Text);
                textBoxKirim.Text = "";
            }
            catch 
            {
                MessageBox.Show("tidak dapat dieksekusi, sepertinya PORT bermasalah", "Kontrol Cerdas 2");
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = textBoxPort.Text;
                serialPort.BaudRate = int.Parse(textBoxBaud.Text);
                serialPort.Open();
                modeTerimaData = true;
                timerLoop.Start();
                MessageBox.Show("PORT telah sukses dibuka", "Kontrol Cerdas 2");
            }
            catch
            {
                if (serialPort.IsOpen) MessageBox.Show("Sudah Konek", "Kontrol Cerdas 2");
                else MessageBox.Show("Sepertinya PORT yang anda gunakan bermasalah, coba cek PORT di device manager", "Kontrol Cerdas 2");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            modeTerimaData = false;
            try
            {
                if (serialPort.IsOpen) serialPort.Close();
                timerLoop.Stop();
                MessageBox.Show("PORT telah sukses ditutup", "Kontrol Cerdas 2");
            }
            catch
            {
                MessageBox.Show("gagal menutup PORT", "Kontrol Cerdas 2");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software bermasalah? Atau ingin dikembangkan? Silahkan hubungi TBGrup PENS / niam@pens.ac.id", "nitbot.com");
        }
        private void periodikSimpan()
        {
            if (recording)
            {
                /*
                pDataSimpan = String.Format("{0:T}", DateTime.Now) + "," + "01" + "," + "FF" + "," + " " + "," + " " + "," + Convert.ToString(suhu1) + "," + Convert.ToString(kelembapan1) + "," + Convert.ToString(baterai1) + "," + " ";
                periodikFileSimpan.WriteLine(pDataSimpan);
                pDataSimpan = String.Format("{0:T}", DateTime.Now) + "," + "02" + "," + "FF" + "," + " " + "," + " " + "," + Convert.ToString(suhu2) + "," + Convert.ToString(kelembapan2) + "," + Convert.ToString(baterai2) + "," + " ";
                periodikFileSimpan.WriteLine(pDataSimpan);
                pDataSimpan = String.Format("{0:T}", DateTime.Now) + "," + "03" + "," + "FF" + "," + " " + "," + " " + "," + Convert.ToString(suhu3) + "," + Convert.ToString(kelembapan3) + "," + Convert.ToString(baterai3) + "," + " ";
                periodikFileSimpan.WriteLine(pDataSimpan);
                pDataSimpan = String.Format("{0:T}", DateTime.Now) + "," + "04" + "," + "FF" + "," + " " + "," + " " + "," + Convert.ToString(suhu4) + "," + Convert.ToString(kelembapan4) + "," + Convert.ToString(baterai4) + "," + " ";
                periodikFileSimpan.WriteLine(pDataSimpan);
                pDataSimpan = String.Format("{0:T}", DateTime.Now) + "," + "05" + "," + "FF" + "," + " " + "," + " " + "," + Convert.ToString(suhu5) + "," + Convert.ToString(kelembapan5) + "," + Convert.ToString(baterai5) + "," + " ";
                periodikFileSimpan.WriteLine(pDataSimpan);
                 */
            }
        }
        private void timerLoop_Tick(object sender, EventArgs e)
        {
            timeSampling++;
            if (checkBoxSetPointPeriodik.Checked)
            {
                if (timeSampling >= (periode * 10))
                {
                    timeSampling = 1;
                    try
                    {
                        if (checkBoxAcak.Checked == true)
                        {
                            int pengaliSetPoint = rnd.Next(0, 20); // creates a number between 1 and 12
                            setPointPC = pengaliSetPoint * 100;
                        }
                        else
                        {
                            setPointPC = int.Parse(textBoxKirimSetPoin.Text);
                        }
                        if (upDown)
                        {
                            try
                            {
                                serialPort.Write("s" + setPointPC.ToString("D4") + "\r");    // Ubah format 575 > D4 > 0575
                            }
                            catch { }
                        }
                        else if (!upDown)
                        {
                            if (!checkBoxAcak.Checked)
                            {
                                setPointPC = 0;
                            }
                            try
                            {
                                serialPort.Write("s" + setPointPC.ToString("D4") + "\r");    // Ubah format 575 > D4 > 0575
                            }
                            catch { }
                        }
                        upDown = !upDown;
                    }
                    catch { }
                    
                }
            }
            rata2Error = 0.5*rata2Error+0.5*(setPointPC - kecepatanMotor);
            labelError.Text = "Rata2 Error " + String.Format("{0:0.##}", rata2Error) + " RPM";
            try { setKurvaGrafik(1, setPointPC); }
            catch { }
            try { setKurvaGrafik(2, PWM); }
            catch { }
            try { setKurvaGrafik(3, kecepatanMotor); }
            catch { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { stopRekam(); }
            catch { }
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                    timerLoop.Stop();
                    MessageBox.Show("PORT telah sukses ditutup", "Kontrol Cerdas 2");
                    
                }
                catch
                {
                    MessageBox.Show("gagal menutup PORT", "Kontrol Cerdas 2");
                }
            }
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startRekam();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopRekam();
        }
        private void startRekam()
        {
            try
            {
                fileSimpan = new System.IO.StreamWriter(textBoxSimpan.Text);
                periodikFileSimpan = new System.IO.StreamWriter("periodik" + textBoxSimpan.Text);
                fileSimpan.WriteLine("Time, Asal, Tujuan, data Respon, All Payload, Suhu (C), Kelembapan (%), Baterai (V)");
                periodikFileSimpan.WriteLine("Time, Asal, Tujuan, data Respon, All Payload, Suhu (C), Kelembapan (%), Baterai (V)");
                recording = true;
                MainForm.ActiveForm.Text = "Kontrol Cerdas 2 UI | Recording";            
            }
            catch 
            {
                MessageBox.Show("Sepertinya penyimpanan data bermasalah, tutup dahulu data csv yang anda buka", "Kontrol Cerdas 2");
            }
            
        }
        private void stopRekam()
        {
            recording = false;
            fileSimpan.Close();
            periodikFileSimpan.Close();
            MainForm.ActiveForm.Text = "Kontrol Cerdas 2";  
        }

        private void catat(String dataText)
        {
            richTextBoxNotif.AppendText(dataText);
            MessageBox.Show(dataText, "Kontrol Cerdas 2");
        }

        private void buttonSetPoin_Click(object sender, EventArgs e)
        {
            setPointPC = int.Parse(textBoxKirimSetPoin.Text);
            try
            {
                serialPort.Write("s" + setPointPC.ToString("D4") + "\r");    // Ubah format 575 > D4 > 0575
            }
            catch { }
        }

        void WriteTest()
        {
            // Write sample data to CSV file
            using (CsvFileWriter writer = new CsvFileWriter("WriteTest.csv"))
            {
                for (int i = 0; i < 100; i++)
                {
                    CsvRow row = new CsvRow();
                    for (int j = 0; j < 5; j++)
                        row.Add(String.Format("Column{0}", j));
                    writer.WriteRow(row);
                }
            }
        }

        void ReadTest()
        {
            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader("ReadTest.csv"))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    foreach (string s in row)
                    {
                        Console.Write(s);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stopRekam();
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            startRekam();
        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            timerLoop.Stop();
            if (serialPort.IsOpen)
            {
                serialPort.Write("$");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxDataTerima.Text = "";
        }

        private void buttonPeriode_Click(object sender, EventArgs e)
        {
            periode = int.Parse(textBoxPeriode.Text);
        }

        private void buttonPW_Click(object sender, EventArgs e)
        {
            P = (int)(double.Parse(textBoxPW.Text)*100);
            richTextBoxNotif.AppendText("p" + P.ToString("D4") + "\r");
            try
            {
                serialPort.Write("p" + P.ToString("D4") + "\r");    // Ubah format 575 > D4 > 0575
                
            }
            catch { }
        }

        private void buttonIB_Click(object sender, EventArgs e)
        {
            I = (int)(double.Parse(textBoxIB.Text)*100);
            richTextBoxNotif.AppendText("i" + I.ToString("D4") + "\r");
            try
            {
                serialPort.Write("i" + I.ToString("D4") + "\r");    // Ubah format 575 > D4 > 0575
            }
            catch { }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            //String contoh = "niamtamami";
            //richTextBoxNotif.AppendText(contoh.Substring(4));
            D = (int)(double.Parse(textBoxD.Text));
            richTextBoxNotif.AppendText("d" + D.ToString("D4") + "\r");
            try
            {
                serialPort.Write("d" + D.ToString("D4") + "\r");    // Ubah format 575 > D4 > 0575
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                richTextBoxNotif.AppendText("manual\n");
                manualPeriodikAcak = 0;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                richTextBoxNotif.AppendText("periodik\n");
                manualPeriodikAcak = 1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                richTextBoxNotif.AppendText("acak");
                manualPeriodikAcak = 2;
            }
        }


    }
}

