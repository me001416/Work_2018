#define DEBUG

using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Work_2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
#if DEBUG
            Trace.WriteLine(DateTime.Now + "Program Start");
#endif
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if DEBUG
            Trace.WriteLine(DateTime.Now + "SourceFile Start");
#endif
            Json.Build.PowerBall mPowerBall = new Json.Build.PowerBall();
            mPowerBall.Top = Top;
            mPowerBall.Left = Left;
            mPowerBall.ShowDialog();
#if DEBUG
            Trace.WriteLine(DateTime.Now + "SourceFile End");
#endif
        }
    }
}
