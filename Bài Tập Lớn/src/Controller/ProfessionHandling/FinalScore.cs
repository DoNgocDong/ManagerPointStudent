using BaiTapLon_CSharp.src.Models;
using BaiTapLon_CSharp.src.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_CSharp.src.Controller.ProfessionHandling
{
    public class FinalScore
    {        
        public FinalScore() {}

        public double getDiemTK_1Mon(Dictionary<string, object> listScore)
        {
            double diemGK = 00.00;
            double diemCK = 00.00;
            double diemTP = 00.00;

            foreach (var score in listScore) {
                if (score.Key == "diemCK")
                    diemCK += Convert.ToSingle(score.Value) * 0.7;
                else if (score.Key == "diemGK")
                    diemGK += Convert.ToSingle(score.Value) * 0.2;
                else
                    diemTP += Convert.ToSingle(score.Value);
            }
            diemTP = (diemTP / 2.0) * 0.1;

            double data = diemCK + diemGK + diemTP;

            return data;
        }

        public string getDiemChu(double diemTK)
        {
            if (diemTK >= 8.5)
                return DiemChu.getFieldName(DiemChu.A);
            else if(diemTK >= 8.0)
                return DiemChu.getFieldName(DiemChu.B_plus);
            else if (diemTK >= 7.0)
                return DiemChu.getFieldName(DiemChu.B);
            else if (diemTK >= 6.5)
                return DiemChu.getFieldName(DiemChu.C_plus);
            else if (diemTK >= 5.5)
                return DiemChu.getFieldName(DiemChu.C);
            else if (diemTK >= 5.0)
                return DiemChu.getFieldName(DiemChu.D_plus);
            else if (diemTK >= 4.0)
                return DiemChu.getFieldName(DiemChu.D);
            else
                return DiemChu.getFieldName(DiemChu.F);
        }

        public string getDanhGia(string diemChu)
        {
            if (diemChu == "F")
                return DanhGia.getFieldName(DanhGia.KHONG_DAT);
            else
                return DanhGia.getFieldName(DanhGia.DAT);
        }
    }
}
