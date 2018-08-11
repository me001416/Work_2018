#define DEBUG
using System.Collections.Generic;
using System.Diagnostics;

namespace PowerBall.Subsets
{
    /// <summary>
    /// Subsets of combination.
    /// </summary>
    public class Subsets
    {
        //public string Name { get; private set; }
        //public int Count { get; private set; }
        public List<byte> numList { get; private set; }

        /// <summary>
        /// 建構函數
        /// </summary>
        /// <param name="SrcNumList">資料來源</param>
        public Subsets(List<byte> SrcNumList, int SrcCount)
        {
            numList = SrcNumList;
            //Name = BuildName(numList);
            //Count = SrcCount;
        }

        /// <summary>
        /// 建構函數
        /// </summary>
        /// <param name="SrcNumList">資料來源</param>
        public Subsets(List<byte> SrcNumList)
        {
            numList = SrcNumList;
            //Name = BuildName(numList);
            //Count = SrcCount;
        }
#if false
        private string BuildName(List<int> SrcNumList)
        {
            string str = string.Empty;

            if (SrcNumList.Count == 0)
            {
                Debug.Assert(false, "Subsets.cs", "srcNumList.Count == 0");
            }

            for (int i = 0; i < SrcNumList.Count; i++)
            {
                str = str + "[" + SrcNumList[i].ToString() + "]";
            }

            return str;
        }
#endif
        /// <summary>
        /// 長度
        /// </summary>
        /// <returns>回傳長度</returns>
        public int Length()
        {
            return numList.Count;
        }

        /// <summary>
        /// 將加入的資料 Dump 出來
        /// </summary>
        public void Dump()
        {
#if DEBUG
            switch(numList.Count)
            {
                case 3:
                    Trace.WriteLine("[" + numList[0] + "][" + numList[1] + "][" + numList[2] + "]");
                    break;
                case 4:
                    Trace.WriteLine("[" + numList[0] + "][" + numList[1] + "][" + numList[2] + "][" + numList[3] + "]");
                    break;
                case 5:
                    Trace.WriteLine("[" + numList[0] + "][" + numList[1] + "][" + numList[2] + "][" + numList[3] + "][" + numList[4] + "]");
                    break;
                case 6:
                    Trace.WriteLine("[" + numList[0] + "][" + numList[1] + "][" + numList[2] + "][" + numList[3] + "][" + numList[4] + "][" + numList[5] + "]");
                    break;
                default:
                    Trace.WriteLine("Subsets::Dump Error");
                    break;
            }
#endif
        }
    } /// public class Subsets
} /// namespace PowerBall