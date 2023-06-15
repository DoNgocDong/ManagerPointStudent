using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel.Application;

namespace BaiTapLon_CSharp.src.Forms.MainForm.Tools
{
    public partial class SchoolarShipList : Form
    {
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
    }
}
