using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMSBoardRegister
{
    public partial class Form2 : Form
    {
        private delegate void SafeCallTextInt(string text, int v1);
        private delegate void SafeCallText(string text);

        private string mUserId;
        private string mPassWD;
        private MySerial mSerial;

        private static string MATER_URL = "https://web.betterwhyiot.com/bms_service";

        public Form2()
        {
            InitializeComponent();
        }

        public bool run(string _title)
        {
            this.Text = _title;
            ShowDialog();

            return true;
        }

        public void setStatus(string statusText, int progress)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    var d = new SafeCallTextInt(setStatus);
                    this.Invoke(d, new object[] { statusText, progress });
                }
                catch (Exception e)
                {
                    return;
                }
            }
            else
            {
                if (progress < 0)
                {
                    Dispose();
                    return;
                }

                label_state.Text = "State: " + statusText;
                progressBar_running.Value = progress;
            }
        }

        public void setError(string errText)
        {
            if (this.InvokeRequired)
            {
                try
                {
                    var d = new SafeCallText(setError);
                    this.Invoke(d, new object[] { errText });
                }
                catch(Exception e)
                {
                    return;
                }
            }
            else
            {
                label_state.Text = "Error: " + errText;
                progressBar_running.Visible = false;
                button_close.Visible = true;
            }
        }

        private int threadType;

        public bool getNCheck(string userid, string passwd, MySerial serial)
        {
            mUserId = userid;
            mPassWD = passwd;
            mSerial = serial;

            Text = "Get And Check Process";
            mRet = false;
            threadType = 0;
            ShowDialog();
            return mRet;
        }

        public bool save(string userid, string passwd, string bmsid, string version, string etc)
        {
            mUserId = userid;
            mPassWD = passwd;
            mBMSId = bmsid;
            mVersion = version;
            mETC = etc;

            Text = "Save To Webapp";
            mRet = false;
            threadType = 1;
            ShowDialog();
            return mRet;
        }

        public bool mRet;
        private byte[] mBuf = new byte[25];
        private int mBufPos = 0;
        public string mBMSId;

        private static byte[] HEADSIGN = { (byte)'B', (byte)'D', 0, 20 };
        private EventWaitHandle recvEvt = new EventWaitHandle(false, EventResetMode.ManualReset);

        public void onSerialData(char ch)
        {
            
            if (mBMSId != null)
                return;

            mBuf[mBufPos] = (byte)ch;
            mBufPos++;

            if (mBufPos == 1)
            {
                if (mBuf[0] != 'B')
                {
                    mBufPos = 0;
                }

                return;
            }
            else if (mBufPos == 2)
            {
                if(mBuf[1] == 'D')
                {
                    return;
                }
            }
            else if (mBufPos == 3)
            {
                if(mBuf[2] == 0)
                {
                    return;
                }
            }
            else if (mBufPos == 4)
            {
                if(mBuf[3] == 4)
                {
                    return;
                }
            }
            else if (mBufPos == 25)
            {
                if (mBuf[24] == checkSum(mBuf, 24))
                {
                    int len = 0;
                    for(int i = 0; i < 20; i++)
                    {
                        if(mBuf[i + 4] == 0)
                        {
                            len = i;
                            break;
                        }
                    }
                    mBMSId = Encoding.Default.GetString(mBuf, 4, len);
                    recvEvt.Set();
                    return;
                }
            }
            else
            {
                return;
            }

            for(int i = 0; i < mBufPos; i++)
            {
                int left = mBufPos - i;
                if (left > 4) left = 4;

                bool headexist = true;
                for(int j = 0; j < left; j++)
                {
                    if (mBuf[i + j] != HEADSIGN[j])
                    {
                        headexist = false;
                        break;
                    }
                }

                if(headexist)
                {
                    left = mBufPos - i;
                    for(int j = 0; j < left; j++)
                    {
                        mBuf[j] = mBuf[j + i];
                        mBufPos -= i;
                    }
                    return;
                }
            }

            mBufPos = 0;
        }

        private JObject HttpResponse(string sub_url, JObject data)
        {
            string webapi = MATER_URL + sub_url;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(webapi);
            if (request == null)
                return JObject.Parse("{}");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Timeout = 5000;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;

            string textData = data.ToString();

            byte[] bytes = Encoding.UTF8.GetBytes(textData);

            JObject ret;
            try
            {
                request.ContentLength = bytes.Length;
                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(bytes, 0, bytes.Length);
                }

                string responseText = string.Empty;
                using (WebResponse resp = request.GetResponse())
                {
                    Stream respStream = resp.GetResponseStream();
                    using (StreamReader sr = new StreamReader(respStream))
                    {
                        responseText = sr.ReadToEnd();
                    }
                }

                ret = JObject.Parse(responseText);
            }
            catch (Exception e)
            {
                return null;
            }

            return ret;
        }

        public bool mBmsIdExist = false;
        public string[] mVersionList;
        public string[] mETCList;
        public string mVersion;
        public string mETC;

        private bool ping()
        {
            HttpResponse("/v3/ping/", new JObject());
            return true;
        }

        private bool getBMSIdInfo()
        {
            JObject jsonReq = new JObject(
                new JProperty("username", mUserId),
                new JProperty("password", mPassWD),
                new JProperty("bms_id", mBMSId)
                );

            JObject ret = HttpResponse("/v3/checkBMSOption/", jsonReq);

            if(ret == null || !ret.ContainsKey("result"))
            {
                return false;
            }

            mBmsIdExist = ret["result"]["exist"].Value<bool>();

            if(mBmsIdExist)
            {
                mVersion = ret["result"]["board_version"].ToString();
                mETC = ret["result"]["etc"].ToString();
            }

            JArray array = (JArray)ret["result"]["board_version_list"];
            List<string> arrayTemp = new List<string>();
            foreach(JToken item in array)
            {
                arrayTemp.Add(item.ToString());
            }
            mVersionList = arrayTemp.ToArray();
            arrayTemp.Clear();
            array = (JArray)ret["result"]["etc_list"];
            foreach (JToken item in array)
            {
                arrayTemp.Add(item.ToString());
            }
            mETCList = arrayTemp.ToArray();

            return true;
        }

        private bool saveBMSInfo()
        {
            JObject jsonReq = new JObject(
                new JProperty("username", mUserId),
                new JProperty("password", mPassWD),
                new JProperty("bms_id", mBMSId),
                new JProperty("board_version", mVersion),
                new JProperty("etc", mETC)
                );

            JObject ret = HttpResponse("/v3/setBMSOption/", jsonReq);

            if(ret == null || !ret.ContainsKey("status") || !ret["status"].Value<bool>())
            {
                return false;
            }

            return true;
        }

        public void getNCheckThread()
        {
            setStatus("try to open serial port", 0);

            mBufPos = 0;
            mBMSId = null;
            recvEvt.Reset();

            mSerial.addSerialDataCallback(onSerialData);
            setStatus("BMS ID를 가져오고 있습니다.", 10);
            byte[] buf = new byte[5];
            buf[0] = (byte)'B';
            buf[1] = (byte)'R';
            buf[2] = (byte)0;
            buf[3] = (byte)20;
            buf[4] = checkSum(buf, 4);
            mSerial.write(buf);

            recvEvt.WaitOne(5000);
            mSerial.removeSerialDataCallback(onSerialData);

            if (mBMSId == null)
            {
                setError("BMS ID를 가져오지 못했습니다.");
                return;
            }

            ping();

            setStatus("BMS ID 등록 정보를 가져오고 있습니다.", 50);

            if(!getBMSIdInfo())
            {
                setError("BMS ID 등록 정보를 가져오지 못했습니다.");
                return;
            }

            mRet = true;
            setStatus("", -1);
        }

        public void saveThread()
        {
            setStatus("try to save to webapp", 0);
            if(!saveBMSInfo())
            {
                setError("BMS 등록에 실패했습니다.");
                return;
            }

            mRet = true;
            setStatus("", -1);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private static byte checkSum(byte[] data, int size)
        {
            byte sum = 0;
            for(int i = 0; i < size; i++)
            {
                sum += data[i];
            }
            return (byte)(sum & 0xFF);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(threadType == 0)
            {
                new Thread(getNCheckThread).Start();
            }
            else if(threadType == 1)
            {
                new Thread(saveThread).Start();
            }
        }
    }
}
