#define DEBUG

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2018.PowerBall
{
    class PowerBallList
    {
        public List<BasePowerBall> PList { get; private set; }

        public PowerBallList ()
        {
            PList = new List<BasePowerBall>();
        }

        public void Add (BasePowerBall SrcBasePowerBall)
        {
            PList.Add(SrcBasePowerBall);
        }

        public void Dump()
        {
#if DEBUG
            PList.ForEach(x =>
            {
                Trace.WriteLine(DateTime.Now);
                Trace.WriteLine(x.NumList[0] + " ");
                Trace.WriteLine(x.NumList[1] + " ");
                Trace.WriteLine(x.NumList[2] + " ");
                Trace.WriteLine(x.NumList[3] + " ");
                Trace.WriteLine(x.NumList[4] + " ");
                Trace.WriteLine(x.NumList[5] + " ");
                Trace.WriteLine(x.NumList[6] + " ");
                Trace.WriteLine(x.Mouth + " ");
                Trace.WriteLine(x.Day + " ");
                Trace.WriteLine(x.Year + " ");
            });
#endif
        }
    }
}
