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
        }

        private void FillOutPowerBallList()
        {
            gPowerBallList = new PowerBallList();

            foreach (dynamic item in SaveJson.PowerBall)
            {
                BasePowerBall mBasePowerBall = new BasePowerBall();

                mBasePowerBall.Add(item.Num1);
                mBasePowerBall.Add(item.Num2);
                mBasePowerBall.Add(item.Num3);
                mBasePowerBall.Add(item.Num4);
                mBasePowerBall.Add(item.Num5);
                mBasePowerBall.Add(item.Num6);
                mBasePowerBall.Add(item.Num7);
            }
        }
    }
}
