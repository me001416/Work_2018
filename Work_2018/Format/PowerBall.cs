using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_2018.Format
{
    class PowerBall
    {
        /// <summary>
        /// 格式化字串
        /// </summary>
        /// <param name="SrcDsList"></param>
        /// <returns></returns>
        public string FormatFileData(List<StringBuilder> SrcSbList)
        {
            StringBuilder mStringBuilder = new StringBuilder();

            mStringBuilder.Append(@"{""PowerBall"":[");

            ///
            /// 分行，方便驗證結果
            ///
            mStringBuilder.Append("\n");

                for (var i = 0; i < SrcSbList.Count; i++)
                {
                    if (SrcSbList.Count < 2)
                    {
                        continue;
                    }

                    if (i == 0)
                    {
                        mStringBuilder.Append(@"{""id"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 1)
                    {
                        mStringBuilder.Append(@"""Name"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 2)
                    {
                        mStringBuilder.Append(@"""Type"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 3)
                    {
                        mStringBuilder.Append(@"""Kit"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 4)
                    {
                        mStringBuilder.Append(@"""Icon"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 5)
                    {
                        mStringBuilder.Append(@"""Tip"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 6)
                    {
                        mStringBuilder.Append(@"""Buy"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 7)
                    {
                        mStringBuilder.Append(@"""Sell"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 8)
                    {
                        mStringBuilder.Append(@"""Unknow_01"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else if (i == 9)
                    {
                        mStringBuilder.Append(@"""Unknow_01"":""");
                        mStringBuilder.Append(SrcSbList[i]);
                        mStringBuilder.Append(@""",");
                    }
                    else
                    {
                        mStringBuilder.Append(SrcSbList[i]);
                    }
            }
        }
    }
}
