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
        public PowerBall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.InitialDirectory = Properties.Settings.Default.PowerBallDataPath;
            ofg.Multiselect = false;
            ofg.ShowDialog();
            textBox1.Text = ofg.FileName;

            if (string.IsNullOrEmpty(ofg.FileName))
            {
                return;
            }

            FileInfo fi = new FileInfo(ofg.FileName);
            Properties.Settings.Default.PowerBallDataPath = fi.DirectoryName;
            Properties.Settings.Default.Save();
        }
    }
}
