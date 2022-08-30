using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;

namespace UpdateFRAMBlocks
{
    public enum FRAM_ID
    {
        ID,
        CHECK,
        LENGTH,
        BLOCK_START,
        BLOCK_ID,
        FRAM_REV,
        SYSTEM_SERIAL_NUMBER,
        IDN,
        DILIMTER,
        SOM_BOARD_NUMBER,
        SOM_BOARD_REV,
        BASE_BOARD_NUMBER,
        BASE_BOARD_REV,
        ELOAD_NUMBER,
        ELOAD_REV,
        LICENSE,
        Usage,
        Manufacturing_month,
        Manufacturing_year,
        Location_of_Manufacturing,
        Calibration_Date,
        Calibration_Month,
        Calibration_Year,
        Next_Calibration_Date,
        Next_Calibration_Month,
        Next_Calibration_Year,
        CURRENT1,
        CURRENT2,
        CURRENT3,
        CURRENT4,
        CURRENT5,
        ADC_COUNT,
        VOLTAGE1,
        VOLTAGE2,
        VOLTAGE3,
        VOLTAGE4,
        VOLTAGE5,
        ADC_UNIT,
        ADC_BANK,
        ADC_NO,
        ELOAD_NO,
        UNIT,
        DAC_COUNT,
        PPS_NO,
        DAC_Unit,
        GROUP1_DAC,
        GROUP2_DAC,
        GROUP3_DAC,
        GEN1_NOISE_PK_PK,
        BISTRISE_TIME,
        BIST_PK_PK_GRP1,
        BIST_PK_PK_GRP2_3,
        BUSIDLE_DAC,
        BUSIDLE_NOISE_PK_PK,
        GEN2_5M_PK_PK,
        GEN2_750K_PK_PK,
        TEMP_LICENSE,
        License_Start_Date,
        License_Start_Month,
        License_Start_Year,
        License_End_Date,
        License_End_Month,
        License_End_Year,
        License_LastRun_Date,
        License_LastRun_Month,
        License_LastRun_Year,
        Base_Board_Rework1,
        Base_Board_Rework2,
        Base_Board_Rework3,
        Base_Board_Rework4,
        SOM_Board_Rework1,
        SOM_Board_Rework2,
        Eload_Board_Rework1,
        Eload_Board_Rework2,
        Noise_Board_Rework1,
        Noise_Board_Rework2,
        Cable1_VBUS_IR_Drop_Resistance,
        Cable1_PA_CC2_IR_Drop_Resistance,
        Cable1_PA_CC1_IR_Drop_Resistance,
        Cable2_PB_VBUS_IR_Drop_Resistance,
        Cable2_PB_CC2_IR_Drop_Resistance,
        Cable2_PB_CC1_IR_Drop_Resistance,
        RDCP_DAT_RES_COMPENSATION,
        RDCP_DAT_LOWER_RESISTANCE,
        RDCP_DAT_UPPER_RESISTANCE,
        RDM_DWN_RES_COMPENSATION,
        RDM_DWN_LOWER_RESISTANCE,
        RDM_DWN_UPPER_RESISTANCE,
        RDAT_LKG_RES_COMPENSATION,
        RDAT_LKG_LOWER_RESISTANCE,
        RDAT_LKG_UPPER_RESISTANCE,
        RDAT_LKG_MIDDLE_RESISTANCE,
        ETHERNET_SETTINGS,
        TOTAL_COUNT,
        TOTAL_VALID_COUNT,
        ETHERNET_ADDRESS,
        PAGE_NO,
        REG_ADD,
        REG_DATA,
        Reserved,
        NONE,
    }
    public enum FRAM_Blocks
    {
        FRAM_Block_0,
        FRAM_Block_1,
        FRAM_Block_2,
        FRAM_Block_3,
        FRAM_Block_4,
        FRAM_Block_5,
        FRAM_Block_6,
        FRAM_Block_7,
        FRAM_Block_8,
        FRAM_Block_9,
        FRAM_Block_10,
        FRAM_Block_11,
        FRAM_Block_12,
        FRAM_Block_13,
        FRAM_Block_14,
        FRAM_Block_15,
        FRAM_Block_16,
        NONE,
    }

    class DecodeFRAM
    {
        private List<FRAMBlocks> FramBlockDataLst = null;
        private List<FRAM_Data> FramdataLst = null;
        private GrlEthernetLink_C2 m_grlEthernetLink_C2 = null;
        public string strWriteData;        
        public string strReadData;
        public DecodeFRAM()
        {
            FramdataLst = new List<FRAM_Data>();
            FramBlockDataLst = new List<FRAMBlocks>();
            m_grlEthernetLink_C2 = new GrlEthernetLink_C2();
            strWriteData = "";
            strReadData = "";
        }
        private uint getOffset(int frmablock)
        {
            uint noofbytes = 0;
            try
            {

                int nobytes = 0;
                if (frmablock > 0)
                {
                    for (int i = 1; i <= frmablock; i++)
                    {
                        nobytes += GetBlockNofbytes(GetBlockNo(i - 1));

                    }
                    noofbytes = (uint)(nobytes);
                }
            }
            catch (Exception ex)
            {
            }
            return noofbytes;
        }
        private int GetBlockNofbytes(FRAM_Blocks frmablock)
        {
            int noofbytes = 0;
            try
            {
                for (int i = 0; i < FramdataLst.Count; i++)
                    if (FramdataLst[i].frBlock == frmablock)
                        noofbytes += FramdataLst[i].iNo_of_bytes;
            }
            catch (Exception ex)
            {

            }
            return noofbytes;
        }
        private FRAM_Blocks GetBlockNo(int blckNo)
        {
            FRAM_Blocks frmblk = FRAM_Blocks.NONE;
            try
            {
                if (blckNo == 0)
                    frmblk = FRAM_Blocks.FRAM_Block_0;

                if (blckNo == 1)
                    frmblk = FRAM_Blocks.FRAM_Block_1;

                if (blckNo == 2)
                    frmblk = FRAM_Blocks.FRAM_Block_2;

                if (blckNo == 3)
                    frmblk = FRAM_Blocks.FRAM_Block_3;

                if (blckNo == 4)
                    frmblk = FRAM_Blocks.FRAM_Block_4;

                if (blckNo == 5)
                    frmblk = FRAM_Blocks.FRAM_Block_5;

                if (blckNo == 6)
                    frmblk = FRAM_Blocks.FRAM_Block_6;

                if (blckNo == 7)
                    frmblk = FRAM_Blocks.FRAM_Block_7;

                if (blckNo == 8)
                    frmblk = FRAM_Blocks.FRAM_Block_8;

                if (blckNo == 9)
                    frmblk = FRAM_Blocks.FRAM_Block_9;

                if (blckNo == 10)
                    frmblk = FRAM_Blocks.FRAM_Block_10;

                if (blckNo == 11)
                    frmblk = FRAM_Blocks.FRAM_Block_11;

                if (blckNo == 12)
                    frmblk = FRAM_Blocks.FRAM_Block_12;

                if (blckNo == 13)
                    frmblk = FRAM_Blocks.FRAM_Block_13;

                if (blckNo == 14)
                    frmblk = FRAM_Blocks.FRAM_Block_14;

                if (blckNo == 15)
                    frmblk = FRAM_Blocks.FRAM_Block_15;

                if (blckNo == 16)
                    frmblk = FRAM_Blocks.FRAM_Block_16;

            }
            catch (Exception ex)
            {

            }
            return frmblk;
        }
        private int DecodeFRAMInput(string strFileName, bool isC2EPR)
        {
            int tBytes = 0;
            List<byte> bytes = new List<byte>();
            try
            {
                string[] m_FRAMValues = strFileName.Split('|');
                FRAM_Data itempdata = null;
                int blockNo = 0;
                bool block_zero = true;

                for (int icount = 0; icount < m_FRAMValues.Length; icount++)
                {
                    string[] strtemp = m_FRAMValues[icount].Split(',');
                    if (strtemp.Length < 5)
                        continue;
                    FRAM_ID itempID = FRAM_ID.NONE;
                    Enum.TryParse(strtemp[0], out itempID);
                    if (itempID == FRAM_ID.BLOCK_START)
                    {
                        if (block_zero == false)
                            blockNo++;
                        else
                            block_zero = false;
                    }
                    uint utempoffset = Convert.ToUInt32(strtemp[1], 16);
                    int nobytes = Convert.ToInt32(strtemp[2], 10);
                    tBytes += nobytes;
                    string strval = strtemp[3];
                    byte[] databuf = new byte[nobytes];
                    int paramtype = Convert.ToInt32(strtemp[5], 10);
                    if (paramtype == 1)
                    {
                        byte[] data = Encoding.UTF8.GetBytes(strval);
                        for (int p = 0; p < data.Length; p++)
                            databuf[p] = data[p];
                    }
                    else
                    {
                        if (strval == "")
                            strval = "0";
                        if (strval == "0A0A")
                        {
                            uint itempda = Convert.ToUInt32(strval, 16);
                            if (nobytes > 0)
                                databuf[0] = (byte)(itempda & 0xFF);
                            if (nobytes > 1)
                                databuf[1] = (byte)((itempda >> 8) & 0xFF);
                        }
                        else
                        {
                            uint itempda = Convert.ToUInt32(strval, 10);
                            if (nobytes > 0)
                                databuf[0] = (byte)(itempda & 0xFF);
                            itempda = itempda >> 8;
                            if (nobytes > 1)
                                databuf[1] = (byte)(itempda & 0xFF);

                        }

                    }
                    itempdata = new FRAM_Data(itempID, utempoffset, nobytes, strval, databuf);

                    for (int i = 0; i < databuf.Length; i++)
                        bytes.Add(databuf[i]);

                    int iblkbytes = 0;
                    itempdata.frBlock = GetBlockNo(blockNo);
                    itempdata.uiBlockNo_of_Bytes = iblkbytes;
                    itempdata.Desc = strtemp[4];
                    FramdataLst.Add(itempdata);
                }
                FramBlockDataLst.Clear();
                FRAMBlocks dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_0, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_0), 0);
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_1, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_1), getOffset(1));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_2, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_2), getOffset(2));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_3, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_3), getOffset(3));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_4, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_4), getOffset(4));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_5, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_5), getOffset(5));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_6, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_6), getOffset(6));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_7, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_7), getOffset(7));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_8, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_8), getOffset(8));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_9, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_9), getOffset(9));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_10, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_10), getOffset(10));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_11, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_11), getOffset(11));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_12, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_12), getOffset(12));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_13, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_13), getOffset(13));
                FramBlockDataLst.Add(dtablk);
                dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_14, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_14), getOffset(14));
                FramBlockDataLst.Add(dtablk);
                //C2 EPR 14 blocks 
                if (isC2EPR)
                {
                    dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_15, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_15), getOffset(15));
                    FramBlockDataLst.Add(dtablk);
                    dtablk = new FRAMBlocks(FRAM_Blocks.FRAM_Block_16, GetBlockNofbytes(FRAM_Blocks.FRAM_Block_16), getOffset(16));
                    FramBlockDataLst.Add(dtablk);
                }
                for (int i = 0; i < FramBlockDataLst.Count; i++)
                {
                    for (int q = 0; q < FramdataLst.Count; q++)
                    {
                        if (FramBlockDataLst[i].frBlock == FramdataLst[q].frBlock)
                        {
                            FramBlockDataLst[i].framdata.Add(FramdataLst[q]);
                        }
                    }
                }

                //debug 

                if (true)
                {
                    byte[] data = bytes.ToArray();
                    var strData = ConvertBytesToString(bytes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FRAM Write Failed : Please check the .XLS file");
            }
            return tBytes;
        }
        public async Task<string> ConvertBytesToString(List<byte> bufData, int printLength = -1)
        {
            string strFinalData = string.Empty;
            try
            {
                if (printLength <= 0)
                    printLength = bufData.Count;
                if (printLength > bufData.Count)
                    printLength = bufData.Count;
                List<byte> tempBuf = new List<byte>();
                if (printLength < bufData.Count)
                {
                    tempBuf = new List<byte>(bufData.GetRange(0, printLength));
                }
                else
                {
                    tempBuf.AddRange(bufData);
                }
                if (tempBuf.Count > 10000)
                {
                    int singleBufCnt = tempBuf.Count / 4;

                    List<byte> bufOne = tempBuf.GetRange(0, singleBufCnt);
                    tempBuf.RemoveRange(0, singleBufCnt);
                    var task1 = Task.Run(() =>
                    {
                        return ByteToStringInHexFormat(bufOne);
                    });

                    List<byte> bufTwo = tempBuf.GetRange(0, singleBufCnt);
                    tempBuf.RemoveRange(0, singleBufCnt);
                    var task2 = Task.Run(() =>
                    {
                        return ByteToStringInHexFormat(bufTwo);
                    });

                    List<byte> bufThree = tempBuf.GetRange(0, singleBufCnt);
                    tempBuf.RemoveRange(0, singleBufCnt);
                    var task3 = Task.Run(() =>
                    {
                        return ByteToStringInHexFormat(bufThree);
                    });

                    List<byte> bufFour = tempBuf.GetRange(0, tempBuf.Count);
                    tempBuf.Clear();
                    var task4 = Task.Run(() =>
                    {
                        return ByteToStringInHexFormat(bufFour);
                    });

                    var task1Awaiter = task1.GetAwaiter();
                    string strDataOne = task1Awaiter.GetResult();
                    var task2Awaiter = task2.GetAwaiter();
                    string strDataTwo = task2Awaiter.GetResult();
                    var task3Awaiter = task3.GetAwaiter();
                    string strDataThree = task3Awaiter.GetResult();
                    var task4Awaiter = task4.GetAwaiter();
                    string strDataFour = task4Awaiter.GetResult();
                    strFinalData = strDataOne + strDataTwo + strDataThree + strDataFour;
                }
                else
                {
                    strFinalData = await ByteToStringInHexFormat(tempBuf);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Write Error!");
            }
            return strFinalData;
        }
        private async Task<string> ByteToStringInHexFormat(List<byte> data)
        {
            string strData = string.Empty;
            try
            {
                for (int p = 0; p < data.Count; p++)
                {
                    strData += data[p].ToString("X").ToUpper().PadLeft(2, '0') + ",";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Write Error!!");
            }
            return strData;
        }
        private bool BaseBoardWriteAPI(List<byte> data, uint startAddress, uint length, bool isC2EPR)
        {
            byte offsetLSB = (byte)(startAddress & 0xFF);
            byte offsetMSB = (byte)((startAddress >> 8) & 0xFF);
            bool retValue;
            // for C2 
            byte slaveAddress = 0x50;
            // for c2EPR
            if (isC2EPR)
            {
                slaveAddress = 0x56;
            }
            else
            {

            }

            try
            {
                var byteData = ConvertBytesToString(data);
                strWriteData = strWriteData + byteData?.Result.ToString();


                List<byte> dataBuffer = new List<byte>
                { 
                    // Firmware command 
                    0x6B, 

                    // Firmware command Read/write
                    0x01, 

                    // Slave address 
                    (byte)slaveAddress,

                    (byte)(length + 2),

                    // Offset address MSB
                    offsetMSB,

                    //Offset address LSB
                    offsetLSB,

                };
                if (data != null)
                {
                    if (data.Count > 0)
                    {
                        dataBuffer.AddRange(data);
                    }
                }

                retValue = m_grlEthernetLink_C2.Write(dataBuffer.ToArray());
            }
            catch (Exception ex)
            {
                retValue = false;
                MessageBox.Show("Write Error!!!");
            }
            return retValue;
        }
        private bool C2_FRAM_Baseboard_Read(uint startaddress, uint length, bool isC2EPR)

        {
            byte offsetLSB = (byte)(startaddress & 0xFF);
            byte offsetMSB = (byte)((startaddress >> 8) & 0xFF);
            bool retValue;
            try
            {

                // for C2 
                byte slaveAddress = 0x50;
                // for c2EPR
                if (isC2EPR)
                {
                    slaveAddress = 0x56;
                }
                else
                {

                }

                List<byte> dataBuffer = new List<byte>
                { 
                    // Firmware command 
                    0x6C, 

                    // Firmware command Read/write
                    0x01, 

                    // Slave address 
                    (byte)slaveAddress,
                    //0x50,

                    (byte)length,

                    0x02,

                      // Offset address MSB
                    offsetMSB,

                    //Offset address LSB
                    offsetLSB,

                };
                retValue = m_grlEthernetLink_C2.Write(dataBuffer.ToArray());
            }
            catch (Exception ex)
            {
                retValue = false;
                //HelperModule.Debug(MethodBase.GetCurrentMethod().Name, ex);
            }
            return retValue;
        }
        private bool FRAM_Baseboard_Read(ref byte[] data, string apiName)
        {
            data = new byte[] { 0xFC, 0x00, 0XE8 };
            return m_grlEthernetLink_C2.Read(ref data, apiName);
        }
        public bool Baseboard_FRAM_Read(ref byte[] data, uint startAddress, uint length, bool isC2EPR)
        {
            bool retValue = C2_FRAM_Baseboard_Read(startAddress, length, isC2EPR);
            if (retValue)
            {
                Thread.Sleep(500);
                retValue = FRAM_Baseboard_Read(ref data, MethodBase.GetCurrentMethod().Name);
            }
            else
            {
                MessageBox.Show("FRAM baseboard command execution failed");
            }
            return retValue;
        }

        public List<byte> RawData = new List<byte>();
        int endofFRAMIndication = 0;
        public bool Read(uint startOffset, uint length, bool isC2EPR)
        {
            byte[] dataBuffer = new byte[1024];
            bool retVal = true;
            Baseboard_FRAM_Read(ref dataBuffer, startOffset, length, isC2EPR);

            for (int i = 0; i < length; i++)
            {
                RawData.Add(dataBuffer[i]);
                if (dataBuffer[i] == 59)
                {
                    endofFRAMIndication++;
                    if (endofFRAMIndication == 4)
                    {
                        retVal = false;
                        break;
                    }
                }
                else
                {
                    endofFRAMIndication = 0;
                }
            }
            return retVal;
        }
        public int Get2ByteInt(int address)
        {
            int retVal = 0;
            try
            {
                retVal = (RawData[address + 1] << 8) + RawData[address];
            }
            catch (Exception ex)
            {
                //HelperModule.Debug(MethodBase.GetCurrentMethod().Name, ex);
            }

            return retVal;
        }
        public List<byte> Read(bool isC2EPR)
        {
            try
            {
                uint readStartIndex = 00;
                uint defaultLength = 200;

                RawData = new List<byte>();
                endofFRAMIndication = 0;

                // Read the first four bytes to get the FRAM data length
                Read(readStartIndex, 4, isC2EPR);

                // Check the validity of the FRAM
                int blockStart = Get2ByteInt(0);
                if (blockStart != 0x0A0A)
                {
                    //MessageShow("FRAM Start data was not proper");
                    return RawData;
                }

                uint totalDatalength = (uint)Get2ByteInt(2);

                readStartIndex += 4;
                uint readBytes = totalDatalength - readStartIndex;
                bool retVal = false;

                // This will read 200 bytes in one read command.
                if (totalDatalength > defaultLength)
                {
                    do
                    {
                        retVal = Read(readStartIndex, defaultLength, isC2EPR);
                        readStartIndex += defaultLength;
                        readBytes -= defaultLength;
                        //HelperModule.AddStatusUpdate($"Reading - {readStartIndex}");
                    } while (retVal == true && readBytes > defaultLength);
                }

                // This will read if there is any remaining bytes to be read 
                if (readBytes > 0)
                {
                    retVal = Read(readStartIndex, readBytes, isC2EPR);
                }

                // If the read buffer is filled then 
                // This will check if the data read properly 
                if (RawData.Count > 0)
                {
                    retVal = false;
                    endofFRAMIndication = 0;
                    if (totalDatalength == RawData.Count)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (RawData[RawData.Count - 1 - i] == 59)
                            {
                                endofFRAMIndication++;

                                // End of system details confirms by 4 semicolons 
                                if (endofFRAMIndication == 4)
                                {
                                    retVal = true;
                                    break;
                                }
                            }
                            else
                            {
                                endofFRAMIndication = 0;
                            }
                        }
                    }

                    if (!retVal)
                    {
                        //MessageBox.Show("System Details data length is improper " + RawData.Count);
                    }
                }

                //debug 
                if (true)
                {
                    var byteData = ConvertBytesToString(RawData);
                    strReadData = byteData?.Result.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return RawData;
        }
        private bool WriteValuesToFRAM_New(List<byte> data, bool isC2EPR)
        {
            bool retVal = true;
            uint _offSet = 0;
            try
            {
                uint maxLength = 200;
                uint offSet = _offSet;

                if (data.Count > maxLength)
                {
                    do
                    {
                        if (!retVal)
                        {
                            retVal = false;
                            break;
                        }
                        List<byte> tempByte = new List<byte>();
                        for (int i = 0; i < maxLength; i++)
                        {
                            tempByte.Add(data[i]);
                        }

                        retVal = BaseBoardWriteAPI(tempByte, offSet, (uint)tempByte.Count, isC2EPR);

                        Thread.Sleep(500);
                        offSet += (uint)tempByte.Count;
                        data.RemoveRange(0, (int)maxLength);
                        if (!retVal)
                        {
                            break;
                        }
                    }
                    while (data.Count > maxLength);
                }

                if (data.Count > 0 && retVal)
                {
                    retVal = BaseBoardWriteAPI(data, offSet, (uint)data.Count, isC2EPR);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Write Error.!!!");
            }
            return retVal;
        }

        //private bool WriteValuesToFRAM(List<byte> FRAMInput, int inofbytes, uint uioffset, bool isC2EPR)
        //{
        //    bool retVal = false;
        //    List<byte> data = new List<byte>();
        //    try
        //    {
        //        //lblstatusBar.Text = "Writing File to FRAM........";
        //        int maxLength = 250;
        //        byte[] databuffer = new byte[FRAMInput.Count + 6];
        //        byte[] tempbuf = new byte[maxLength];
        //        databuffer[0] = 0x6B;
        //        databuffer[1] = 0x01;
        //        // for C2 
        //        databuffer[2] = 0x50;
        //        // for c2EPR
        //        if (isC2EPR)
        //        {
        //            databuffer[2] = 0x56;
        //        }
        //        databuffer[3] = (byte)(inofbytes + 2);
        //        databuffer[4] = (byte)(uioffset >> 8);
        //        databuffer[5] = (byte)(uioffset);

        //        for (int i = 0; i < (FRAMInput.Count); i++)
        //        {
        //            databuffer[i + 6] = (FRAMInput[i]);
        //        }
        //        if (databuffer.Length >= maxLength)
        //        {
        //            List<byte> myBytes = new List<Byte>(databuffer);
        //            List<byte> tempBytes = new List<byte>();
        //            while (myBytes.Count > 0)
        //            {
        //                //IF count is greater than 250 
        //                if (myBytes.Count > maxLength)
        //                {
        //                    tempBytes = myBytes.GetRange(0, maxLength);
        //                    foreach (byte b in tempBytes)
        //                    {
        //                        data.Add(b);
        //                    }
        //                    retVal = m_grlEthernetLink_C2.Write(tempBytes.ToArray());
        //                    myBytes.RemoveRange(0, maxLength);
        //                }
        //                else
        //                {
        //                    //IF count is lesser than 250 - write and remove from the list -
        //                    //if count is 0 [due to removing the elements - while will break]
        //                    foreach (byte b in myBytes)
        //                    {
        //                        data.Add(b);
        //                    }
        //                    retVal = m_grlEthernetLink_C2.Write(myBytes.ToArray());
        //                    myBytes.RemoveRange(0, myBytes.Count);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            foreach (byte b in databuffer)
        //            {
        //                data.Add(b);
        //            }
        //            retVal = m_grlEthernetLink_C2.Write(databuffer);
        //        }
        //        Thread.Sleep(100);

        //    }
        //    catch (Exception ex)
        //    {
        //        retVal = false;
        //        MessageBox.Show("FRAM Write Failed : Please restart the board and Upload again");
        //    }

        //    strData = ConvertBytesToString(data).ToString();
        //    return retVal;
        //}
        public bool DecodeFramXL(string fileName, bool isC2EPR)
        {
            bool retVal = false;
            int tBytes = DecodeFRAMInput(fileName, isC2EPR);

            List<byte> byteList = new List<byte>();

            for (int i = 0; i < FramBlockDataLst.Count; i++)
            {
                List<byte> bytetemp = new List<byte>();
                for (int q = 0; q < FramBlockDataLst[i].framdata.Count; q++)
                {
                    bytetemp.AddRange(FramBlockDataLst[i].framdata[q].byteVal);
                    byteList.AddRange(FramBlockDataLst[i].framdata[q].byteVal);
                }
            }

            retVal = WriteValuesToFRAM_New(byteList, isC2EPR);
            if (retVal)
                FramBlockDataLst.Clear();
            FramdataLst.Clear();
            return retVal;
        }
    }
    public class FRAM_Data
    {
        public FRAM_ID F_ID = FRAM_ID.NONE;
        public FRAM_Blocks frBlock = FRAM_Blocks.NONE;
        public int uiBlockNo_of_Bytes = 0;
        public uint uiOffset = 0;
        public int iNo_of_bytes = 0;
        public string strValue = "";
        public byte[] byteVal = null;
        public string Desc = "";
        public FRAM_Data(FRAM_ID fid, uint ofset, int noofbytes, string strval, byte[] val)
        {
            F_ID = fid;
            uiOffset = ofset;
            iNo_of_bytes = noofbytes;
            strValue = strval;
            byteVal = val;
        }
    }
    public class FRAMBlocks
    {
        public FRAM_Blocks frBlock = FRAM_Blocks.NONE;
        public List<FRAM_Data> framdata = new List<FRAM_Data>();
        public int iNofobytes = 0;
        public uint uiOffsetAdd = 0;
        public FRAMBlocks(FRAM_Blocks blk, int noofbytes, uint offset)
        {
            frBlock = blk;
            iNofobytes = noofbytes;
            uiOffsetAdd = offset;
        }
    }
}

