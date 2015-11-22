namespace shop.Forms
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.канцелярскиеТоварыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учетПродажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставщикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оптовыеПокупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оптовыеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросКБазеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Uodate = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.tableLabel = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.stationeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopdbDataSet = new shop.shopdbDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofinstoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityinstockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._stationeryTableAdapter = new shop.shopdbDataSetTableAdapters._stationeryTableAdapter();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.account_salesTableAdapter = new shop.shopdbDataSetTableAdapters.account_salesTableAdapter();
            this.autorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholesaleBuyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorizationTableAdapter = new shop.shopdbDataSetTableAdapters.autorizationTableAdapter();
            this.departmentTableAdapter = new shop.shopdbDataSetTableAdapters.departmentTableAdapter();
            this.providerTableAdapter = new shop.shopdbDataSetTableAdapters.providerTableAdapter();
            this.wholesale_buyersTableAdapter = new shop.shopdbDataSetTableAdapters.wholesale_buyersTableAdapter();
            this.wholeSaleOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholesale_ordersTableAdapter = new shop.shopdbDataSetTableAdapters.wholesale_ordersTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholesaleBuyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.запросКБазеДанныхToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.канцелярскиеТоварыToolStripMenuItem,
            this.учетПродажToolStripMenuItem,
            this.авторизацияToolStripMenuItem,
            this.отделToolStripMenuItem,
            this.поставщикиToolStripMenuItem,
            this.оптовыеПокупателиToolStripMenuItem,
            this.оптовыеЗаказыToolStripMenuItem});
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.назадToolStripMenuItem.Text = "База данных";
            // 
            // канцелярскиеТоварыToolStripMenuItem
            // 
            this.канцелярскиеТоварыToolStripMenuItem.Name = "канцелярскиеТоварыToolStripMenuItem";
            this.канцелярскиеТоварыToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.канцелярскиеТоварыToolStripMenuItem.Text = "Канцелярские товары";
            this.канцелярскиеТоварыToolStripMenuItem.Click += new System.EventHandler(this.канцелярскиеТоварыToolStripMenuItem_Click);
            // 
            // учетПродажToolStripMenuItem
            // 
            this.учетПродажToolStripMenuItem.Name = "учетПродажToolStripMenuItem";
            this.учетПродажToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.учетПродажToolStripMenuItem.Text = "Учет продаж";
            this.учетПродажToolStripMenuItem.Click += new System.EventHandler(this.учетПродажToolStripMenuItem_Click);
            // 
            // авторизацияToolStripMenuItem
            // 
            this.авторизацияToolStripMenuItem.Name = "авторизацияToolStripMenuItem";
            this.авторизацияToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.авторизацияToolStripMenuItem.Text = "Авторизация";
            this.авторизацияToolStripMenuItem.Click += new System.EventHandler(this.авторизацияToolStripMenuItem_Click);
            // 
            // отделToolStripMenuItem
            // 
            this.отделToolStripMenuItem.Name = "отделToolStripMenuItem";
            this.отделToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.отделToolStripMenuItem.Text = "Отдел";
            this.отделToolStripMenuItem.Click += new System.EventHandler(this.отделToolStripMenuItem_Click);
            // 
            // поставщикиToolStripMenuItem
            // 
            this.поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            this.поставщикиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.поставщикиToolStripMenuItem.Text = "Поставщики";
            this.поставщикиToolStripMenuItem.Click += new System.EventHandler(this.поставщикиToolStripMenuItem_Click);
            // 
            // оптовыеПокупателиToolStripMenuItem
            // 
            this.оптовыеПокупателиToolStripMenuItem.Name = "оптовыеПокупателиToolStripMenuItem";
            this.оптовыеПокупателиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.оптовыеПокупателиToolStripMenuItem.Text = "Оптовые покупатели";
            this.оптовыеПокупателиToolStripMenuItem.Click += new System.EventHandler(this.оптовыеПокупателиToolStripMenuItem_Click);
            // 
            // оптовыеЗаказыToolStripMenuItem
            // 
            this.оптовыеЗаказыToolStripMenuItem.Name = "оптовыеЗаказыToolStripMenuItem";
            this.оптовыеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.оптовыеЗаказыToolStripMenuItem.Text = "Оптовые заказы";
            this.оптовыеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.оптовыеЗаказыToolStripMenuItem_Click);
            // 
            // запросКБазеДанныхToolStripMenuItem
            // 
            this.запросКБазеДанныхToolStripMenuItem.Name = "запросКБазеДанныхToolStripMenuItem";
            this.запросКБазеДанныхToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.запросКБазеДанныхToolStripMenuItem.Text = "Запрос к базе данных";
            this.запросКБазеДанныхToolStripMenuItem.Click += new System.EventHandler(this.запросКБазеДанныхToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.Location = new System.Drawing.Point(1001, 263);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(118, 86);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Uodate
            // 
            this.Uodate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Uodate.Location = new System.Drawing.Point(1001, 170);
            this.Uodate.Name = "Uodate";
            this.Uodate.Size = new System.Drawing.Size(118, 87);
            this.Uodate.TabIndex = 18;
            this.Uodate.Text = "Изменить";
            this.Uodate.UseVisualStyleBackColor = true;
            this.Uodate.Click += new System.EventHandler(this.Uodate_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.Location = new System.Drawing.Point(1001, 76);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(118, 88);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLabel.Location = new System.Drawing.Point(28, 41);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(293, 31);
            this.tableLabel.TabIndex = 16;
            this.tableLabel.Text = "Канцелярские товары";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.stationeryBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 573);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(1141, 25);
            this.bindingNavigator1.TabIndex = 15;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // stationeryBindingSource
            // 
            this.stationeryBindingSource.DataMember = " stationery";
            this.stationeryBindingSource.DataSource = this.shopdbDataSet;
            // 
            // shopdbDataSet
            // 
            this.shopdbDataSet.DataSetName = "shopdbDataSet";
            this.shopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataView
            // 
            this.dataView.AllowUserToOrderColumns = true;
            this.dataView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataView.AutoGenerateColumns = false;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.numberofinstoreDataGridViewTextBoxColumn,
            this.quantityinstockDataGridViewTextBoxColumn,
            this.idproviderDataGridViewTextBoxColumn,
            this.iddepartmentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn});
            this.dataView.DataSource = this.stationeryBindingSource;
            this.dataView.Location = new System.Drawing.Point(34, 75);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(943, 495);
            this.dataView.TabIndex = 14;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "id_product";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "id_product";
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            // 
            // numberofinstoreDataGridViewTextBoxColumn
            // 
            this.numberofinstoreDataGridViewTextBoxColumn.DataPropertyName = "number_of_in_store";
            this.numberofinstoreDataGridViewTextBoxColumn.HeaderText = "number_of_in_store";
            this.numberofinstoreDataGridViewTextBoxColumn.Name = "numberofinstoreDataGridViewTextBoxColumn";
            // 
            // quantityinstockDataGridViewTextBoxColumn
            // 
            this.quantityinstockDataGridViewTextBoxColumn.DataPropertyName = "quantity_in_stock";
            this.quantityinstockDataGridViewTextBoxColumn.HeaderText = "quantity_in_stock";
            this.quantityinstockDataGridViewTextBoxColumn.Name = "quantityinstockDataGridViewTextBoxColumn";
            // 
            // idproviderDataGridViewTextBoxColumn
            // 
            this.idproviderDataGridViewTextBoxColumn.DataPropertyName = "id_provider";
            this.idproviderDataGridViewTextBoxColumn.HeaderText = "id_provider";
            this.idproviderDataGridViewTextBoxColumn.Name = "idproviderDataGridViewTextBoxColumn";
            // 
            // iddepartmentDataGridViewTextBoxColumn
            // 
            this.iddepartmentDataGridViewTextBoxColumn.DataPropertyName = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.HeaderText = "id_department";
            this.iddepartmentDataGridViewTextBoxColumn.Name = "iddepartmentDataGridViewTextBoxColumn";
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
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // _stationeryTableAdapter
            // 
            this._stationeryTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "account_sales";
            this.salesBindingSource.DataSource = this.shopdbDataSet;
            // 
            // account_salesTableAdapter
            // 
            this.account_salesTableAdapter.ClearBeforeFill = true;
            // 
            // autorizationBindingSource
            // 
            this.autorizationBindingSource.DataMember = "autorization";
            this.autorizationBindingSource.DataSource = this.shopdbDataSet;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.shopdbDataSet;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "provider";
            this.providerBindingSource.DataSource = this.shopdbDataSet;
            // 
            // wholesaleBuyersBindingSource
            // 
            this.wholesaleBuyersBindingSource.DataMember = "wholesale_buyers";
            this.wholesaleBuyersBindingSource.DataSource = this.shopdbDataSet;
            // 
            // autorizationTableAdapter
            // 
            this.autorizationTableAdapter.ClearBeforeFill = true;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // wholesale_buyersTableAdapter
            // 
            this.wholesale_buyersTableAdapter.ClearBeforeFill = true;
            // 
            // wholeSaleOrdersBindingSource
            // 
            this.wholeSaleOrdersBindingSource.DataMember = "wholesale_orders";
            this.wholeSaleOrdersBindingSource.DataSource = this.shopdbDataSet;
            // 
            // wholesale_ordersTableAdapter
            // 
            this.wholesale_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 598);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Uodate);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholesaleBuyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Uodate;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataView;
        private shopdbDataSet shopdbDataSet;
        private System.Windows.Forms.BindingSource stationeryBindingSource;
        private shopdbDataSetTableAdapters._stationeryTableAdapter _stationeryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofinstoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityinstockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem канцелярскиеТоварыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учетПродажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставщикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оптовыеПокупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оптовыеЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросКБазеДанныхToolStripMenuItem;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private shopdbDataSetTableAdapters.account_salesTableAdapter account_salesTableAdapter;
        private System.Windows.Forms.BindingSource autorizationBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private System.Windows.Forms.BindingSource wholesaleBuyersBindingSource;
        private shopdbDataSetTableAdapters.autorizationTableAdapter autorizationTableAdapter;
        private shopdbDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private shopdbDataSetTableAdapters.providerTableAdapter providerTableAdapter;
        private shopdbDataSetTableAdapters.wholesale_buyersTableAdapter wholesale_buyersTableAdapter;
        private System.Windows.Forms.BindingSource wholeSaleOrdersBindingSource;
        private shopdbDataSetTableAdapters.wholesale_ordersTableAdapter wholesale_ordersTableAdapter;
    }
}