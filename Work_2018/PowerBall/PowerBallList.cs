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
        /// 計算出是否有重複的排列組合
        /// </summary>
        public void Compare()
        {
            short Index;
            short Loop;
            short SrcIndex;

            for (Index = 0; Index < PList.Count; Index++)
            {
                for (Loop = Index; Loop < PList.Count; Loop++)
                {
                    SrcIndex = (short)(Loop + 1);
                    if (SrcIndex != PList.Count)
                    {
                        PList[Index].mCompare.Between(PList[Index], PList[SrcIndex]);
                    }
                }
            }
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

        /// <summary>
        /// 將加入的資料 Dump 出來
        /// </summary>
        public void Dump_Compare()
        {
#if DEBUG
            PList.ForEach(x =>
            {
                Trace.WriteLine(DateTime.Now);
                x.mCompare.Dump();
            });
#endif
        }
    }
}
