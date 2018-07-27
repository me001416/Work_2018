using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerBall;

namespace Work_2018.PowerBall
{
    public partial class ControlForm : Form
    {
        string FileName;
        dynamic SaveJson;
        PowerBallList gPowerBallList;

        public ControlForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = Properties.Settings.Default.PowerBallSavePath;
            ofg.Multiselect = false;
            ofg.ShowDialog();
            FileName = ofg.FileName;
            textBox1.Text = ofg.FileName;

            if (string.IsNullOrEmpty(ofg.FileName))
            {
                return;
            }

            FileInfo mFileInfo = new FileInfo(ofg.FileName);
            Properties.Settings.Default.PowerBallSavePath = mFileInfo.DirectoryName;
            Properties.Settings.Default.Save();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(() => FileLoad());
        }

        /// <summary>
        /// 用 StreamReader 來進行檔案讀取
        /// </summary>
        private void FileLoad()
        {
            StreamReader SR = new StreamReader(FileName, System.Text.Encoding.Default);
            string FileStr = SR.ReadToEnd();
            SR.Close();

            SaveJson = JsonConvert.DeserializeObject(FileStr);

            FillOutPowerBallList();
        }

        private void FillOutPowerBallList()
        {
            gPowerBallList = new PowerBallList();

            foreach (dynamic item in SaveJson.PowerBall)
            {
                BasePowerBall mBasePowerBall = new BasePowerBall();

                mBasePowerBall.Add((byte)item.Num1.ToObject<Int32>());
                mBasePowerBall.Add((byte)item.Num2.ToObject<Int32>());
                mBasePowerBall.Add((byte)item.Num3.ToObject<Int32>());
                mBasePowerBall.Add((byte)item.Num4.ToObject<Int32>());
                mBasePowerBall.Add((byte)item.Num5.ToObject<Int32>());
                mBasePowerBall.Add((byte)item.Num6.ToObject<Int32>());
                mBasePowerBall.Add((byte)item.Num7.ToObject<Int32>());

                mBasePowerBall.SetMouth((byte)item.M.ToObject<Int32>());
                mBasePowerBall.SetDay((byte)item.D.ToObject<Int32>());
                mBasePowerBall.SetYear((short)item.Y.ToObject<Int32>());

                mBasePowerBall.Sort();
                mBasePowerBall.BuildSubsets();

                gPowerBallList.Add(mBasePowerBall);
            }

            gPowerBallList.Dump();
        }
    }
}
