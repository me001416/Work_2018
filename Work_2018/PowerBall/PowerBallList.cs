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

    }

    class BasePowerBall
    {
        //
        // List of number.
        //
        public List<int> NumList { get; private set; }

        //
        // mm/dd/yyyy
        //
        public int Mouth { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        public BasePowerBall()
        {
            NumList = new List<int>();
        }

        /// <summary>
        /// 設定 Day
        /// </summary>
        public void SetDay(int SrcDay)
        {
            if (SrcDay < 1 || SrcDay > 12)
            {
#if DEBUG
                Trace.WriteLine("Wrong SrcDay : " + SrcDay);
#endif
            }
            else
            {
                Day = SrcDay;
            }
        }

        /// <summary>
        /// 設定 Mouth
        /// </summary>
        public void SetMouth(int SrcMouth)
        {
            if (SrcMouth < 1 || SrcMouth > 12)
            {
#if DEBUG
                Trace.WriteLine("Wrong SrcMouth : " + SrcMouth);
#endif
            }
            else
            {
                Mouth = SrcMouth;
            }
        }

        /// <summary>
        /// 設定 Year
        /// </summary>
        public void SetYear(int SrcYear)
        {
            if (SrcYear < 2010 || SrcYear > 2025)
            {
#if DEBUG
                Trace.WriteLine("Wrong SrcYear : " + SrcYear);
#endif
            }
            else
            {
                Year = SrcYear;
            }
        }

        /// <summary>
        /// 加入數據
        /// </summary>
        /// <param name="SrcNum"></param>
        public void Add(int SrcNum)
        {
            if (SrcNum < 1 || SrcNum > 49)
            {
#if DEBUG
                Trace.WriteLine("Wrong SrcNum : " + SrcNum);
#endif
            }
            else
            {
                NumList.Add(SrcNum);
            }
        }

        /// <summary>
        /// 排序 NumList
        /// </summary>
        public void Sort()
        {
            NumList.Sort();
        }
    }
}
