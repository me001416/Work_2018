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

namespace Work_2018.Json.Build
{
    public partial class PowerBall : Form
    {
        string FileName;

        public PowerBall()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 開啟並選擇檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = Properties.Settings.Default.PowerBallDataPath;
            ofg.Multiselect = false;
            ofg.ShowDialog();
            FileName = ofg.FileName;
            textBox1.Text = ofg.FileName;

            if (string.IsNullOrEmpty(ofg.FileName))
            {
                return;
            }

            FileInfo fi = new FileInfo(ofg.FileName);
            Properties.Settings.Default.PowerBallDataPath = fi.DirectoryName;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// 讀取檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        }
    }
}
