#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combination;

namespace PowerBall
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
#if DEBUGN
            PList.ForEach(x =>
            {
                Trace.WriteLine(DateTime.Now);
                Trace.WriteLine(x.NumList[0] + " " + x.NumList[1] + " " + x.NumList[2] + " " + x.NumList[3] + " " + x.NumList[4] + " " + x.NumList[5] + " " + x.NumList[6] + " " + x.Mouth + " " + x.Day + " " + x.Year + " ");
            });
#endif
        }
    }
}
