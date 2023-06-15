using BaiTapLon_CSharp.src.Controller.Forms;
using BaiTapLon_CSharp.src.Models;
using System;
using System.Data;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel.Application;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Tools
{
    public partial class SchoolarShipList : Form
    {
        FormController formController = new FormController();
        public SchoolarShipList()
        {
            InitializeComponent();
        }

        private bool xuat(DataGridView displaySchoolarShipListDgv, string duongdan, string tentap)
        {
            excel obj = new excel();
            try
            {
                int countdgv1 = displaySchoolarShipListDgv.Rows.Count;

                obj.Application.Workbooks.Add(Type.Missing);
                obj.Columns.ColumnWidth = 25;
                for (int i = 1; i < displaySchoolarShipListDgv.Columns.Count + 1; i++)
                { obj.Cells[1, i] = displaySchoolarShipListDgv.Columns[i - 1].HeaderText; }
                for (int i = 0; i < displaySchoolarShipListDgv.Rows.Count; i++)
                {
                    for (int j = 0; j < displaySchoolarShipListDgv.Columns.Count; j++)
                    {
                        if (displaySchoolarShipListDgv.Rows[i].Cells[j].Value != null)
                        { obj.Cells[i + 2, j + 1] = displaySchoolarShipListDgv.Rows[i].Cells[j].Value.ToString(); }
                    }
                }
                obj.ActiveWorkbook.SaveCopyAs(duongdan + tentap + ".xlsx");
                obj.ActiveWorkbook.Saved = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void bxuat_Click(object sender, EventArgs e)
        {
            if (xuat(displaySchoolarShipListDgv, @"D:\", "xuatfileExcel"))
                MessageBox.Show("Xuất thành công");
            else MessageBox.Show("Xuất thất bại");
        }

        private void filterTxt_Click(object sender, EventArgs e)
        {
            if (isNumber(sizeTxt.Text))
            {
                int size = Convert.ToInt32(sizeTxt.Text);
                DataTable data = formController.topList(size, Globals.tableReviews, ModelReviews.getFieldName(ModelReviews.diemTK));
                displaySchoolarShipListDgv.DataSource = data;
                displaySchoolarShipListDgv.Refresh();
            }
            else
                MessageBox.Show("Phải nhập 1 số nguyên để lọc!");
        }

        public bool isNumber(string input)
        {
            int intValue;
            bool isInt = int.TryParse(input, out intValue);

            return isInt;
        }
    }
}
