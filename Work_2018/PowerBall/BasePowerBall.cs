#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PowerBall
{
    class BasePowerBall
    {
        //
        // List of number.
        //
        public List<byte> NumList { get; private set; }

        //
        // mm/dd/yyyy
        //
        public byte Mouth { get; private set; }
        public byte Day { get; private set; }
        public short Year { get; private set; }

        /// <summary>
        /// 建構函數
        /// </summary>
        public BasePowerBall()
        {
            NumList = new List<byte>();
        }

        /// <summary>
        /// 設定 Day
        /// </summary>
        public void SetDay(byte SrcDay)
        {
            if (SrcDay < 1 || SrcDay > 31)
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
        public void SetMouth(byte SrcMouth)
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
        public void SetYear(short SrcYear)
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
        public void Add(byte SrcNum)
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

        public void BuildSubsets()
        {
            Combination.Generate mCombinations = new Combination.Generate();
            List<List<int>> mListOfNumList = new List<List<int>>();

            if (NumList.Count == 0)
            {
                Trace.WriteLine(DateTime.Now + "Error : NumList.Count == 0");
            }

            if (NumList.Count == 7)
            {
                GetSubsetFromList(mCombinations.NewCombine(NumList, 3));
                GetSubsetFromList(mCombinations.NewCombine(NumList, 4));
                GetSubsetFromList(mCombinations.NewCombine(NumList, 5));
                GetSubsetFromList(mCombinations.NewCombine(NumList, 6));
            }
            else
            {
                Trace.WriteLine(DateTime.Now + "Error : NumList.Count = " + NumList.Count.ToString());
            }
        }
    }
}
