using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

namespace BMSBoardRegister
{
    public class MySerial
    {
        public delegate void CBSERIALCLOSE();
        public delegate void CBSERIALDATA(char ch);

        private List<CBSERIALCLOSE> CBSerialCloseList = new List<CBSERIALCLOSE>();
        private List<CBSERIALDATA> CBSerialDataList = new List<CBSERIALDATA>();

        private object mDataLock = new object();
        private object mCloseLock = new object();

        public void addSerialDataCallback(CBSERIALDATA cb)
        {
            lock (mDataLock)
            {
                CBSerialDataList.Add(cb);
            }
        }

        public void removeSerialDataCallback(CBSERIALDATA cb)
        {
            lock (mDataLock)
            {
                CBSerialDataList.Remove(cb);
            }
        }

        public void addSerialClosedCallback(CBSERIALCLOSE cb)
        {
            lock (mCloseLock)
            {
                CBSerialCloseList.Add(cb);
            }
        }

        public void removeSerialClosedCallback(CBSERIALCLOSE cb)
        {
            lock (mCloseLock)
            {
                CBSerialCloseList.Remove(cb);
            }
        }

        private SerialPort mSerialPort = new SerialPort();

        public static string[] getPortList()
        {
            return SerialPort.GetPortNames();
        }

        public void close()
        {
            if (mSerialPort.IsOpen)
            {
                mSerialPort.Close();
                mSerialPort.Dispose();
            }
        }

        public bool open(string port)
        {
            close();

            try
            {
                mSerialPort.PortName = port;
                mSerialPort.BaudRate = 115200;
                mSerialPort.Open();
            }
            catch(Exception e)
            {
                close();
                return false;
            }

            new Thread(readThread).Start();
            return true;
        }

        public bool isOpen()
        {
            return mSerialPort.IsOpen;
        }

        public void write(byte[] data)
        {
            mSerialPort.Write(data, 0, data.Length);
        }

        public void readThread()
        {
            try
            {
                while (mSerialPort.IsOpen)
                {
                    int ch = -1;
                    try
                    {
                        ch = mSerialPort.ReadByte();
                        lock (mDataLock)
                        {
                            foreach (CBSERIALDATA cb in CBSerialDataList)
                            {
                                cb((char)ch);
                            }
                        }
                    }
                    catch (TimeoutException e)
                    {
                        continue;
                    }

                    if (ch < 0)
                        break;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("serial exception: " + e);
            }

            lock (mCloseLock)
            {
                foreach (CBSERIALCLOSE cb in CBSerialCloseList)
                {
                    cb();
                }
            }
        }
    }
}
