namespace nstd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbC = new System.Windows.Forms.TabControl();
            this.tpColumns = new System.Windows.Forms.TabPage();
            this.bRemoveAll = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bAddAll = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lvAdded = new System.Windows.Forms.ListView();
            this.lvColumns = new System.Windows.Forms.ListView();
            this.tpConditions = new System.Windows.Forms.TabPage();
            this.exprCmbDouble = new System.Windows.Forms.ComboBox();
            this.exprTb = new System.Windows.Forms.TextBox();
            this.exprNumUD = new System.Windows.Forms.NumericUpDown();
            this.exprDtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bDeleteCondition = new System.Windows.Forms.Button();
            this.bAddCondition = new System.Windows.Forms.Button();
            this.cmbJoint = new System.Windows.Forms.ComboBox();
            this.cmbCrit = new System.Windows.Forms.ComboBox();
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.lvConditions = new System.Windows.Forms.ListView();
            this.tpOrder = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOrd = new System.Windows.Forms.ComboBox();
            this.lvOrd = new System.Windows.Forms.ListView();
            this.bRemoveOrdAll = new System.Windows.Forms.Button();
            this.bRemoveOrd = new System.Windows.Forms.Button();
            this.bAddOrdAll = new System.Windows.Forms.Button();
            this.bAddOrd = new System.Windows.Forms.Button();
            this.lvNoOrd = new System.Windows.Forms.ListView();
            this.tpRes = new System.Windows.Forms.TabPage();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выполнитьЗапросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exprCmbString = new System.Windows.Forms.ComboBox();
            this.tbC.SuspendLayout();
            this.tpColumns.SuspendLayout();
            this.tpConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exprNumUD)).BeginInit();
            this.tpOrder.SuspendLayout();
            this.tpRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbC
            // 
            this.tbC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbC.Controls.Add(this.tpColumns);
            this.tbC.Controls.Add(this.tpConditions);
            this.tbC.Controls.Add(this.tpOrder);
            this.tbC.Controls.Add(this.tpRes);
            this.tbC.Location = new System.Drawing.Point(12, 27);
            this.tbC.Name = "tbC";
            this.tbC.SelectedIndex = 0;
            this.tbC.Size = new System.Drawing.Size(520, 317);
            this.tbC.TabIndex = 0;
            this.tbC.SelectedIndexChanged += new System.EventHandler(this.tbC_SelectedIndexChanged);
            // 
            // tpColumns
            // 
            this.tpColumns.Controls.Add(this.bRemoveAll);
            this.tpColumns.Controls.Add(this.bRemove);
            this.tpColumns.Controls.Add(this.bAddAll);
            this.tpColumns.Controls.Add(this.bAdd);
            this.tpColumns.Controls.Add(this.lvAdded);
            this.tpColumns.Controls.Add(this.lvColumns);
            this.tpColumns.Location = new System.Drawing.Point(4, 22);
            this.tpColumns.Name = "tpColumns";
            this.tpColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tpColumns.Size = new System.Drawing.Size(512, 291);
            this.tpColumns.TabIndex = 0;
            this.tpColumns.Text = "Поля";
            this.tpColumns.UseVisualStyleBackColor = true;
            // 
            // bRemoveAll
            // 
            this.bRemoveAll.Location = new System.Drawing.Point(219, 177);
            this.bRemoveAll.Name = "bRemoveAll";
            this.bRemoveAll.Size = new System.Drawing.Size(75, 23);
            this.bRemoveAll.TabIndex = 5;
            this.bRemoveAll.Text = "<<";
            this.bRemoveAll.UseVisualStyleBackColor = true;
            this.bRemoveAll.Click += new System.EventHandler(this.bRemoveAll_Click);
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(219, 148);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 4;
            this.bRemove.Text = "<";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bAddAll
            // 
            this.bAddAll.Location = new System.Drawing.Point(219, 119);
            this.bAddAll.Name = "bAddAll";
            this.bAddAll.Size = new System.Drawing.Size(75, 23);
            this.bAddAll.TabIndex = 3;
            this.bAddAll.Text = ">>";
            this.bAddAll.UseVisualStyleBackColor = true;
            this.bAddAll.Click += new System.EventHandler(this.bAddAll_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(219, 90);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = ">";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lvAdded
            // 
            this.lvAdded.FullRowSelect = true;
            this.lvAdded.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAdded.HideSelection = false;
            this.lvAdded.Location = new System.Drawing.Point(300, 0);
            this.lvAdded.Name = "lvAdded";
            this.lvAdded.Size = new System.Drawing.Size(212, 291);
            this.lvAdded.TabIndex = 1;
            this.lvAdded.UseCompatibleStateImageBehavior = false;
            this.lvAdded.View = System.Windows.Forms.View.Details;
            // 
            // lvColumns
            // 
            this.lvColumns.FullRowSelect = true;
            this.lvColumns.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvColumns.HideSelection = false;
            this.lvColumns.Location = new System.Drawing.Point(0, 0);
            this.lvColumns.Name = "lvColumns";
            this.lvColumns.Size = new System.Drawing.Size(212, 291);
            this.lvColumns.TabIndex = 0;
            this.lvColumns.UseCompatibleStateImageBehavior = false;
            this.lvColumns.View = System.Windows.Forms.View.Details;
            // 
            // tpConditions
            // 
            this.tpConditions.Controls.Add(this.exprCmbString);
            this.tpConditions.Controls.Add(this.exprCmbDouble);
            this.tpConditions.Controls.Add(this.exprTb);
            this.tpConditions.Controls.Add(this.exprNumUD);
            this.tpConditions.Controls.Add(this.exprDtp);
            this.tpConditions.Controls.Add(this.label4);
            this.tpConditions.Controls.Add(this.label3);
            this.tpConditions.Controls.Add(this.label2);
            this.tpConditions.Controls.Add(this.label1);
            this.tpConditions.Controls.Add(this.bDeleteCondition);
            this.tpConditions.Controls.Add(this.bAddCondition);
            this.tpConditions.Controls.Add(this.cmbJoint);
            this.tpConditions.Controls.Add(this.cmbCrit);
            this.tpConditions.Controls.Add(this.cmbColumns);
            this.tpConditions.Controls.Add(this.lvConditions);
            this.tpConditions.Location = new System.Drawing.Point(4, 22);
            this.tpConditions.Name = "tpConditions";
            this.tpConditions.Padding = new System.Windows.Forms.Padding(3);
            this.tpConditions.Size = new System.Drawing.Size(512, 291);
            this.tpConditions.TabIndex = 1;
            this.tpConditions.Text = "Условия";
            this.tpConditions.UseVisualStyleBackColor = true;
            // 
            // exprCmbDouble
            // 
            this.exprCmbDouble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exprCmbDouble.FormattingEnabled = true;
            this.exprCmbDouble.Location = new System.Drawing.Point(231, 227);
            this.exprCmbDouble.Name = "exprCmbDouble";
            this.exprCmbDouble.Size = new System.Drawing.Size(200, 21);
            this.exprCmbDouble.TabIndex = 14;
            // 
            // exprTb
            // 
            this.exprTb.Location = new System.Drawing.Point(231, 227);
            this.exprTb.Name = "exprTb";
            this.exprTb.Size = new System.Drawing.Size(200, 20);
            this.exprTb.TabIndex = 13;
            // 
            // exprNumUD
            // 
            this.exprNumUD.Location = new System.Drawing.Point(231, 227);
            this.exprNumUD.Name = "exprNumUD";
            this.exprNumUD.Size = new System.Drawing.Size(200, 20);
            this.exprNumUD.TabIndex = 12;
            // 
            // exprDtp
            // 
            this.exprDtp.Location = new System.Drawing.Point(231, 227);
            this.exprDtp.Name = "exprDtp";
            this.exprDtp.Size = new System.Drawing.Size(200, 20);
            this.exprDtp.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Связка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выражение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Критерий";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поля";
            // 
            // bDeleteCondition
            // 
            this.bDeleteCondition.Location = new System.Drawing.Point(431, 262);
            this.bDeleteCondition.Name = "bDeleteCondition";
            this.bDeleteCondition.Size = new System.Drawing.Size(75, 23);
            this.bDeleteCondition.TabIndex = 6;
            this.bDeleteCondition.Text = "Удалить";
            this.bDeleteCondition.UseVisualStyleBackColor = true;
            this.bDeleteCondition.Click += new System.EventHandler(this.bDeleteCondition_Click);
            // 
            // bAddCondition
            // 
            this.bAddCondition.Location = new System.Drawing.Point(350, 262);
            this.bAddCondition.Name = "bAddCondition";
            this.bAddCondition.Size = new System.Drawing.Size(75, 23);
            this.bAddCondition.TabIndex = 5;
            this.bAddCondition.Text = "Добавить";
            this.bAddCondition.UseVisualStyleBackColor = true;
            this.bAddCondition.Click += new System.EventHandler(this.bAddCondition_Click);
            // 
            // cmbJoint
            // 
            this.cmbJoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJoint.FormattingEnabled = true;
            this.cmbJoint.Location = new System.Drawing.Point(452, 227);
            this.cmbJoint.Name = "cmbJoint";
            this.cmbJoint.Size = new System.Drawing.Size(54, 21);
            this.cmbJoint.TabIndex = 3;
            // 
            // cmbCrit
            // 
            this.cmbCrit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrit.FormattingEnabled = true;
            this.cmbCrit.Location = new System.Drawing.Point(156, 227);
            this.cmbCrit.Name = "cmbCrit";
            this.cmbCrit.Size = new System.Drawing.Size(57, 21);
            this.cmbCrit.TabIndex = 2;
            // 
            // cmbColumns
            // 
            this.cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Location = new System.Drawing.Point(6, 227);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(128, 21);
            this.cmbColumns.TabIndex = 1;
            this.cmbColumns.SelectedIndexChanged += new System.EventHandler(this.cmbColumns_SelectedIndexChanged);
            // 
            // lvConditions
            // 
            this.lvConditions.FullRowSelect = true;
            this.lvConditions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvConditions.HideSelection = false;
            this.lvConditions.Location = new System.Drawing.Point(0, 0);
            this.lvConditions.Name = "lvConditions";
            this.lvConditions.Size = new System.Drawing.Size(510, 201);
            this.lvConditions.TabIndex = 0;
            this.lvConditions.UseCompatibleStateImageBehavior = false;
            this.lvConditions.View = System.Windows.Forms.View.Details;
            // 
            // tpOrder
            // 
            this.tpOrder.Controls.Add(this.label5);
            this.tpOrder.Controls.Add(this.cmbOrd);
            this.tpOrder.Controls.Add(this.lvOrd);
            this.tpOrder.Controls.Add(this.bRemoveOrdAll);
            this.tpOrder.Controls.Add(this.bRemoveOrd);
            this.tpOrder.Controls.Add(this.bAddOrdAll);
            this.tpOrder.Controls.Add(this.bAddOrd);
            this.tpOrder.Controls.Add(this.lvNoOrd);
            this.tpOrder.Location = new System.Drawing.Point(4, 22);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Size = new System.Drawing.Size(512, 291);
            this.tpOrder.TabIndex = 2;
            this.tpOrder.Text = "Порядок";
            this.tpOrder.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Порядок";
            // 
            // cmbOrd
            // 
            this.cmbOrd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrd.FormattingEnabled = true;
            this.cmbOrd.Location = new System.Drawing.Point(399, 135);
            this.cmbOrd.Name = "cmbOrd";
            this.cmbOrd.Size = new System.Drawing.Size(110, 21);
            this.cmbOrd.TabIndex = 11;
            this.cmbOrd.SelectedIndexChanged += new System.EventHandler(this.cmbOrd_SelectedIndexChanged);
            // 
            // lvOrd
            // 
            this.lvOrd.FullRowSelect = true;
            this.lvOrd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvOrd.HideSelection = false;
            this.lvOrd.Location = new System.Drawing.Point(233, 0);
            this.lvOrd.Name = "lvOrd";
            this.lvOrd.Size = new System.Drawing.Size(160, 291);
            this.lvOrd.TabIndex = 10;
            this.lvOrd.UseCompatibleStateImageBehavior = false;
            this.lvOrd.View = System.Windows.Forms.View.Details;
            this.lvOrd.SelectedIndexChanged += new System.EventHandler(this.lvOrd_SelectedIndexChanged);
            // 
            // bRemoveOrdAll
            // 
            this.bRemoveOrdAll.Location = new System.Drawing.Point(157, 177);
            this.bRemoveOrdAll.Name = "bRemoveOrdAll";
            this.bRemoveOrdAll.Size = new System.Drawing.Size(70, 23);
            this.bRemoveOrdAll.TabIndex = 9;
            this.bRemoveOrdAll.Text = "<<";
            this.bRemoveOrdAll.UseVisualStyleBackColor = true;
            this.bRemoveOrdAll.Click += new System.EventHandler(this.bRemoveOrdAll_Click);
            // 
            // bRemoveOrd
            // 
            this.bRemoveOrd.Location = new System.Drawing.Point(157, 148);
            this.bRemoveOrd.Name = "bRemoveOrd";
            this.bRemoveOrd.Size = new System.Drawing.Size(70, 23);
            this.bRemoveOrd.TabIndex = 8;
            this.bRemoveOrd.Text = "<";
            this.bRemoveOrd.UseVisualStyleBackColor = true;
            this.bRemoveOrd.Click += new System.EventHandler(this.bRemoveOrd_Click);
            // 
            // bAddOrdAll
            // 
            this.bAddOrdAll.Location = new System.Drawing.Point(157, 119);
            this.bAddOrdAll.Name = "bAddOrdAll";
            this.bAddOrdAll.Size = new System.Drawing.Size(70, 23);
            this.bAddOrdAll.TabIndex = 7;
            this.bAddOrdAll.Text = ">>";
            this.bAddOrdAll.UseVisualStyleBackColor = true;
            this.bAddOrdAll.Click += new System.EventHandler(this.bAddOrdAll_Click);
            // 
            // bAddOrd
            // 
            this.bAddOrd.Location = new System.Drawing.Point(157, 90);
            this.bAddOrd.Name = "bAddOrd";
            this.bAddOrd.Size = new System.Drawing.Size(70, 23);
            this.bAddOrd.TabIndex = 6;
            this.bAddOrd.Text = ">";
            this.bAddOrd.UseVisualStyleBackColor = true;
            this.bAddOrd.Click += new System.EventHandler(this.bAddOrd_Click);
            // 
            // lvNoOrd
            // 
            this.lvNoOrd.FullRowSelect = true;
            this.lvNoOrd.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvNoOrd.HideSelection = false;
            this.lvNoOrd.Location = new System.Drawing.Point(0, 0);
            this.lvNoOrd.Name = "lvNoOrd";
            this.lvNoOrd.Size = new System.Drawing.Size(151, 291);
            this.lvNoOrd.TabIndex = 0;
            this.lvNoOrd.UseCompatibleStateImageBehavior = false;
            this.lvNoOrd.View = System.Windows.Forms.View.Details;
            // 
            // tpRes
            // 
            this.tpRes.Controls.Add(this.dgvResult);
            this.tpRes.Location = new System.Drawing.Point(4, 22);
            this.tpRes.Name = "tpRes";
            this.tpRes.Size = new System.Drawing.Size(512, 291);
            this.tpRes.TabIndex = 3;
            this.tpRes.Text = "Результат";
            this.tpRes.UseVisualStyleBackColor = true;
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResult.Location = new System.Drawing.Point(0, 0);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.Size = new System.Drawing.Size(512, 291);
            this.dgvResult.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выполнитьЗапросToolStripMenuItem,
            this.просмотрSQLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выполнитьЗапросToolStripMenuItem
            // 
            this.выполнитьЗапросToolStripMenuItem.Name = "выполнитьЗапросToolStripMenuItem";
            this.выполнитьЗапросToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.выполнитьЗапросToolStripMenuItem.Text = "Выполнить запрос";
            this.выполнитьЗапросToolStripMenuItem.Click += new System.EventHandler(this.выполнитьЗапросToolStripMenuItem_Click);
            // 
            // просмотрSQLToolStripMenuItem
            // 
            this.просмотрSQLToolStripMenuItem.Name = "просмотрSQLToolStripMenuItem";
            this.просмотрSQLToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.просмотрSQLToolStripMenuItem.Text = "Просмотр SQL";
            this.просмотрSQLToolStripMenuItem.Click += new System.EventHandler(this.просмотрSQLToolStripMenuItem_Click);
            // 
            // exprCmbString
            // 
            this.exprCmbString.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.exprCmbString.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.exprCmbString.FormattingEnabled = true;
            this.exprCmbString.Location = new System.Drawing.Point(231, 227);
            this.exprCmbString.Name = "exprCmbString";
            this.exprCmbString.Size = new System.Drawing.Size(200, 21);
            this.exprCmbString.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 356);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Новый запрос";
            this.tbC.ResumeLayout(false);
            this.tpColumns.ResumeLayout(false);
            this.tpConditions.ResumeLayout(false);
            this.tpConditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exprNumUD)).EndInit();
            this.tpOrder.ResumeLayout(false);
            this.tpOrder.PerformLayout();
            this.tpRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbC;
        private System.Windows.Forms.TabPage tpColumns;
        private System.Windows.Forms.TabPage tpConditions;
        private System.Windows.Forms.TabPage tpOrder;
        private System.Windows.Forms.TabPage tpRes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выполнитьЗапросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрSQLToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDeleteCondition;
        private System.Windows.Forms.Button bAddCondition;
        private System.Windows.Forms.ComboBox cmbJoint;
        private System.Windows.Forms.ComboBox cmbCrit;
        private System.Windows.Forms.ComboBox cmbColumns;
        private System.Windows.Forms.ListView lvConditions;
        private System.Windows.Forms.Button bRemoveAll;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bAddAll;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ListView lvAdded;
        private System.Windows.Forms.ListView lvColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOrd;
        private System.Windows.Forms.ListView lvOrd;
        private System.Windows.Forms.Button bRemoveOrdAll;
        private System.Windows.Forms.Button bRemoveOrd;
        private System.Windows.Forms.Button bAddOrdAll;
        private System.Windows.Forms.Button bAddOrd;
        private System.Windows.Forms.ListView lvNoOrd;
        private System.Windows.Forms.ComboBox exprCmbDouble;
        private System.Windows.Forms.TextBox exprTb;
        private System.Windows.Forms.NumericUpDown exprNumUD;
        private System.Windows.Forms.DateTimePicker exprDtp;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.ComboBox exprCmbString;
    }
}

