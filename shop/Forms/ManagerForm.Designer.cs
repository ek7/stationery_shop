namespace shop.Forms
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оформитьОптовыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьВсеФильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopdbDataSet = new shop.shopdbDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofinstoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityinstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._stationeryTableAdapter = new shop.shopdbDataSetTableAdapters._stationeryTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оформитьОптовыйЗаказToolStripMenuItem,
            this.заказТовараToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.фильтрацияToolStripMenuItem,
            this.сброситьВсеФильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оформитьОптовыйЗаказToolStripMenuItem
            // 
            this.оформитьОптовыйЗаказToolStripMenuItem.Name = "оформитьОптовыйЗаказToolStripMenuItem";
            this.оформитьОптовыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(160, 20);
            this.оформитьОптовыйЗаказToolStripMenuItem.Text = "Оформить оптовый заказ";
            this.оформитьОптовыйЗаказToolStripMenuItem.Click += new System.EventHandler(this.оформитьОптовыйЗаказToolStripMenuItem_Click);
            // 
            // заказТовараToolStripMenuItem
            // 
            this.заказТовараToolStripMenuItem.Name = "заказТовараToolStripMenuItem";
            this.заказТовараToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.заказТовараToolStripMenuItem.Text = "Заказ товара";
            this.заказТовараToolStripMenuItem.Click += new System.EventHandler(this.заказТовараToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // фильтрацияToolStripMenuItem
            // 
            this.фильтрацияToolStripMenuItem.Name = "фильтрацияToolStripMenuItem";
            this.фильтрацияToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.фильтрацияToolStripMenuItem.Text = "Фильтрация";
            this.фильтрацияToolStripMenuItem.Click += new System.EventHandler(this.фильтрацияToolStripMenuItem_Click);
            // 
            // сброситьВсеФильтрыToolStripMenuItem
            // 
            this.сброситьВсеФильтрыToolStripMenuItem.Name = "сброситьВсеФильтрыToolStripMenuItem";
            this.сброситьВсеФильтрыToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.сброситьВсеФильтрыToolStripMenuItem.Text = "Сбросить все фильтры";
            this.сброситьВсеФильтрыToolStripMenuItem.Click += new System.EventHandler(this.сброситьВсеФильтрыToolStripMenuItem_Click);
            // 
            // stationeryBindingSource
            // 
            this.stationeryBindingSource.DataMember = " stationery";
            this.stationeryBindingSource.DataSource = this.shopdbDataSetBindingSource;
            // 
            // shopdbDataSetBindingSource
            // 
            this.shopdbDataSetBindingSource.DataSource = this.shopdbDataSet;
            this.shopdbDataSetBindingSource.Position = 0;
            // 
            // shopdbDataSet
            // 
            this.shopdbDataSet.DataSetName = "shopdbDataSet";
            this.shopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(356, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "КОРЗИНА";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(298, 432);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(176, 41);
            this.acceptBtn.TabIndex = 4;
            this.acceptBtn.Text = "Оформить заказ";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 272);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(753, 154);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.numberofinstoreDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.iddepartmentDataGridViewTextBoxColumn,
            this.quantityinstockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stationeryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(753, 201);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // numberofinstoreDataGridViewTextBoxColumn
            // 
            this.numberofinstoreDataGridViewTextBoxColumn.DataPropertyName = "number_of_in_store";
            this.numberofinstoreDataGridViewTextBoxColumn.HeaderText = "number_of_in_store";
            this.numberofinstoreDataGridViewTextBoxColumn.Name = "numberofinstoreDataGridViewTextBoxColumn";
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // iddepartmentDataGridViewTextBoxColumn
            // 
            this.iddepartmentDataGridViewTextBoxColumn.DataPropertyName = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.HeaderText = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.Name = "iddepartmentDataGridViewTextBoxColumn";
            // 
            // quantityinstockDataGridViewTextBoxColumn
            // 
            this.quantityinstockDataGridViewTextBoxColumn.DataPropertyName = "quantity_in_stock";
            this.quantityinstockDataGridViewTextBoxColumn.HeaderText = "quantity_in_stock";
            this.quantityinstockDataGridViewTextBoxColumn.Name = "quantityinstockDataGridViewTextBoxColumn";
            // 
            // _stationeryTableAdapter
            // 
            this._stationeryTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 485);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтрация";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оформитьОптовыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказТовараToolStripMenuItem;
        private System.Windows.Forms.BindingSource shopdbDataSetBindingSource;
        private shopdbDataSet shopdbDataSet;
        private System.Windows.Forms.BindingSource stationeryBindingSource;
        private shopdbDataSetTableAdapters._stationeryTableAdapter _stationeryTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityinstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofinstoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьВсеФильтрыToolStripMenuItem;
    }
}