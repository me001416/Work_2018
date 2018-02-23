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
    }
}
