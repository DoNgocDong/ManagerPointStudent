using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BaiTapLon_CSharp.src.Models
{
    public static class ModelMajors
    {
        public const int maNganh = 0;
        public const int tenNganh = 1;

        public static string getFieldName(int index)
        {
            switch (index)
            {
                case maNganh:
                    return "maNganh";
                case tenNganh:
                    return "tenNganh";
                default:
                    throw new ArgumentException("Invalid field index value!");
            }
        }
    }
}
