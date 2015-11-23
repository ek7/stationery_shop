namespace shop.Forms
{
    partial class wholesaleOrdersEditForm
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
            this.Phonenumber = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.TextBox();
            this.adr = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.firm = new System.Windows.Forms.Label();
            this.wholesale_ordersTableAdapter = new shop.shopdbDataSetTableAdapters.wholesale_ordersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.productId = new System.Windows.Forms.ComboBox();
            this.stationeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopdbDataSet = new shop.shopdbDataSet();
            this.buyerId = new System.Windows.Forms.ComboBox();
            this.wholesalebuyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholeSaleOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._stationeryTableAdapter = new shop.shopdbDataSetTableAdapters._stationeryTableAdapter();
            this.wholesale_buyersTableAdapter = new shop.shopdbDataSetTableAdapters.wholesale_buyersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholesalebuyersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleOrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Phonenumber
            // 
            this.Phonenumber.AutoSize = true;
            this.Phonenumber.Location = new System.Drawing.Point(14, 92);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(72, 13);
            this.Phonenumber.TabIndex = 66;
            this.Phonenumber.Text = "Дата заказа";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(146, 60);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(115, 20);
            this.Count.TabIndex = 65;
            // 
            // adr
            // 
            this.adr.AutoSize = true;
            this.adr.Location = new System.Drawing.Point(14, 63);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(66, 13);
            this.adr.TabIndex = 64;
            this.adr.Text = "Количество";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(146, 127);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 44);
            this.CancelButton.TabIndex = 63;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(17, 127);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(129, 44);
            this.OkButton.TabIndex = 62;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // firm
            // 
            this.firm.AutoSize = true;
            this.firm.Location = new System.Drawing.Point(14, 9);
            this.firm.Name = "firm";
            this.firm.Size = new System.Drawing.Size(95, 13);
            this.firm.TabIndex = 60;
            this.firm.Text = "Название товара";
            // 
            // wholesale_ordersTableAdapter
            // 
            this.wholesale_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Покупатель";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(146, 86);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 20);
            this.Date.TabIndex = 68;
            // 
            // productId
            // 
            this.productId.DataSource = this.stationeryBindingSource;
            this.productId.DisplayMember = "name";
            this.productId.FormattingEnabled = true;
            this.productId.Location = new System.Drawing.Point(146, 6);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(115, 21);
            this.productId.TabIndex = 69;
            this.productId.ValueMember = "id_product";
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
            // buyerId
            // 
            this.buyerId.DataSource = this.wholesalebuyersBindingSource;
            this.buyerId.DisplayMember = "SNP/Firm";
            this.buyerId.FormattingEnabled = true;
            this.buyerId.Location = new System.Drawing.Point(146, 33);
            this.buyerId.Name = "buyerId";
            this.buyerId.Size = new System.Drawing.Size(115, 21);
            this.buyerId.TabIndex = 70;
            this.buyerId.ValueMember = "id_buyer";
            // 
            // wholesalebuyersBindingSource
            // 
            this.wholesalebuyersBindingSource.DataMember = "wholesale_buyers";
            this.wholesalebuyersBindingSource.DataSource = this.shopdbDataSet;
            // 
            // wholeSaleOrdersBindingSource
            // 
            this.wholeSaleOrdersBindingSource.DataMember = "wholesale_orders";
            // 
            // _stationeryTableAdapter
            // 
            this._stationeryTableAdapter.ClearBeforeFill = true;
            // 
            // wholesale_buyersTableAdapter
            // 
            this.wholesale_buyersTableAdapter.ClearBeforeFill = true;
            // 
            // wholesaleOrdersEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 188);
            this.Controls.Add(this.buyerId);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.firm);
            this.Name = "wholesaleOrdersEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.wholesaleOrdersEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholesalebuyersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wholeSaleOrdersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Phonenumber;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Label adr;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label firm;
        private shopdbDataSetTableAdapters.wholesale_ordersTableAdapter wholesale_ordersTableAdapter;
        private System.Windows.Forms.BindingSource wholeSaleOrdersBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox productId;
        private System.Windows.Forms.ComboBox buyerId;
        private shopdbDataSet shopdbDataSet;
        private System.Windows.Forms.BindingSource stationeryBindingSource;
        private shopdbDataSetTableAdapters._stationeryTableAdapter _stationeryTableAdapter;
        private System.Windows.Forms.BindingSource wholesalebuyersBindingSource;
        private shopdbDataSetTableAdapters.wholesale_buyersTableAdapter wholesale_buyersTableAdapter;
    }
}