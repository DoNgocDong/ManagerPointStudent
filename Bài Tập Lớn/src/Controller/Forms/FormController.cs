using BaiTapLon_CSharp.src.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Controller.Forms
{
    public class FormController
    {
        private static ConnectDB database = new ConnectDB();
        private static Services databaseQuery = new Services();

        private string connectString = database.getConnectionString();

        public void hideAndShow(Form hiddenForm, Form displayForm)
        {
            hiddenForm.Hide();
            displayForm.Show();
        }

        public void closeAndShow(Form closeForm, Form displayForm)
        {
            closeForm.Close();
            displayForm.Show();
        }

        public void showDialog(Form f)
        {
            f.ShowDialog();
        }

        public void show(Form f)
        {
            f.Show();
        }

        public void addForm(Form childForm, Panel placeShow)
        {
            childForm.TopLevel = false;
            childForm.AutoScroll = true;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            placeShow.Controls.Clear();
            placeShow.Controls.Add(childForm);
            childForm.Show();
        }
        
        public void load_DataGridViewforAll(DataGridView dgv, string tableName)
        {
            DataTable data = databaseQuery.findAll(tableName);
            dgv.DataSource = data;
            dgv.Refresh();
        }

        public void load_DataGridViewWithCondition(DataGridView dgv, string tableName, string fieldCondition, string keyword)
        {
            DataTable data = databaseQuery.find(tableName, "*", fieldCondition, keyword);
            dgv.DataSource = data;
            dgv.Refresh();
        }

        public void load_ComboBox(ComboBox cbBox, string tableName, string displayMemberColumn, string ValueMemberColumn)
        {
            DataTable data = databaseQuery.findAll(tableName);
            cbBox.DataSource = data;

            cbBox.DisplayMember = displayMemberColumn;
            cbBox.ValueMember = ValueMemberColumn;
        }

        public void create(string tableToCreate, Dictionary<string, object> columnValues)
        {
            try
            {
                databaseQuery.create(tableToCreate, columnValues);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete(string tableName, string fieldCondition, string keyword)
        {
            try{
                databaseQuery.delete(tableName, fieldCondition, keyword);
            }
            catch(Exception ex){
                DialogResult result = MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update(string tableNameToUpdate, Dictionary<string, object> columnValues, string condition)
        {
            try
            {
                databaseQuery.update(tableNameToUpdate, columnValues, condition);
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
