namespace shop.Forms
{
    partial class providerEditForm
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
            this.Adress = new System.Windows.Forms.TextBox();
            this.adr = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.firmName = new System.Windows.Forms.TextBox();
            this.firm = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Phonenumber = new System.Windows.Forms.Label();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTableAdapter = new shop.shopdbDataSetTableAdapters.providerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(152, 44);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(115, 20);
            this.Adress.TabIndex = 57;
            // 
            // adr
            // 
            this.adr.AutoSize = true;
            this.adr.Location = new System.Drawing.Point(20, 44);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(38, 13);
            this.adr.TabIndex = 56;
            this.adr.Text = "Адрес";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(152, 106);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 44);
            this.CancelButton.TabIndex = 55;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(18, 106);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(129, 44);
            this.OkButton.TabIndex = 54;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // firmName
            // 
            this.firmName.Location = new System.Drawing.Point(152, 18);
            this.firmName.Name = "firmName";
            this.firmName.Size = new System.Drawing.Size(115, 20);
            this.firmName.TabIndex = 53;
            // 
            // firm
            // 
            this.firm.AutoSize = true;
            this.firm.Location = new System.Drawing.Point(20, 18);
            this.firm.Name = "firm";
            this.firm.Size = new System.Drawing.Size(96, 13);
            this.firm.TabIndex = 52;
            this.firm.Text = "Название фирмы";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(152, 70);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(115, 20);
            this.Phone.TabIndex = 59;
            // 
            // Phonenumber
            // 
            this.Phonenumber.AutoSize = true;
            this.Phonenumber.Location = new System.Drawing.Point(20, 70);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(52, 13);
            this.Phonenumber.TabIndex = 58;
            this.Phonenumber.Text = "Телефон";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "provider";
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // providerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 165);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.firmName);
            this.Controls.Add(this.firm);
            this.Name = "providerEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label adr;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox firmName;
        private System.Windows.Forms.Label firm;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label Phonenumber;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private shopdbDataSetTableAdapters.providerTableAdapter providerTableAdapter;
    }
}