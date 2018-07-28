#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerBall;
using System.Diagnostics;
using PowerBall.Subsets;

namespace Combination
{
    public class Compare
    {
        public void Between(BasePowerBall Target, BasePowerBall Src)
        {
            bool M3 = false;
            bool M4 = false;
            bool M5 = false;
            bool M6 = false;

            if (!_Check(Target) || !_Check(Src))
            {
                return;
            }

            Target.mSubsetsList.mSubsetsList.ForEach(x =>
            {
                Src.mSubsetsList.mSubsetsList.ForEach(y =>
                {
                    switch (x.Length())
                    {
                        case 3:
                            if (y.Length() != 3)
                            {
                                goto default;
                            }
                            M3 = _CompareElement(x, y);
                            break;
                        case 4:
                            if (y.Length() != 4)
                            {
                                goto default;
                            }
                            M4 = _CompareElement(x, y);
                            break;
                        case 5:
                            if (y.Length() != 5)
                            {
                                goto default;
                            }
                            M5 = _CompareElement(x, y);
                            break;
                        case 6:
                            if (y.Length() != 6)
                            {
                                goto default;
                            }
                            M6 = _CompareElement(x, y);
                            break;

                        default:
                            break;
                    }                    
                });
            });
        }

        bool _CompareElement(Subsets Src1, Subsets Src2)
        {
            if (Src1.numList[0] != Src2.numList[0])
            {
                return false;
            }

            if (Src1.numList[1] != Src2.numList[1])
            {
                return false;
            }

            if (Src1.numList[2] != Src2.numList[2])
            {
                return false;
            }

            if ((Src1.Length() == 3) && (Src2.Length() == 3))
            {
                return true;
            }

            if (Src1.numList[3] != Src2.numList[3])
            {
                return false;
            }

            if ((Src1.Length() == 4) && (Src2.Length() == 4))
            {
                return true;
            }

            if (Src1.numList[4] != Src2.numList[4])
            {
                return false;
            }

            if ((Src1.Length() == 5) && (Src2.Length() == 5))
            {
                return true;
            }

            if (Src1.numList[5] != Src2.numList[5])
            {
                return false;
            }

            if ((Src1.Length() == 6) && (Src2.Length() == 6))
            {
                return true;
            }

            return false;
        }

        bool _Check(BasePowerBall Src)
        {
            if (Src == null)
            {
                Trace.WriteLine(DateTime.Now + "Error : Src == null");
                return false;
            }

            if (Src.mSubsetsList.Count() == 0)
            {
                Trace.WriteLine(DateTime.Now + "Error : Src.mSubsetsList.Count() == 0");
                return false;
            }

            return true;
        }
    }
}
