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

            int Index = 0;

            for (var i = 0; i < SrcSbList.Count; i++)
            {
                if (!char.IsNumber(SrcSbList[i].ToString().ToCharArray()[0]))
                {
                    Index = 0;
                }
                else if (Index == 0)
                {
                    mStringBuilder.Append(@"{""Num1"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 1)
                {
                    mStringBuilder.Append(@"""Num2"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 2)
                {
                    mStringBuilder.Append(@"""Num3"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 3)
                {
                    mStringBuilder.Append(@"""Num4"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 4)
                {
                    mStringBuilder.Append(@"""Num5"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 5)
                {
                    mStringBuilder.Append(@"""Num6"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 6)
                {
                    mStringBuilder.Append(@"""Num7"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 7)
                {
                    mStringBuilder.Append(@"""M"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 8)
                {
                    mStringBuilder.Append(@"""D"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@""",");
                }
                else if (Index == 9)
                {
                    mStringBuilder.Append(@"""Y"":""");
                    mStringBuilder.Append(SrcSbList[i]);
                    mStringBuilder.Append(@"""},");

                    ///
                    /// 分行，方便驗證結果
                    ///
                    mStringBuilder.Append("\n");
                }
                else
                {
                    mStringBuilder.Append(SrcSbList[i]);
                }

                if ((Index == 9) || (!char.IsNumber(SrcSbList[i].ToString().ToCharArray()[0])))
                {
                    Index = 0;
                }
                else
                {
                    Index++;
                }
            }

            mStringBuilder.Remove(mStringBuilder.Length - 2, 1);
            mStringBuilder.Append("]}");

            return mStringBuilder.ToString();
        }
    }
}
