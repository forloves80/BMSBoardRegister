using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BMSBoardRegister
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallNone();
        private delegate void SafeCallChar(char ch);

        private MySerial mSerial = new MySerial();
        private string mLogTmp = "";

        private System.Timers.Timer mLogTimer;
        private object mLogLock = new object();

        private void setLogTimer()
        {
            if (mLogTimer != null)
                return;

            mLogTimer = new System.Timers.Timer(100);
            mLogTimer.Elapsed += onLogTimer;
            mLogTimer.AutoReset = true;
            mLogTimer.Enabled = true;

        }

        private void onLogTimer(Object sender, ElapsedEventArgs e)
        {
            writeLog();
        }

        private void stopLogTimer()
        {
            if (mLogTimer == null)
                return;

            mLogTimer.Stop();
            mLogTimer.Dispose();
            mLogTimer = null;

            writeLog();
        }

        private void writeLog()
        {
            if(this.InvokeRequired)
            {
                try
                {
                    var d = new SafeCallNone(writeLog);
                    this.Invoke(d);
                }
                catch(Exception e)
                {
                    return;
                }
            }
            else
            {
                lock (mLogLock)
                {
                    textBox_log.AppendText(mLogTmp);
                    mLogTmp = "";
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "BMS Board Register " + Const.__VERSION__;

            checkBox_hide.Checked = true;

            mSerial.addSerialClosedCallback(SerialClosed);
            mSerial.addSerialDataCallback(LogSerialChar);

            button_get_n_check.Enabled = false;
            button_save.Enabled = false;
            comboBox_boardversion.Enabled = false;
            comboBox_etc.Enabled = false;

            comboBox_serialport.Enabled = true;
        }

        public void SerialClosed()
        {
            if (this.InvokeRequired)
            {
                try
                {
                    var d = new SafeCallNone(SerialClosed);
                    this.Invoke(d);
                }
                catch(Exception e)
                {
                    return;
                }
            }
            else
            {
                button_openSerial.Text = "Open";

                button_get_n_check.Enabled = false;
                button_save.Enabled = false;
                comboBox_boardversion.Enabled = false;
                comboBox_etc.Enabled = false;

                comboBox_serialport.Enabled = true;

                stopLogTimer();
            }
        }

        public void LogSerialChar(char ch)
        {
            lock(mLogLock)
            {
                mLogTmp += ch;
            }
        }

        private void checkBox_hide_CheckedChanged(object sender, EventArgs e)
        {
            textBox_pw.PasswordChar = (checkBox_hide.Checked) ? '*' : '\0';
        }

        private void comboBox_serialport_DropDown(object sender, EventArgs e)
        {
            string[] ports = MySerial.getPortList();
            comboBox_serialport.Items.Clear();
            foreach(string s in ports)
            {
                comboBox_serialport.Items.Add(s);
            }
        }

        private void button_get_n_check_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            if(dlg.getNCheck(textBox_id.Text, textBox_pw.Text, mSerial))
            {
                textBox_registered.Text = dlg.mBmsIdExist ? "Registered" : "Unregistered";
                textBox_bmsid.Text = dlg.mBMSId;

                string oldText = comboBox_boardversion.Text;
                comboBox_boardversion.Items.Clear();
                foreach(string t in dlg.mVersionList)
                {
                    comboBox_boardversion.Items.Add(t);
                }
                comboBox_boardversion.Text = oldText;

                comboBox_etc.Items.Clear();
                comboBox_etc.Items.Add("");
                foreach (string t in dlg.mETCList)
                {
                    comboBox_etc.Items.Add(t);
                }

                if(dlg.mBmsIdExist)
                {
                    comboBox_boardversion.Text = dlg.mVersion;
                    comboBox_etc.Text = dlg.mETC;
                }
            }
        }

        private void button_openSerial_Click(object sender, EventArgs e)
        {
            if(mSerial.isOpen())
            {
                mSerial.close();
            }
            else
            {
                if(mSerial.open(comboBox_serialport.Text))
                {
                    button_openSerial.Text = "Close";

                    button_get_n_check.Enabled = true;
                    button_save.Enabled = true;
                    comboBox_boardversion.Enabled = true;
                    comboBox_etc.Enabled = true;

                    comboBox_serialport.Enabled = false;

                    if(!checkBox_stoplog.Checked)
                    {
                        setLogTimer();
                    }
                }
            }
        }

        private void button_clearlog_Click(object sender, EventArgs e)
        {
            mLogTmp = "";
            textBox_log.Text = "";
        }

        private void checkBox_stoplog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_stoplog.Checked)
            {
                stopLogTimer();
            }
            else
            {
                if (mSerial.isOpen())
                {
                    setLogTimer();
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            if (dlg.save(textBox_id.Text, textBox_pw.Text, textBox_bmsid.Text, comboBox_boardversion.Text, comboBox_etc.Text))
            {
                textBox_registered.Text = "Registered";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            mSerial.removeSerialClosedCallback(SerialClosed);
            mSerial.removeSerialDataCallback(LogSerialChar);

            mSerial.close();
        }
    }
}
