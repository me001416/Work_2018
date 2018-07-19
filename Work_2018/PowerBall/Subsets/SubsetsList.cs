using System.Collections.Generic;

namespace PowerBall
{
    public class SubsetsList
    {
        public List<Subsets> mSubsetsList { get; private set; }
        //public List<IntervalRecord> mIntervalRecordList { get; private set; }

        /// <summary>
        /// 建構函數
        /// </summary>
        public SubsetsList()
        {
            mSubsetsList = new List<Subsets>();
        }

        /// <summary>
        /// mSubsetsList 的數量
        /// </summary>
        public int Count()
        {
            return mSubsetsList.Count;
        }

        /// <summary>
        /// 資料數量，Ex:[1][2][3] = 3
        /// </summary>
        public int FirstLength()
        {
            return mSubsetsList[0].Length();
        }

        /// <summary>
        /// 將 class Subsets 加入 mSubsetsList
        /// </summary>
        public void Add(Subsets SrcSubsets)
        {
            mSubsetsList.Add(SrcSubsets);
        }
    } /// public class SubsetsList
} /// namespace PowerBall