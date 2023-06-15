using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Models.Reviews
{
    public static class DiemChu
    {
        public const int A = 0;
        public const int B = 1;
        public const int B_plus = 2;
        public const int C = 3;
        public const int C_plus = 4;
        public const int D = 5;
        public const int D_plus = 6;
        public const int F = 7;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case A:
                    return "A";
                case B:
                    return "B";
                case B_plus:
                    return "B+";
                case C:
                    return "C";
                case C_plus:
                    return "C+";
                case D:
                    return "D";
                case D_plus:
                    return "D+";
                case F:
                    return "F";
                default:
                    throw new ArgumentException("Invalid field index value!");
            }
        }
    }
}
