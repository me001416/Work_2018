using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    /// <summary>
    /// Create Random number.
    /// </summary>
    public class RandomNum
    {
        Random mRandom;

        /// <summary>
        /// 建構函數
        /// </summary>
        public RandomNum()
        {
            mRandom = new Random(Guid.NewGuid().GetHashCode());
        }

        public List<byte> GetRandomNumList(int MaxNum, int Size)
        {
            List<byte> NumList = new List<byte>();
            byte num;

            for (int i = 0; i < Size; i++)
            {
                num = (byte)mRandom.Next(0, MaxNum);
                if (!IsPresent(num, NumList))
                {
                    NumList.Add(num);
                }
                else
                {
                    if (i != 0)
                    {
                        i--;
                    }
                }
            }

            return NumList;
        }

        bool IsPresent(byte Num, List<byte> NumList)
        {
            if (NumList.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < NumList.Count; i++)
            {
                if (NumList[i] == Num)
                {
                    return true;
                }
            }

            return false;
        }

        public List<int> GetRandomNumList_Int(int MaxNum, int Size)
        {
            List<int> NumList = new List<int>();
            int num;

            for (int i = 0; i < Size; i++)
            {
                num = mRandom.Next(0, MaxNum);
                if (!IsPresent(num, NumList))
                {
                    NumList.Add(num);
                }
                else
                {
                    if (i != 0)
                    {
                        i--;
                    }
                }
            }

            return NumList;
        }

        bool IsPresent(int Num, List<int> NumList)
        {
            if (NumList.Count == 0)
            {
                return false;
            }

            for (int i = 0; i < NumList.Count; i++)
            {
                if (NumList[i] == Num)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
