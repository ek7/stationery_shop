namespace shop.Forms
{
    partial class salesEditForm
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
            this.account_salesTableAdapter = new shop.shopdbDataSetTableAdapters.account_salesTableAdapter();
            this.Price = new System.Windows.Forms.TextBox();
            this.Phonenumber = new System.Windows.Forms.Label();
            this.Saled = new System.Windows.Forms.TextBox();
            this.adr = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.firm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_product = new System.Windows.Forms.ComboBox();
            this.stationeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopdbDataSet = new shop.shopdbDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._stationeryTableAdapter = new shop.shopdbDataSetTableAdapters._stationeryTableAdapter();
            this.Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // account_salesTableAdapter
            // 
            this.account_salesTableAdapter.ClearBeforeFill = true;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(148, 64);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(115, 20);
            this.Price.TabIndex = 67;
            // 
            // Phonenumber
            // 
            this.Phonenumber.AutoSize = true;
            this.Phonenumber.Location = new System.Drawing.Point(16, 64);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(33, 13);
            this.Phonenumber.TabIndex = 66;
            this.Phonenumber.Text = "Цена";
            // 
            // Saled
            // 
            this.Saled.Location = new System.Drawing.Point(148, 38);
            this.Saled.Name = "Saled";
            this.Saled.Size = new System.Drawing.Size(115, 20);
            this.Saled.TabIndex = 65;
            // 
            // adr
            // 
            this.adr.AutoSize = true;
            this.adr.Location = new System.Drawing.Point(16, 38);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(70, 13);
            this.adr.TabIndex = 64;
            this.adr.Text = "Продано шт.";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(148, 133);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 44);
            this.CancelButton.TabIndex = 63;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(14, 133);
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
            this.firm.Location = new System.Drawing.Point(16, 12);
            this.firm.Name = "firm";
            this.firm.Size = new System.Drawing.Size(95, 13);
            this.firm.TabIndex = 60;
            this.firm.Text = "Название товара";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Дата продажи";
            // 
            // id_product
            // 
            this.id_product.DataSource = this.stationeryBindingSource;
            this.id_product.DisplayMember = "name";
            this.id_product.FormattingEnabled = true;
            this.id_product.Location = new System.Drawing.Point(148, 12);
            this.id_product.Name = "id_product";
            this.id_product.Size = new System.Drawing.Size(115, 21);
            this.id_product.TabIndex = 70;
            this.id_product.ValueMember = "id_product";
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
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "account_sales";
            // 
            // _stationeryTableAdapter
            // 
            this._stationeryTableAdapter.ClearBeforeFill = true;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(148, 90);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(115, 20);
            this.Date.TabIndex = 71;
            // 
            // salesEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 199);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.id_product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.Saled);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.firm);
            this.Name = "salesEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.salesEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stationeryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private shopdbDataSetTableAdapters.account_salesTableAdapter account_salesTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label Phonenumber;
        private System.Windows.Forms.TextBox Saled;
        private System.Windows.Forms.Label adr;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label firm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox id_product;
        private shopdbDataSet shopdbDataSet;
        private System.Windows.Forms.BindingSource stationeryBindingSource;
        private shopdbDataSetTableAdapters._stationeryTableAdapter _stationeryTableAdapter;
        private System.Windows.Forms.DateTimePicker Date;
    }
}