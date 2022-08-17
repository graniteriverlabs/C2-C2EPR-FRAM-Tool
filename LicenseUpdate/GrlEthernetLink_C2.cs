using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;


namespace UpdateFRAMBlocks
{
    public class GrlEthernetLink_C2
    {
        public bool IsPortOpen = false;

        public bool UseEthernetLink
        {
            get; set;
        }
        //RF Comment:: Use property
        public bool m_UseEthernetLink = true;

        //RF Comment:: Create property and validate in setting, it should not exceed 62K, if the user set more than that you should throw exception
        public int m_databuffersize = 1024;

        private readonly Object m_ReadWriteLock = new Object();
        private readonly Object m_ReadAPILock = new Object();

        //RF Comment:: Create property and validate in setting, Make it read only
        public int m_ReadPort = 5002, m_WritePort = 5002;
        TcpClient m_ReadClient = null, m_WriteClient = null;
        NetworkStream m_ReadStream = null, m_WriteStream = null;

        //RF Comment, expose a property
        public bool m_DebugWrite = true;
        public bool m_DebugRead = false;

        public int iWritetimeDelay = 5;
        public int iReadtimeDelay = 10;

        int m_iRetryCount = 0;
        int m_iReadRetryCount = 0;
        bool m_isAppForcedToStop = true;
        // RF Comment:: thsi should be a property
        public static string m_ipAddress = "";

        private string m_ethDns;
        private string m_ethIP;
        private string m_ethName;

        public GrlEthernetLink_C2(string IPAdd = "192.168.255.1")
        {
            m_ipAddress = IPAdd;
        }
        public bool InitilizePort()
        {
            bool retValue = false;
            try
            {
                if (IsPortOpen == false)
                {
                    EthernetDiscovery(out m_ethIP, out m_ethDns, out m_ethName);
                    System.Net.ServicePointManager.Expect100Continue = false;
                    m_ipAddress = "192.168.255.1";
                    if ((m_ethIP == m_ipAddress))
                    {
                        string[] addArray = m_ethIP.Split('.');
                        int Lastnumber = 0;
                        int.TryParse(addArray[addArray.Length - 1], out Lastnumber);
                        Lastnumber += 1;
                        addArray[addArray.Length - 1] = Lastnumber.ToString();
                        m_ethIP = addArray[addArray.Length - 4] + "." + addArray[addArray.Length - 3] + "." + addArray[addArray.Length - 2] + "." + addArray[addArray.Length - 1];
                        SetIP("/c netsh interface ip set address \"" + m_ethName + "\" static " + m_ethIP);
                    }
                    m_ReadClient = new TcpClient(m_ipAddress, m_ReadPort);
                    m_ReadClient.NoDelay = true;
                    m_ReadStream = m_ReadClient.GetStream();
                    m_WriteClient = new TcpClient(m_ipAddress, m_WritePort);
                    m_WriteClient.NoDelay = true;
                    m_WriteStream = m_WriteClient.GetStream();
                    m_ReadClient.ReceiveTimeout = 5000;
                    m_WriteClient.SendTimeout = 5000;

                    if ((m_ReadClient.Connected) && (m_WriteClient.Connected) )
                    {
                        IsPortOpen = true;
                        m_iRetryCount = 0;
                        m_iReadRetryCount = 0;
                        m_isAppForcedToStop = false;
                    }
                }
            }
            catch (Exception ex)
            {
                IsPortOpen = false;
                retValue = false;
            }
            return retValue;
        }
        public void CloseLink()
        {
            Dispose();
        }
        public bool Write(byte[] buffer)
        {
            bool retValue = false;
            try
            {

                lock (m_ReadAPILock)
                {
                    if (m_DebugWrite)
                    {
                    }
                    if (m_iRetryCount > 2)
                    {
                        m_iRetryCount = 0;
                        return false;
                    }

                    byte[] dataBuffer;
                    int numberOfBytesToRead = 1024;
                    dataBuffer = new byte[numberOfBytesToRead];
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        dataBuffer[i] = buffer[i];
                    }
                    if (m_DebugWrite)
                    {
                        string strPayloaddata = "";
                        for (int i = 0; i < buffer.Length; i++)
                        {
                            strPayloaddata += "0x" + buffer[i].ToString("X").ToUpper().PadLeft(2, '0') + ", ";
                        }
                    }
                    if (m_WriteClient != null)
                    {
                        if (m_WriteClient.Connected)//TODO Check stream state
                        {
                            m_WriteStream.Write(dataBuffer, 0, dataBuffer.Length);
                            m_iRetryCount = 0;
                            iWritetimeDelay = 5;
                            for (int i = 0; i < iWritetimeDelay; i++)
                                Thread.Sleep(1);
                        }
                        else
                            m_iRetryCount++;
                    }
                    else
                        m_iRetryCount++;

                    if (m_iRetryCount > 0)
                    {
                        retValue = RetryWriteOperation(buffer);
                        //if (m_iRetryCount >= 1)
                        //{
                        //    FWAppObj.FWHost.ShowMessage("Tester ethernet communication error. Power cycle the Tester and try again.", FWAppObj.FWHost.ModuleManager.ActiveModule.AppDisplayName);
                        //    return false;
                        //}
                    }
                    retValue = true;
                    if (m_DebugWrite)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                IsPortOpen = false;
                retValue = false;
                m_iRetryCount = 0;
                retValue = RetryWriteOperation(buffer);
            }
            return retValue;
        }
        public bool Read(ref byte[] buffer, String sApiDesc = "")
        {
            bool retValue = false;
            try
            {
                string strPayloaddata = "";
                if (m_iReadRetryCount >= 1)
                {
                    //m_iReadRetryCount = 0;
                    return false;
                }
                lock (m_ReadAPILock)
                {
                    if (m_DebugRead)
                    {
                    }
                    byte[] dataBuffer;
                    int numberOfBytesToRead = 1024;
                    dataBuffer = new byte[numberOfBytesToRead];

                    for (int i = 0; i < buffer.Length; i++)
                        dataBuffer[i] = buffer[i];

                    if (m_ReadClient.Connected)
                    {
                        m_ReadStream.Write(dataBuffer, 0, dataBuffer.Length);
                        m_iReadRetryCount = 0;
                    }
                    else
                        m_iReadRetryCount++;

                    if (m_iReadRetryCount >= 1)
                    {
                        //FWAppObj.FWHost.DelegateForceStopEvent.Invoke(true);
                        return false;
                    }
                    //int isleep = iReadtimeDelay;
                    //if (m_databuffersize <= 1024)
                    //    isleep = 10;
                    ////if (m_databuffersize >= (61 * 1024))
                    ////    isleep = 100;
                    //Thread.Sleep(isleep);
                    if (m_DebugWrite)
                    {
                        for (int i = 0; i < buffer.Length; i++)
                            strPayloaddata += "0x" + buffer[i].ToString("X").ToUpper().PadLeft(2, '0') + ", ";
                    }
                    buffer = new byte[m_databuffersize];
                    if (m_ReadClient.Connected)
                    {
                        int readRetry = 100;
                        int streamReadCount = 0;
                        List<byte> totalReadData = new List<byte>();
                        do
                        {
                            int validByteCount = m_ReadStream.Read(buffer, 0, buffer.Length);
                            if (validByteCount > 0)
                            {
                                streamReadCount += validByteCount;
                                totalReadData.AddRange(buffer.Take(validByteCount));
                            }
                            readRetry--;
                        } while (streamReadCount < buffer.Length && readRetry > 0);
                        retValue = true;
                        buffer = totalReadData.ToArray();
                        retValue = true;
                        m_iReadRetryCount = 0;
                    }
                    else
                        m_iReadRetryCount++;

                    if (m_DebugRead)
                    {
                        strPayloaddata = "";
                        int iReadLimit = m_databuffersize;
                        if (iReadLimit > 20)
                        {
                            if (m_databuffersize > 4096)
                                iReadLimit = 20;
                            else
                                iReadLimit = 20;
                        }
                        for (int i = 0; i < iReadLimit; i++)
                            strPayloaddata += "0x" + buffer[i].ToString("X").ToUpper().PadLeft(2, '0') + ", ";
                    }
                    if (m_DebugRead)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                retValue = false;
                IsPortOpen = false;
                m_iReadRetryCount = 0;
                if (m_isAppForcedToStop == false)
                {
                    m_isAppForcedToStop = true;
                }
            }
            return retValue;
        }

        private bool RetryWriteOperation(byte[] buffer)
        {
            bool retValue = false;
            try
            {
                if (m_iRetryCount > 1)
                {
                    return false;
                }

                Thread.Sleep(1000);
                InitilizePort();
                Thread.Sleep(1000);
                Write(buffer); //Recursive method call

                retValue = true;
            }
            catch (Exception ex)
            {
                IsPortOpen = false;
                retValue = false;
            }
            return retValue;
        }
        private void EthernetDiscovery(out string ip, out string dns, out string nic)  // To get current ethernet config
        {
            ip = "";
            dns = "";
            nic = "";
            try
            {
                string[] NwDesc = { "TAP", "VMware", "Windows", "Virtual" };  // Adapter types (Description) to be ommited
                foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet && !NwDesc.Any(ni.Description.Contains))  // check for adapter type and its description
                    {

                        foreach (IPAddress dnsAdress in ni.GetIPProperties().DnsAddresses)
                        {
                            if (dnsAdress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                dns = dnsAdress.ToString();
                            }
                        }
                        foreach (UnicastIPAddressInformation ips in ni.GetIPProperties().UnicastAddresses)
                        {
                            if (ips.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !ips.Address.ToString().StartsWith("169")) //to exclude automatic ips
                            {
                                ip = ips.Address.ToString();
                                nic = ni.Name;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void SetIP(string arg)  //To set IP with elevated cmd prompt
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("cmd.exe");
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                psi.Verb = "runas";
                psi.Arguments = arg;
                Process.Start(psi);
            }
            catch (Exception ex)
            {
            }
        }

        ~GrlEthernetLink_C2()
        {
            Dispose();
        }
        public void Dispose()
        {
            try
            {
                if (m_ReadClient != null)
                    m_ReadClient.Close();
                if (m_ReadStream != null)
                    m_ReadStream.Close();
                if (m_WriteClient != null)
                    m_WriteClient.Close();
                if (m_WriteStream != null)
                    m_WriteStream.Close();
                IsPortOpen = false;
            }
            catch (Exception ex)
            {
                IsPortOpen = false;

            }
        }
    }
}
