using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

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

        public DecodeFRAM()
        {
            FramdataLst = new List<FRAM_Data>();
            FramBlockDataLst = new List<FRAMBlocks>();
            m_grlEthernetLink_C2 = new GrlEthernetLink_C2();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("FRAM Write Failed : Please check the .XLS file");
            }
            return tBytes;
        }
        private bool WriteValuesToFRAM(List<byte> FRAMInput, int inofbytes, uint uioffset, bool isC2EPR)
        {
            bool retVal = false;
            try
            {
                //lblstatusBar.Text = "Writing File to FRAM........";
                int maxLength = 250;
                byte[] databuffer = new byte[FRAMInput.Count + 6];
                byte[] tempbuf = new byte[maxLength];
                databuffer[0] = 0x6B;
                databuffer[1] = 0x01;
                // for C2 
                databuffer[2] = 0x50;
                // for c2EPR
                if (isC2EPR)
                {
                    databuffer[2] = 0x56;
                }
                databuffer[3] = (byte)(inofbytes + 2);
                databuffer[4] = (byte)(uioffset >> 8);
                databuffer[5] = (byte)(uioffset);

                for (int i = 0; i < (FRAMInput.Count); i++)
                {
                    databuffer[i + 6] = (FRAMInput[i]);
                }
                if (databuffer.Length >= maxLength)
                {

                    List<byte> myBytes = new List<Byte>(databuffer);
                    List<byte> tempBytes = new List<byte>();
                    while (myBytes.Count > 0)
                    {
                        if (myBytes.Count > maxLength)
                        {
                            tempBytes = myBytes.GetRange(0, maxLength);
                            retVal = m_grlEthernetLink_C2.Write(tempBytes.ToArray());
                            myBytes.RemoveRange(0, maxLength);
                        }
                        else
                        {
                            retVal = m_grlEthernetLink_C2.Write(myBytes.ToArray());
                            myBytes.RemoveRange(0, myBytes.Count);
                        }
                    }

                    //for (int i = 0; i < databuffer.Length; i++)
                    //{
                    //    if ((i % maxLength) == 0)
                    //    {
                    //        retVal = m_grlEthernetLink_C2.Write(tempbuf);
                    //        tempbuf = new byte[maxLength];
                    //        tempbuf[i] = databuffer[i];
                    //    }
                    //    else
                    //    {
                    //        tempbuf[i] = databuffer[i];
                    //    }
                    //}
                }
                else
                {
                    retVal = m_grlEthernetLink_C2.Write(databuffer);
                }
                Thread.Sleep(100);

            }
            catch (Exception ex)
            {
                retVal = false;
                MessageBox.Show("FRAM Write Failed : Please restart the board and Upload again");
            }
            return retVal;
        }
        public bool DecodeFramXL(string fileName, bool isC2EPR)
        {
            bool retVal = false;
            int tBytes = DecodeFRAMInput(fileName, isC2EPR);

            for (int i = 0; i < FramBlockDataLst.Count; i++)
            {
                List<byte> bytetemp = new List<byte>();
                for (int q = 0; q < FramBlockDataLst[i].framdata.Count; q++)
                {
                    bytetemp.AddRange(FramBlockDataLst[i].framdata[q].byteVal);
                }
                retVal = WriteValuesToFRAM(bytetemp, FramBlockDataLst[i].iNofobytes, FramBlockDataLst[i].uiOffsetAdd, isC2EPR);
            }
            if (retVal)
                //m_Notify.UpdateResult("Number of bytes uploaded : " + tBytes.ToString());
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

