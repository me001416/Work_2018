#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBall
{
    public class PowerBallList
    {
        /// <summary>
        /// List Of PowerBall.
        /// </summary>
        public List<BasePowerBall> PList { get; private set; }

        /// <summary>
        /// 建構函數
        /// </summary>
        public PowerBallList ()
        {
            PList = new List<BasePowerBall>();
        }

        /// <summary>
        /// 把 BasePowerBall 加入到 List
        /// </summary>
        /// <param name="SrcBasePowerBall">要加入的 BasePowerBall</param>
        public void Add (BasePowerBall SrcBasePowerBall)
        {
            PList.Add(SrcBasePowerBall);
        }

        /// <summary>
        /// 將加入的資料 Dump 出來
        /// </summary>
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
