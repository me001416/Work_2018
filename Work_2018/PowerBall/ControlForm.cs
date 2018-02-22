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
    }
}
