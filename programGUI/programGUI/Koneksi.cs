using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace programGUI
{
    public partial class Koneksi : Form
    {
        
        public Koneksi()
        {
            
            InitializeComponent();
        }

        private void Koneksi_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        /*
            public void sendPacket(object indata)
                {
                    bool validPacket = false;
                    byte a = 0;
                    foreach (Type ty in MAVLINK_MESSAGE_INFO)
                    {
                        if (ty == indata.GetType())
                        {
                            validPacket = true;
                            generatePacket(a, indata);
                            return;
                        }
                        a++;
                    }
                    if (!validPacket)
                    {
                        log.Info("Mavlink : NOT VALID PACKET sendPacket() " + indata.GetType().ToString());
                    }
                }

                /// <summary>
                /// Generate a Mavlink Packet and write to serial
                /// </summary>
                /// <param name="messageType">type number</param>
                /// <param name="indata">struct of data</param>
                void generatePacket(byte messageType, object indata)
                {
                    lock (objlock)
                    {
                        byte[] data;

                        if (mavlinkversion == 3)
                        {
                            data = MavlinkUtil.StructureToByteArray(indata);
                        }
                        else
                        {
                            data = MavlinkUtil.StructureToByteArrayBigEndian(indata);
                        }

                        //Console.WriteLine(DateTime.Now + " PC Doing req "+ messageType + " " + this.BytesToRead);
                        byte[] packet = new byte[data.Length + 6 + 2];

                        if (mavlinkversion == 3)
                        {
                            packet[0] = 254;
                        }
                        else if (mavlinkversion == 2)
                        {
                            packet[0] = (byte)'U';
                        }
                        packet[1] = (byte)data.Length;
                        packet[2] = (byte)packetcount;

                        packetcount++;

                        packet[3] = 255; // this is always 255 - MYGCS
                        packet[4] = (byte)MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER;
                        packet[5] = messageType;

                        int i = 6;
                        foreach (byte b in data)
                        {
                            packet[i] = b;
                            i++;
                        }

                        ushort checksum = MavlinkCRC.crc_calculate(packet, packet[1] + 6);

                        if (mavlinkversion == 3)
                        {
                            checksum = MavlinkCRC.crc_accumulate(MAVLINK_MESSAGE_CRCS[messageType], checksum);
                        }

                        byte ck_a = (byte)(checksum & 0xFF); ///< High byte
                        byte ck_b = (byte)(checksum >> 8); ///< Low byte

                        packet[i] = ck_a;
                        i += 1;
                        packet[i] = ck_b;
                        i += 1;

                        if (BaseStream.IsOpen)
                        {
                            BaseStream.Write(packet, 0, i);
                            _bytesSentSubj.OnNext(i);
                        }

                        try
                        {
                            if (logfile != null && logfile.BaseStream.CanWrite)
                            {
                                lock (logfile)
                                {
                                    byte[] datearray = BitConverter.GetBytes((UInt64)((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds * 1000));
                                    Array.Reverse(datearray);
                                    logfile.Write(datearray, 0, datearray.Length);
                                    logfile.Write(packet, 0, i);
                                }
                            }

                        }
                        catch { }
                        /*
                        if (messageType == ArdupilotMega.MAVLink.MAVLINK_MSG_ID_REQUEST_DATA_STREAM)
                        {
                            try
                            {
                                BinaryWriter bw = new BinaryWriter(File.OpenWrite("serialsent.raw"));
                                bw.Seek(0, SeekOrigin.End);
                                bw.Write(packet, 0, i);
                                bw.Write((byte)'\n');
                                bw.Close();
                            }
                            catch { } // been getting errors from this. people must have it open twice.
                        }
                    }
            */
    }

}
