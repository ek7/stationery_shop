namespace shop.Forms
{
    partial class stationeryEditForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.Articul = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inShop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.idDepartment = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopdbDataSet = new shop.shopdbDataSet();
            this.idProvider = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new shop.shopdbDataSetTableAdapters.departmentTableAdapter();
            this.providerTableAdapter = new shop.shopdbDataSetTableAdapters.providerTableAdapter();
            this._stationeryTableAdapter = new shop.shopdbDataSetTableAdapters._stationeryTableAdapter();
            this.stationeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(156, 240);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 44);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(22, 240);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(129, 44);
            this.OkButton.TabIndex = 22;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Articul
            // 
            this.Articul.Location = new System.Drawing.Point(156, 100);
            this.Articul.Name = "Articul";
            this.Articul.Size = new System.Drawing.Size(115, 20);
            this.Articul.TabIndex = 21;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(156, 22);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(115, 20);
            this.ProductName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Id поставщика";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Название товара";
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(156, 74);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(115, 20);
            this.Manufacturer.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Производитель";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(156, 48);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(115, 20);
            this.Price.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Цена";
            // 
            // inShop
            // 
            this.inShop.Location = new System.Drawing.Point(156, 126);
            this.inShop.Name = "inShop";
            this.inShop.Size = new System.Drawing.Size(115, 20);
            this.inShop.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Количество в магазине";
            // 
            // inStock
            // 
            this.inStock.Location = new System.Drawing.Point(156, 178);
            this.inStock.Name = "inStock";
            this.inStock.Size = new System.Drawing.Size(115, 20);
            this.inStock.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Количество на складе";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Id отдела";
            // 
            // idDepartment
            // 
            this.idDepartment.DataSource = this.departmentBindingSource;
            this.idDepartment.DisplayMember = "department_name";
            this.idDepartment.FormattingEnabled = true;
            this.idDepartment.Location = new System.Drawing.Point(156, 153);
            this.idDepartment.Name = "idDepartment";
            this.idDepartment.Size = new System.Drawing.Size(115, 21);
            this.idDepartment.TabIndex = 33;
            this.idDepartment.ValueMember = "id_department";
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.shopdbDataSet;
            // 
            // shopdbDataSet
            // 
            this.shopdbDataSet.DataSetName = "shopdbDataSet";
            this.shopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idProvider
            // 
            this.idProvider.DataSource = this.providerBindingSource;
            this.idProvider.DisplayMember = "name_of_firm";
            this.idProvider.FormattingEnabled = true;
            this.idProvider.Location = new System.Drawing.Point(156, 204);
            this.idProvider.Name = "idProvider";
            this.idProvider.Size = new System.Drawing.Size(115, 21);
            this.idProvider.TabIndex = 34;
            this.idProvider.ValueMember = "id_provider";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "provider";
            this.providerBindingSource.DataSource = this.shopdbDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // _stationeryTableAdapter
            // 
            this._stationeryTableAdapter.ClearBeforeFill = true;
            // 
            // stationeryBindingSource
            // 
            this.stationeryBindingSource.DataMember = " stationery";
            this.stationeryBindingSource.DataSource = this.shopdbDataSet;
            // 
            // stationeryEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 296);
            this.Controls.Add(this.idProvider);
            this.Controls.Add(this.idDepartment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.inStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inShop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.Articul);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "stationeryEditForm";
            this.Load += new System.EventHandler(this.stationeryEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox Articul;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inShop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox idDepartment;
        private shopdbDataSet shopdbDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private shopdbDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.ComboBox idProvider;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private shopdbDataSetTableAdapters.providerTableAdapter providerTableAdapter;
        private shopdbDataSetTableAdapters._stationeryTableAdapter _stationeryTableAdapter;
        private System.Windows.Forms.BindingSource stationeryBindingSource;
    }
}