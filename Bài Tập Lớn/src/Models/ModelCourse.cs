using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaiTapLon_CSharp.src.Models
{
    public static class ModelCourse
    {
        public const int maMon = 0;
        public const int tenMon = 1;
        public const int soTinChi = 2;
        public const int hocKy = 3;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case maMon:
                    return "maMon";
                case tenMon:
                    return "tenMon";
                case soTinChi:
                    return "soTinChi";
                case hocKy:
                    return "hocKy";
                default:
                    throw new ArgumentException("Invalid field index value!");
            }
        }
    }
}
