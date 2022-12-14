using System;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UpdateFRAMBlocks
{
    public partial class Form1 : Form
    {
        int ONEBYTE = 1;
        int TWOBYTE = 2;

        bool isC2EPR = true;
        int verifyBoardNumer = 32;  // Enter the board number // Discontinued
        int verifySomBoardNumer = 28; // Enter the som board number  // Discontinued

        //Yog 
        //For C2 and C2 EPR update the respective board serial numbers         
        //Enter the C2 EPR | C2 number to display and compare before update
        string ControllerNumber = "240.257.240.168.310.";

        //file location 
        string folderLocation = @"C:\GRL\GRL-Controller-CalibrationData\Reports";

        DecodeFRAM mDecodeFRAM = new DecodeFRAM();
        string strboardno = "";
        GrlEthernetLink_C2 m_initlink = null;
        public Form1()
        {
            InitializeComponent();
            m_initlink = new GrlEthernetLink_C2();
            m_initlink.InitilizePort();
            GetControllerType();
            SetStreamerBufferSize(STREAMER_BUFFER_SIZE.DMA_Mem_Size62k);
            strboardno = GetControllerSerialNo();
            strversionno.Text = strboardno;
            if (isC2EPR)
                label2.Text = "SN of GRL-USB-PD-C2 EPR :";
            else
                label2.Text = "SN of GRL-USB-PD-C2 :";
        }

        public enum STREAMER_BUFFER_SIZE
        {
            DMA_Mem_Size1k = 1,
            DMA_Mem_Size8k = 8,
            DMA_Mem_Size16k = 16,
            DMA_Mem_Size32k = 32,
            DMA_Mem_Size62k = 62,
        }

        /// <summary>
        /// Method to set the streamer buffer size 
        /// </summary>
        /// <param name="bufferSize"></param>
        /// <returns></returns>
        public bool SetStreamerBufferSize(STREAMER_BUFFER_SIZE bufferSize)
        {
            bool retValue = false;
            try
            {
                byte[] dataBuffer = new byte[] { 0 };
                byte regCode = 0xD5, addr = 0;

                //var ethBufferSize = FWAppObj.FWHost.PropertyBag.GetPropertyValue(PropertyItem.ETHERNET_BUFFER_SIZE);

                if ((int)bufferSize == 62)
                {
                    dataBuffer = new byte[] { 0xFE, 0x01, 0x00, 0x05, 0x05 };
                    m_initlink.m_databuffersize = 62 * 1024;

                }
                else if ((int)bufferSize == 32)
                {
                    dataBuffer = new byte[] { 0xFE, 0x01, 0x00, 0x05, 0x04 };
                    m_initlink.m_databuffersize = 32 * 1024;

                }
                else if ((int)bufferSize == 16)
                {
                    dataBuffer = new byte[] { 0xFE, 0x01, 0x00, 0x05, 0x03 };
                    m_initlink.m_databuffersize = 16 * 1024;

                }
                else if ((int)bufferSize == 8)
                {
                    dataBuffer = new byte[] { 0xFE, 0x01, 0x00, 0x05, 0x01 };
                    m_initlink.m_databuffersize = 8 * 1024;

                }
                else if ((int)bufferSize == 1)
                {
                    dataBuffer = new byte[] { 0xFE, 0x01, 0x00, 0x05, 0x00 };
                    m_initlink.m_databuffersize = 1024;
                }
                else
                {
                    //FWAppObj.FWHost.WriteToDebugLogger(DebugModeType.DEBUG, $"Invalid buffer size configured in the property file = {ethBufferSize}");
                }


                retValue = m_initlink.Write(dataBuffer);//Write(regCode, addr, dataBuffer, dataBuffer.Length, "Setting Controller Configuaton :" + ethBufferSize.ToString() + "K");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1);
                }
            }
            catch (Exception ex)
            {
                retValue = false;
                //m_DebugLog.WriteToDebugLogger(DebugType.STATUS, "GrlUsbPdControllerLib : PD_Controller -> SetControllerConfiguration()" + ex);
            }
            return retValue;
        }

        /// <summary>
        /// Method to get the controller serial number 
        /// </summary>
        /// <returns></returns>
        public string GetControllerSerialNo()
        {
            string str = "";
            try
            {
                //update for which controller unit - to display in UI
                lblSerialNo.Text = "0" + verifyBoardNumer.ToString() + ".0" + verifySomBoardNumer.ToString() + ".XXX.XXX.XXX";
                if (true)
                {
                    lblSerialNo.Text = ControllerNumber;
                }

                //Get the controller serial number
                byte[] byte1 = new byte[] { 0xFc, 0x00, 0xE1, 0x08 };
                bool status = m_initlink.Read(ref byte1);
                bool IscalibrationDataAvail = false;
                for (int i = 0; i < byte1.Length; i++)
                {
                    if ((byte1[i] != 0) && (status))
                    {
                        str += Convert.ToChar(byte1[i]).ToString();
                        if ((byte1[i] != 0x30) && (byte1[i] != 0x2E))
                            IscalibrationDataAvail = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return str;
        }

        /// <summary>
        /// Method to get the Controller Type - C2/C2EPR
        /// </summary>
        public void GetControllerType()
        {
            try
            {
                byte[] byte1 = new byte[] { 0xFC, 0x00, 0xE1, 0xD5 };
                m_initlink.Read(ref byte1);
                if (byte1[0] == 0x01)
                {
                    //AppType.C2;
                    isC2EPR = false;
                }
                else if (byte1[0] == 0x02)
                {
                    //AppType.C2Gen2;
                    isC2EPR = true;
                }
                else
                {
                    // handle the error case :: 
                    isC2EPR = false;
                }
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Method to establish the connection with controller once the FRAM write is success
        /// </summary>
        private void Reconnection()
        {
            Thread.Sleep(2000);
            m_initlink.InitilizePort();
            GetControllerType();
            string boardNum = GetControllerSerialNo();
            if (boardNum != "")
            {
                mDecodeFRAM.Read(isC2EPR);
            }
            else
            {
                MessageBox.Show("Check the Controller connection and click ok");
                Reconnection();
            }
        }

        /// <summary>
        /// Method to write the binary file to hold the raw data which used before read and after write 
        /// </summary>
        private void FileReadWrite()
        {
            try
            {
                if (!Directory.Exists(folderLocation))
                {
                    Directory.CreateDirectory(folderLocation);
                }
                string date = DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "_");
                string fileName = $"LoggerData_{date}.bin";
                string actualPath = folderLocation + $"\\{fileName}";

                using (var stream = File.Open(actualPath, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        writer.Write("Write" + mDecodeFRAM.strWriteData);
                        writer.Write("Read" + mDecodeFRAM.strReadData);
                        stream.Close();
                    }
                }

                if (false)
                {
                    //read the data ::
                    string readStr1;
                    string readStr2;
                    using (var stream = File.Open(actualPath, FileMode.Open))
                    {
                        using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                        {
                            readStr1 = reader.ReadString();
                            readStr2 = reader.ReadString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        public bool Reset_Controller()
        {
            bool retValue = false;
            try
            {
                byte[] dataBuffer = new byte[] { 0xFD, 0xFF };
                m_initlink.Write(dataBuffer);
            }
            catch (Exception ex)
            {
            }
            return retValue;
        }
        private void btnLic_Click(object sender, EventArgs e)
        {
            try
            {
                //Yog 
                //Check the controller number is expected ::
                //If the controller number defined in exe and the connected one is mismatch - throw a message box
                if (strboardno != ControllerNumber)
                {
                    MessageBox.Show("Serial number mismatch");
                    return;
                }

                bool retval = mDecodeFRAM.DecodeFramXL(FRAMData.m_Framdata, isC2EPR);
                if (retval)
                {
                    MessageBox.Show("Updated Successfully");
                    MessageBox.Show("Press the Power Cycle button in controller \n Click Ok once the controller is restarted");
                    //MessageBox.Show("Power cycle the controller");

                    Reconnection();
                }
                else
                    MessageBox.Show("UnSuccessfully");

                //write the data into the file 
                FileReadWrite();
            }
            catch (Exception ex)
            {

            }
        }
        public void writeLicense(uint address, uint uiLicense, int Noofbytes, int param = 0, string strval = "")
        {
            try
            {
                //byte 4 and byte 5 address, byte6 and byte7 values, same byte8 and byte9
                //byte3 is NO of bytes to write bytes+2 i.e for 4 bytes 4+2

                byte[] dataBuffer = new byte[1024];
                dataBuffer[0] = 0x6B;
                dataBuffer[1] = 0x01;
                dataBuffer[2] = 0x50;
                dataBuffer[3] = 0x06;
                dataBuffer[4] = (byte)((address >> 8) & 0xFF);
                dataBuffer[5] = (byte)(address & 0xFF);
                if (param == 1)
                {
                    dataBuffer[3] = (byte)(Noofbytes + 2);
                    byte[] data = Encoding.UTF8.GetBytes(strval);
                    byte[] dataTemp = new byte[Noofbytes];
                    for (int i = 0; i < data.Length; i++)
                        dataTemp[i] = data[i];

                    // Just to make sure rest of the byte will be replcaed with 0
                    for (int p = 0; p < dataTemp.Length; p++)
                        dataBuffer[p + 6] = dataTemp[p];
                }
                else
                {
                    if (Noofbytes == 2)
                    {
                        dataBuffer[3] = (byte)(Noofbytes + 2);
                        dataBuffer[6] = (byte)((uiLicense) & 0xFF);
                        dataBuffer[7] = (byte)((uiLicense >> 8) & 0xFF);
                        dataBuffer[8] = (byte)((uiLicense) & 0xFF);
                        dataBuffer[9] = (byte)((uiLicense >> 8) & 0xFF);
                    }
                    if (Noofbytes == 1)
                    {
                        dataBuffer[3] = (byte)(Noofbytes + 2);
                        dataBuffer[6] = (byte)(uiLicense & 0xFF);
                        dataBuffer[7] = (byte)(uiLicense & 0xFF);
                    }
                }

                m_initlink.Write(dataBuffer);
                Thread.Sleep(10);
            }
            catch (Exception ex)
            {
            }
        }
        private void strversionno_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
