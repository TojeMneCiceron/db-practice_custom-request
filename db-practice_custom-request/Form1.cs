using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nstd
{
    enum SortOrder
    {
        Asc, Desc
    }

    public partial class Form1 : Form
    {
        string lastConditionJoint = "";

        List<Column> columns = new List<Column>();
        List<Condition> conditions = new List<Condition>();
        List<Column> columnsWithOrder = new List<Column>();
        List<string> orders = new List<string>();

        public Form1()
        {
            InitializeComponent();

            InitializeLvColumns();
            InitializeLvConditions();
            InitializeLv();

            InitializeCmb();
        }

        private void ClearLists()
        {
            columns.Clear();
            conditions.Clear();
            columnsWithOrder.Clear();
            orders.Clear();
        }

        public string GetSQL()
        {
            ClearLists();

            foreach (ColumnItem lvi in lvAdded.Items)
            {
                columns.Add(lvi.Value);
            }

            foreach (ListViewItem lvi in lvConditions.Items)
            {
                string joint = "";
                if (lvi.SubItems[3].Text == "И")
                    joint = "AND";
                else
                if (lvi.SubItems[3].Text == "ИЛИ")
                    joint = "OR";
                else
                    joint = "";

                var condition = new Condition((Column)lvi.SubItems[0].Tag, lvi.SubItems[1].Text, lvi.SubItems[2].Tag, joint);
                conditions.Add(condition);
            }

            foreach (ColumnItem lvi in lvOrd.Items)
            {
                columnsWithOrder.Add(lvi.Value);
                if (lvi.Order == SortOrder.Asc)
                    orders.Add("ASC");
                else
                    orders.Add("DESC");
            }

            return QueryGenerator.GenerateSQL(columns, conditions, columnsWithOrder, orders, Database.GetForeignKeys());
        }

        private NpgsqlCommand GetCommand()
        {
            ClearLists();

            foreach (ColumnItem lvi in lvAdded.Items)
            {
                columns.Add(lvi.Value);
            }

            foreach (ListViewItem lvi in lvConditions.Items)
            {
                string joint = "";
                if (lvi.SubItems[3].Text == "И")
                    joint = "AND";
                else
                if (lvi.SubItems[3].Text == "ИЛИ")
                    joint = "OR";
                else
                    joint = "";

                var condition = new Condition((Column)lvi.SubItems[0].Tag, lvi.SubItems[1].Text, lvi.SubItems[2].Tag, joint);
                conditions.Add(condition);
            }

            foreach (ColumnItem lvi in lvOrd.Items)
            {
                columnsWithOrder.Add(lvi.Value);
                if (lvi.Order == SortOrder.Asc)
                    orders.Add("ASC");
                else
                    orders.Add("DESC");
            }

            return QueryGenerator.GenerateCommand(columns, conditions, columnsWithOrder, orders, Database.GetForeignKeys());
        }

        private void InitializeCmb()
        {
            cmbJoint.Items.Add("И");
            cmbJoint.Items.Add("ИЛИ");

            cmbOrd.Items.Add("Возрастающий");
            cmbOrd.Items.Add("Убывающий");

            exprCmbDouble.Items.Add(true);
            exprCmbDouble.Items.Add(false);
        }

        private void InitializeLv()
        {
            lvAdded.Columns.Add("Выбранные поля");
            lvAdded.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lvNoOrd.Columns.Add("Выбранные поля");
            lvNoOrd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lvOrd.Columns.Add("Последовательность сортировки");
            lvOrd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void InitializeLvColumns()
        {
            lvColumns.Columns.Add("Все поля");
            foreach (var col in Database.AllColumns())
            {
                lvColumns.Items.Add(new ColumnItem(col));
            }

            lvColumns.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvColumns.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void InitializeLvConditions()
        {
            lvConditions.Columns.Add("Имя поля");
            lvConditions.Columns.Add("Критерий");
            lvConditions.Columns.Add("Выражение");
            lvConditions.Columns.Add("Связка");
            lvConditions.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        class ColumnItem : ListViewItem
        {
            public ColumnItem(Column value, SortOrder order = SortOrder.Asc)
            {
                Value = value;
                Order = order;
                Text = Value.Alias;
                Name = Value.Alias;
            }

            public Column Value { get; }

            public SortOrder Order { get; set; }

            public override string ToString()
            {
                return Value.Alias;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem col in lvColumns.SelectedItems)
            {
                lvColumns.Items.Remove(col);
                lvAdded.Items.Add(col);
            }
        }

        private void bAddAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem col in lvColumns.Items)
            {
                lvColumns.Items.Remove(col);
                lvAdded.Items.Add(col);
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem col in lvAdded.SelectedItems)
            {
                lvAdded.Items.Remove(col);
                lvColumns.Items.Add(col);
            }
        }

        private void bRemoveAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem col in lvAdded.Items)
            {
                lvAdded.Items.Remove(col);
                lvColumns.Items.Add(col);
            }
        }

        private void bAddOrd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem col in lvNoOrd.SelectedItems)
            {
                lvNoOrd.Items.Remove(col);
                lvOrd.Items.Add(col);
            }
        }

        private void bAddOrdAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem col in lvNoOrd.Items)
            {
                lvNoOrd.Items.Remove(col);
                lvOrd.Items.Add(col);
            }
        }

        private void bRemoveOrd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem col in lvOrd.SelectedItems)
            {
                lvOrd.Items.Remove(col);
                lvNoOrd.Items.Add(col);
            }
        }

        private void bRemoveOrdAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem col in lvOrd.Items)
            {
                lvOrd.Items.Remove(col);
                lvNoOrd.Items.Add(col);
            }
        }

        private void tbC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbC.SelectedIndex)
            {
                case 1 : cmbColumns.DataSource = Database.AllColumns(); break;
                case 2 :
                    lvNoOrd.Items.Clear();
                    foreach (ColumnItem lvi in lvAdded.Items)
                    {
                        ColumnItem copy = new ColumnItem(lvi.Value);
                        lvNoOrd.Items.Add(copy);
                    }                    
                    break;
            }
        }

        private bool FindCondition(Column col)
        {
            bool flag = false;
            foreach (ListViewItem lvi in lvConditions.Items)
            {
                if (lvi.SubItems[0].Tag == col)
                    flag = true;
            }
            return flag;
        }

        private void bAddCondition_Click(object sender, EventArgs e)
        {

            if (cmbCrit.SelectedItem is null)
            {
                MessageBox.Show("Выберите критерий");
                return;
            }
            if (cmbJoint.SelectedItem is null)
            {
                MessageBox.Show("Выберите связку");
                return;
            }

            object expr = null;
            if (exprCmbString.Visible)
            {
                string text = EditAndHash.DeleteExtraSpaces(exprCmbString.Text);
                if (text == "")
                {
                    MessageBox.Show("Введите/выберите значение выражения");
                    return;
                }
                expr = text;
            }
            else
            if (exprCmbDouble.Visible)
            {
                if (exprCmbDouble.SelectedItem is null)
                {
                    MessageBox.Show("Выберите значение выражения");
                    return;
                }
                expr = exprCmbDouble.SelectedItem;
            }
            else
            if (exprDtp.Visible)
                expr = exprDtp.Value.Date;
            else
            if (exprNumUD.Visible)
                expr = exprNumUD.Value;
            else
            if (exprTb.Visible)
            {
                if (((Column)cmbColumns.SelectedItem).Type == "double precision")
                {
                    double dnum = 0;
                    if (double.TryParse(exprTb.Text, out dnum))
                        expr = dnum;
                    else
                        MessageBox.Show("Введите число");
                }
                else
                    expr = exprTb.Text;
            }

            if (FindCondition((Column)cmbColumns.SelectedItem))
            {
                MessageBox.Show("Условие для поля уже существует");
                return;
            }

            ListViewItem lvi = new ListViewItem(new[]
            {
                ((Column)cmbColumns.SelectedItem).ToString(),
                (string) cmbCrit.SelectedItem,
                expr.ToString(),
                ""
            });

            lvi.SubItems[0].Tag = cmbColumns.SelectedItem;
            lvi.SubItems[2].Tag = expr;

            if (lvConditions.Items.Count > 0)
                lvConditions.Items[lvConditions.Items.Count - 1].SubItems[3].Text = lastConditionJoint;

            lastConditionJoint = (string)cmbJoint.SelectedItem;
            lvConditions.Items.Add(lvi);
        }

        private void bDeleteCondition_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem condition in lvConditions.SelectedItems)
            {
                lvConditions.Items.Remove(condition);
            }
        }

        private void просмотрSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetSQL(), "Результат запроса", MessageBoxButtons.OK);
        }

        private void выполнитьЗапросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (columns.Count == 0)
            //{
            //    MessageBox.Show("Не было выбрано ни одного поля");
            //    return;
            //}

            Database.Result(ref dgvResult, GetCommand(), columns);

            tbC.SelectedIndex = 3;
        }

        private void lvOrd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvOrd.SelectedItems.Count > 0)
            {
                cmbOrd.SelectedIndex = (int)((ColumnItem)lvOrd.SelectedItems[0]).Order;
            }
            else
                cmbOrd.SelectedItem = null;
        }

        private void cmbOrd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrd.SelectedItem is null)
                return;
            if (lvOrd.SelectedItems.Count == 0)
                return;
            foreach (ColumnItem lvi in lvOrd.SelectedItems)
            {
                lvi.Order = (SortOrder)cmbOrd.SelectedIndex;
            }
        }

        private void cmbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColumns.SelectedItem is null)
                return;
            Column col = (Column)cmbColumns.SelectedItem;

            exprDtp.Visible = col.Type == "date";
            exprCmbDouble.Visible = col.Type == "boolean";
            exprNumUD.Visible = col.Type == "integer";
            exprTb.Visible = col.Type == "double precision";
            exprCmbString.Visible = col.Type == "text" || col.Type == "character varying";

            if (exprCmbString.Visible && !(col.Values is null))
            {
                exprCmbString.DataSource = col.Values;
            }

            cmbCrit.Items.Clear();

            cmbCrit.Items.Add("=");
            cmbCrit.Items.Add("<>");
            if (col.Type == "boolean")
                return;
            if (col.Type == "text" || col.Type == "character varying")
            {
                cmbCrit.Items.Add("LIKE");
                cmbCrit.Items.Add("NOT LIKE");
                return;
            }
            cmbCrit.Items.Add(">");
            cmbCrit.Items.Add("<");
            cmbCrit.Items.Add(">=");
            cmbCrit.Items.Add("<=");
        }
    }
}
