using BaiTapLon_CSharp.src.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BaiTapLon_CSharp.src.Controller.Forms
{
    public class FormController
    {
        private static Services databaseQuery = new Services();

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
            DataTable data = this.findAll(tableName);
            dgv.DataSource = data;
            dgv.Refresh();
        }

        public void load_DataGridViewWithCondition(DataGridView dgv, string tableName, string fieldCondition, string keyword)
        {
            DataTable data = this.find(tableName, "*", fieldCondition, keyword);
            dgv.DataSource = data;
            dgv.Refresh();
        }

        public void load_DataGridViewWithCondition(DataGridView dgv, string tableName, List<string> condition)
        {
            DataTable data = this.find(tableName, "*", condition);
            dgv.DataSource = data;
            dgv.Refresh();
        }

        public void load_ComboBox(ComboBox cbBox, string tableName, string displayMemberColumn, string ValueMemberColumn)
        {
            DataTable data = this.findAll(tableName);
            cbBox.DataSource = data;

            cbBox.DisplayMember = displayMemberColumn;
            cbBox.ValueMember = ValueMemberColumn;
        }

        public void load_ComboBox(ComboBox cbBox, string tableName, string displayMemberColumn, string ValueMemberColumn, List<string> condition)
        {
            DataTable data = this.find(tableName, "*", condition);
            cbBox.DataSource = data;

            cbBox.DisplayMember = displayMemberColumn;
            cbBox.ValueMember = ValueMemberColumn;
        }

        public DataTable find(string tableToFind, string getValue, List<string> condition)
        {
            return databaseQuery.find(tableToFind, getValue, condition);
        }

        public DataTable find(string tableToFind, string getValue, string fieldCondition, string keyword)
        {
            return databaseQuery.find(tableToFind, getValue, fieldCondition, keyword);
        }

        public DataTable find(string tableToFind, List<string> getValue, string fieldCondition, string keyword)
        {
            return databaseQuery.find(tableToFind, getValue, fieldCondition, keyword);
        }

        public DataTable findAll(string tableToFind)
        {
            return databaseQuery.findAll(tableToFind);
        }

        public bool create(string tableToCreate, Dictionary<string, object> columnValues)
        {
            return databaseQuery.create(tableToCreate, columnValues);
        }

        public bool update(string tableNameToUpdate, Dictionary<string, object> columnValues, string condition)
        {
            return databaseQuery.update(tableNameToUpdate, columnValues, condition);
        }

        public bool delete(string tableName, string fieldCondition, string keyword)
        {
            return databaseQuery.delete(tableName, fieldCondition, keyword);
        }

        public int count(string tableToCount, string fieldCondition, string keyword)
        {
            return databaseQuery.count(tableToCount, fieldCondition, keyword);
        }

        public DataTable topList(int size, string tableName, string compareField)
        {
            return databaseQuery.topList(size, tableName, compareField);
        }

        public bool checkExistValueInDatabase(string keyword, string compareFieldName, string compareTableName)
        {
            return databaseQuery.checkExistValueInDatabase(keyword, compareFieldName, compareTableName);
        }
    }
}
