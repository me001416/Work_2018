using System;
using System.Collections.Generic;
using System.Text;

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
                if ((i == 0) || ((i % 11) == 0))
                {
                    mStringBuilder.Append(@"{""Num1"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 1) || ((i % 12) == 0))
                {
                    mStringBuilder.Append(@"""Num2"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 2) || ((i % 13) == 0))
                {
                    mStringBuilder.Append(@"""Num3"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 3) || ((i % 14) == 0))
                {
                    mStringBuilder.Append(@"""Num4"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 4) || ((i % 15) == 0))
                {
                    mStringBuilder.Append(@"""Num5"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 5) || ((i % 16) == 0))
                {
                    mStringBuilder.Append(@"""Num6"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 6) || ((i % 17) == 0))
                {
                    mStringBuilder.Append(@"""Num7"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 7) || ((i % 18) == 0))
                {
                    mStringBuilder.Append(@"""Month"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 8) || ((i % 19) == 0))
                {
                    mStringBuilder.Append(@"""Day"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if ((i == 9) || ((i % 10) == 0))
                {
                    mStringBuilder.Append(@"""Year"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@"""},");
                }
                else
                {
                    mStringBuilder.Append(SrcSbList[i]);
                }
            }

            return mStringBuilder.ToString();
        }
    }
}
