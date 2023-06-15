using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Models.Reviews
{
    public static class DanhGia
    {
        public const int DAT = 0;
        public const int KHONG_DAT = 1;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case DAT:
                    return "DAT";
                case KHONG_DAT:
                    return "KHONG DAT";
                default:
                    throw new ArgumentException("Invalid field index value!");
            }
        }
    }
}
