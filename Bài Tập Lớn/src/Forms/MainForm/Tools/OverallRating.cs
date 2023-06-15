using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Controller.ProfessionHandling;
using BaiTapLon_CSharp.src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Tools
{
    public partial class OverallRating : Form
    {
        FormController formController = new FormController();
        FinalScore professionHandle = new FinalScore();
        public OverallRating()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            formController.load_DataGridViewforAll(displayReviewsDgv, Globals.tableReviews);
        }

        private void OverallRating_Load(object sender, EventArgs e)
        {
            cbbMasv.Enabled = false;
            formController.load_ComboBox(cbbLop, Globals.tableClass, "tenLop", "maLop");
            loadDgv();
        }

        private void cbbLop_TextChanged(object sender, EventArgs e)
        {
            cbbMasv.Enabled = true;
            noteMsvLabel.Visible = false;

            string tenLop = cbbLop.Text.Trim();
            string condition = $"tenLop = '{tenLop}'";

            List<string> conditions = new List<string> { condition };

            formController.load_ComboBox(cbbMasv, Globals.tableStudent, "maSinhVien", "hoTen", conditions);
        }

        private void reviewsBtn_Click(object sender, EventArgs e)
        {
            string condition1 = $"maSinhVien = '{cbbMasv.Text}'";
            string condition2 = $"hocKy = {cbhocki.Text}";

            List<string> listCondition = new List<string> { 
                condition1,
                condition2
            };

            DataTable data = formController.find(Globals.tableScore, "diemTK", listCondition);

            if(data != null && data.Rows.Count > 0)
            {
                List<float> listScore = new List<float>();
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    listScore.Add(Convert.ToSingle(data.Rows[i][0]));
                }

                if(handleReviews(listScore))
                    MessageBox.Show("Thành công!!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Không ổn :))", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                loadDgv();
            }
            else
            {
                MessageBox.Show("Không có thông tin để đánh giá!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool handleReviews(List<float> listScore)
        {
            float diemTK = professionHandle.getDiemTK_list(listScore);
            string diemChu = professionHandle.getDiemChu(diemTK);
            string danhGia = professionHandle.getDanhGia(diemChu);

            List<object> values = new List<object> { 
                cbbMasv.Text,
                diemTK,
                diemChu,
                danhGia,
                cbhocki.Text
            };

            Dictionary<string, object> columnValues = new Dictionary<string, object>();

            for (int i = 1; i <= values.Count; i++)
            {
                columnValues.Add(ModelReviews.getFieldName(i), values[i-1]);
            }

            return formController.create(Globals.tableReviews, columnValues);
        }

        private void cbbMasv_TextChanged(object sender, EventArgs e)
        {
            txthoten.Text = cbbMasv.SelectedValue.ToString();
        }
    }
}
