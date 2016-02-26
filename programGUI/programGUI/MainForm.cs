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
        byte limaframe=0;
        byte timeSampling=1;
        //tambahkan variable global di sini
        String[] dataUkur1, dataUkur2, dataUkur3, dataUkur4, dataUkur5,dataUkur6,dataUkur7;
        String terima;
        double batasBawah = -35, batasAtas = 200; 
        bool prosesTransmisi, ambilData=true;
        bool recording=false;
        int tickStart, waktuTimer;
        String dataSimpan, pDataSimpan;
        double suhu1,kelembapan1,suhu2,kelembapan2,suhu3,kelembapan3,suhu4,kelembapan4,suhu5,kelembapan5,suhu6,kelembapan6,suhu7,kelembapan7;
        double baterai1, baterai2, baterai3, baterai4, baterai5, baterai6, baterai7;
        System.IO.StreamWriter fileSimpan, periodikFileSimpan;
        

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

            if (menuSuhuKelembapan.Checked)
            {
                myPaneAcc.Title.Text = "Data Rekam Suhu";
            }
            else
            {
                myPaneAcc.Title.Text = "Data Rekam Kelembapan";
            }

            myPaneAcc.XAxis.Title.Text = "Time, Seconds";
            myPaneAcc.YAxis.Title.Text = "Suhu, derajat Celcius";

            LineItem curve1 = myPaneAcc.AddCurve("n1", list1, Color.Blue, SymbolType.None);
            LineItem curve2 = myPaneAcc.AddCurve("n2", list2, Color.Green, SymbolType.None);
            LineItem curve3 = myPaneAcc.AddCurve("n3", list3, Color.Red, SymbolType.None);
            LineItem curve4 = myPaneAcc.AddCurve("n4", list4, Color.Purple, SymbolType.None);
            LineItem curve5 = myPaneAcc.AddCurve("n5", list5, Color.Yellow, SymbolType.None);
            LineItem curve6 = myPaneAcc.AddCurve("n6", list6, Color.Pink, SymbolType.None);
            LineItem curve7 = myPaneAcc.AddCurve("n7", list7, Color.Orange, SymbolType.None);

            curve1.Line.Width = 3.0f;
            curve2.Line.Width = 3.0f;
            curve3.Line.Width = 3.0f;
            curve4.Line.Width = 3.0f;
            curve5.Line.Width = 3.0f;
            curve6.Line.Width = 3.0f;
            curve7.Line.Width = 3.0f;

            myPaneAcc.XAxis.Scale.Min = 0;
            myPaneAcc.XAxis.Scale.MinorStep = 1;
            myPaneAcc.XAxis.Scale.MajorStep = 5;
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
                case 0:
                    return;
                    break;
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

            try
            {
                terima = serialPort.ReadLine();
            }
            catch
            { }
            this.Invoke(new EventHandler(parseData));
        }

        private void parseData(object sender, EventArgs e)
        {
            String[] Data, DataPayload;
            char[] delimiterChars = { '@', '#','\n' };
            
            if (ambilData)
            {
                richTextBox1.AppendText(terima + "\n");
                Data = terima.Split(delimiterChars);
                
                try
                {
                    if (Data.Length == 6)
                    {
                        if (recording)
                        {
                            DataPayload = Data[4].Split('|');
                            dataSimpan = String.Format("{0:T}",DateTime.Now) + "," + Data[1] + "," + Data[2] + "," + Data[3] + "," + Data[4] + "," + DataPayload[0] + "," + DataPayload[1] + "," + DataPayload[2] + "," + Data[5];
                            fileSimpan.WriteLine(dataSimpan);
                        }
                        try
                        {
                            if (Data[1] == "01")
                            {

                                dataUkur1 = Data[4].Split('|');
                                if ((Convert.ToDouble(dataUkur1[0]) < batasAtas) && (Convert.ToDouble(dataUkur1[0]) > batasBawah)) suhu1 = Convert.ToDouble(dataUkur1[0]);
                                if ((Convert.ToDouble(dataUkur1[1]) < batasAtas) && (Convert.ToDouble(dataUkur1[1]) > batasBawah)) kelembapan1 = Convert.ToDouble(dataUkur1[1]);
                                if ((Convert.ToDouble(dataUkur1[2]) < batasAtas) && (Convert.ToDouble(dataUkur1[2]) > batasBawah)) baterai1 = Convert.ToDouble(dataUkur1[2]);
                                //label1.Text = "n1:" + Convert.ToString(suhu1) + "|" + Convert.ToString(kelembapan1) + "|" + Convert.ToString(baterai1);
                                labelBaterai1.Text = "Bat1 = " + Convert.ToString(baterai1);
                            }
                            else if (Data[1] == "02")
                            {

                                dataUkur2 = Data[4].Split('|');
                                if ((Convert.ToDouble(dataUkur2[0]) < batasAtas) && (Convert.ToDouble(dataUkur2[0]) > batasBawah)) suhu2 = Convert.ToDouble(dataUkur2[0]);
                                if ((Convert.ToDouble(dataUkur2[1]) < batasAtas) && (Convert.ToDouble(dataUkur2[1]) > batasBawah)) kelembapan2 = Convert.ToDouble(dataUkur2[1]);
                                if ((Convert.ToDouble(dataUkur2[2]) < batasAtas) && (Convert.ToDouble(dataUkur2[2]) > batasBawah)) baterai2 = Convert.ToDouble(dataUkur2[2]);
                                //label2.Text = "n2:" + Convert.ToString(suhu2) + "|" + Convert.ToString(kelembapan2) + "|" + Convert.ToString(baterai2);
                                labelBaterai2.Text = "Bat2 = " + Convert.ToString(baterai2);
                            }
                            else if (Data[1] == "03")
                            {

                                dataUkur3 = Data[4].Split('|');
                                if ((Convert.ToDouble(dataUkur3[0]) < batasAtas) && (Convert.ToDouble(dataUkur3[0]) > batasBawah)) suhu3 = Convert.ToDouble(dataUkur3[0]);
                                if ((Convert.ToDouble(dataUkur3[1]) < batasAtas) && (Convert.ToDouble(dataUkur3[1]) > batasBawah)) kelembapan3 = Convert.ToDouble(dataUkur3[1]);
                                if ((Convert.ToDouble(dataUkur3[2]) < batasAtas) && (Convert.ToDouble(dataUkur3[2]) > batasBawah)) baterai3 = Convert.ToDouble(dataUkur3[2]);
                                //label3.Text = "n3:" + Convert.ToString(suhu3) + "|" + Convert.ToString(kelembapan3) + "|" + Convert.ToString(baterai3);
                                labelBaterai3.Text = "Bat3 = " + Convert.ToString(baterai3);
                            }
                            else if (Data[1] == "04")
                            {

                                dataUkur4 = Data[4].Split('|');
                                if ((Convert.ToDouble(dataUkur4[0]) < batasAtas) && (Convert.ToDouble(dataUkur4[0]) > batasBawah)) suhu4 = Convert.ToDouble(dataUkur4[0]);
                                if ((Convert.ToDouble(dataUkur4[1]) < batasAtas) && (Convert.ToDouble(dataUkur4[1]) > batasBawah)) kelembapan4 = Convert.ToDouble(dataUkur4[1]);
                                if ((Convert.ToDouble(dataUkur4[2]) < batasAtas) && (Convert.ToDouble(dataUkur4[2]) > batasBawah)) baterai4 = Convert.ToDouble(dataUkur4[2]);
                                //label4.Text = "n4:" + Convert.ToString(suhu4) + "|" + Convert.ToString(kelembapan4) + "|" + Convert.ToString(baterai4);
                                labelBaterai4.Text = "Bat4 = " + Convert.ToString(baterai4);
                            }
                            else if (Data[1] == "05")
                            {

                                dataUkur5 = Data[4].Split('|');
                                if ((Convert.ToDouble(dataUkur5[0]) < batasAtas) && (Convert.ToDouble(dataUkur5[0]) > batasBawah)) suhu5 = Convert.ToDouble(dataUkur5[0]);
                                if ((Convert.ToDouble(dataUkur5[1]) < batasAtas) && (Convert.ToDouble(dataUkur5[1]) > batasBawah)) kelembapan5 = Convert.ToDouble(dataUkur5[1]);
                                if ((Convert.ToDouble(dataUkur5[2]) < batasAtas) && (Convert.ToDouble(dataUkur5[2]) > batasBawah)) baterai5 = Convert.ToDouble(dataUkur5[2]);
                                //label5.Text = "n5:" + Convert.ToString(suhu5) + "|" + Convert.ToString(kelembapan5) + "|" + Convert.ToString(baterai5);
                                labelBaterai5.Text = "Bat5 = " + Convert.ToString(baterai5);
                            }
                            else if (Data[1] == "06")
                            {

                                dataUkur6 = Data[4].Split('|');
                                if ((Convert.ToDouble(dataUkur6[0]) < batasAtas) && (Convert.ToDouble(dataUkur6[0]) > batasBawah)) suhu6 = Convert.ToDouble(dataUkur6[0]);
                                if ((Convert.ToDouble(dataUkur6[1]) < batasAtas) && (Convert.ToDouble(dataUkur6[1]) > batasBawah)) kelembapan6 = Convert.ToDouble(dataUkur6[1]);
                                if ((Convert.ToDouble(dataUkur6[2]) < batasAtas) && (Convert.ToDouble(dataUkur6[2]) > batasBawah)) baterai6 = Convert.ToDouble(dataUkur6[2]);
                                //label6.Text = "n6:" + Convert.ToString(suhu6) + "|" + Convert.ToString(kelembapan6) + "|" + Convert.ToString(baterai6);
                                labelBaterai6.Text = "Bat6 = " + Convert.ToString(baterai6);
                            }
                            else if (Data[1] == "07")
                            {

                                dataUkur7 = Data[4].Split('|');
                                if ((Convert.ToDouble(dataUkur7[0]) < batasAtas) && (Convert.ToDouble(dataUkur7[0]) > batasBawah)) suhu7 = Convert.ToDouble(dataUkur7[0]);
                                if ((Convert.ToDouble(dataUkur7[1]) < batasAtas) && (Convert.ToDouble(dataUkur7[1]) > batasBawah)) kelembapan7 = Convert.ToDouble(dataUkur7[1]);
                                if ((Convert.ToDouble(dataUkur7[2]) < batasAtas) && (Convert.ToDouble(dataUkur7[2]) > batasBawah)) baterai7 = Convert.ToDouble(dataUkur7[2]);
                                //label7.Text = "n7:" + Convert.ToString(suhu7) + "|" + Convert.ToString(kelembapan7) + "|" + Convert.ToString(baterai7);
                                labelBaterai7.Text = "Bat7 = " + Convert.ToString(baterai7);
                            }
                            else { }

                            
                            label2.Text = "| " + Convert.ToString(suhu1) + " | " + Convert.ToString(suhu2) + " | " + Convert.ToString(suhu3) + " | " + Convert.ToString(suhu4) + " | " + Convert.ToString(suhu5) + " |";
                            label3.Text = "| " + Convert.ToString(kelembapan1) + " | " + Convert.ToString(kelembapan2) + " | " + Convert.ToString(kelembapan3) + " | " + Convert.ToString(kelembapan4) + " | " + Convert.ToString(kelembapan5) + " |";
                            label4.Text = "| " + Convert.ToString(baterai1) + " | " + Convert.ToString(baterai2) + " | " + Convert.ToString(baterai3) + " | " + Convert.ToString(baterai4) + " | " + Convert.ToString(baterai5) + " |";

                        }
                        catch { }
                    }
                    else
                    {

                    }
                }
                catch { }

                ambilData = true;

            }     
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
                MessageBox.Show("tidak dapat dieksekusi, sepertinya PORT bermasalah", "WSN UI");
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = textBoxPort.Text;
                serialPort.BaudRate = int.Parse(textBoxBaud.Text);
                serialPort.Open();
                timerLoop.Start();
                MessageBox.Show("PORT telah sukses dibuka", "WSN UI");
            }
            catch
            {
                MessageBox.Show("Sepertinya PORT yang anda gunakan bermasalah, coba cek PORT di device manager","WSN UI");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                timerLoop.Stop();
                MessageBox.Show("PORT telah sukses ditutup","WSN UI");
            }
            catch
            {
                MessageBox.Show("gagal menutup PORT", "WSN UI");
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
            }
        }
        private void timerLoop_Tick(object sender, EventArgs e)
        {
            timeSampling++;
            if (timeSampling > 101) timeSampling = 1;
            switch (comboBox1.SelectedIndex)
            { 
                case 0:
                    ambilData = true;
                    periodikSimpan();
                    break;
                case 1:
                    if ((timeSampling % 20) == 0)
                    {
                        ambilData = true;
                        Console.WriteLine("duadetik");
                        periodikSimpan();
                    }
                    break;
                case 2:
                    if ((timeSampling % 50) == 0)
                    {
                        ambilData = true;
                        Console.WriteLine("limadetik");
                        periodikSimpan();
                    }
                    break;
                case 3:
                    if ((timeSampling % 100) == 0)
                    {
                        ambilData = true;
                        Console.WriteLine("sepuluhdetik");
                        periodikSimpan();
                    }
                    break;

            }
            if (menuSuhuKelembapan.Checked)
            {
                
                try {setKurvaGrafik(1, suhu1); } catch { }
                try {setKurvaGrafik(2, suhu2); } catch { }
                try {setKurvaGrafik(3, suhu3); } catch { }
                try {setKurvaGrafik(4, suhu4);} catch { }
                try {setKurvaGrafik(5, suhu5);} catch { }
                try {setKurvaGrafik(6, suhu6);} catch { }
                try {setKurvaGrafik(7, suhu7);} catch { }
            }
            else
            {
                
                try {setKurvaGrafik(1, kelembapan1);} catch { }
                try {setKurvaGrafik(2, kelembapan2);} catch { }
                try {setKurvaGrafik(3, kelembapan3);} catch { }
                try {setKurvaGrafik(4, kelembapan4);} catch { }
                try {setKurvaGrafik(5, kelembapan5);} catch { }
                try {setKurvaGrafik(6, kelembapan6);} catch { }
                try {setKurvaGrafik(7, kelembapan7);} catch { }
            }
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
                    MessageBox.Show("PORT telah sukses ditutup", "WSN UI");
                    
                }
                catch
                {
                    MessageBox.Show("gagal menutup PORT", "WSN UI");
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
                MainForm.ActiveForm.Text = "Wireless Sensor Network UI | Recording";            
            }
            catch 
            {
                MessageBox.Show("Sepertinya penyimpanan data bermasalah, tutup dahulu data csv yang anda buka", "WSN UI");
            }
            
        }
        private void stopRekam()
        {
            recording = false;
            fileSimpan.Close();
            periodikFileSimpan.Close();
            MainForm.ActiveForm.Text = "Wireless Sensor Network UI";  
        }

        private void catat(String dataText)
        {
            richTextBoxNotif.AppendText(dataText);
            MessageBox.Show(dataText, "WSN UI");
        }

        private void menuSuhuKelembapan_CheckedChanged(object sender, EventArgs e)
        {
            if (menuSuhuKelembapan.Checked)
            {
                GraphPane myPaneAcc = zedGraphControl.GraphPane;
                myPaneAcc.Title.FontSpec.Size = 20.0f;
                myPaneAcc.Title.Text = "Data Rekam Suhu";
                myPaneAcc.YAxis.Title.Text = "Suhu (derajat Celcius)";
            }
            else
            {
                GraphPane myPaneAcc = zedGraphControl.GraphPane;
                myPaneAcc.Title.FontSpec.Size = 20.0f;
                myPaneAcc.Title.Text = "Data Rekam Kelembapan";
                myPaneAcc.YAxis.Title.Text = "Kelembapan (%)";
            }
        }


        private void buttonPersen_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("%");
            }
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
            if (serialPort.IsOpen)
            {
                serialPort.Write("$");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }


    }
}

