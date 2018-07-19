using System.Collections.Generic;

namespace Work_2018.Combination
{
    /// <summary>
    /// Combination functions.
    /// </summary>
    public class Generate
    {
        /// <summary>
        /// 產生所有 Combination 並回傳
        /// </summary>
        /// <param name="SrcList">資料來源</param>
        /// <param name="k">深度，x 個數字中取 k </param>
        /// <returns>回傳所有 Combination</returns>
        public List<List<int>> NewCombine(List<int> SrcList, int k)
        {
            List<List<int>> mResultList = new List<List<int>>();

            if (SrcList.Count != 0 && k != 0 && SrcList.Count >= k)
            {
                List<int> mTempList = new List<int>();
                doCombin(0, SrcList.Count, k, mResultList, mTempList, SrcList);
            }

            return mResultList;
        }

        /// <summary>
        /// 計算 Combination
        /// </summary>
        /// <param name="start">起始次數</param>
        /// <param name="end">最大次數</param>
        /// <param name="deep">深度</param>
        /// <param name="mResultList">結果</param>
        /// <param name="mTempList">暫存用</param>
        /// <param name="mSrcList">資料來源</param>
        public void doCombin(int start, int end, int deep, List<List<int>> mResultList, List<int> mTempList, List<int> mSrcList)
        {
            for (int i = start; i < end; i++)
            {
                if (end - i + 1 < deep)
                {
                    return;
                }

                mTempList.Add(mSrcList[i]);

                if (deep - 1 == 0)
                {
                    mResultList.Add(new List<int>(mTempList));
                    mTempList.RemoveAt(mTempList.Count - 1);
                }
                else
                {
                    doCombin(i + 1, end, deep - 1, mResultList, mTempList, mSrcList);
                    mTempList.RemoveAt(mTempList.Count - 1);
                }
            }
        }
    }
}