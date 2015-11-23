namespace shop.Forms
{
    partial class wholesaleBuyersEditForm
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
            this.Phone = new System.Windows.Forms.TextBox();
            this.Phonenumber = new System.Windows.Forms.Label();
            this.SNP = new System.Windows.Forms.TextBox();
            this.adr = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wholesaleBuyersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wholesale_buyersTableAdapter = new shop.shopdbDataSetTableAdapters.wholesale_buyersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wholesaleBuyersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(147, 38);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(115, 20);
            this.Phone.TabIndex = 73;
            // 
            // Phonenumber
            // 
            this.Phonenumber.AutoSize = true;
            this.Phonenumber.Location = new System.Drawing.Point(15, 38);
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(52, 13);
            this.Phonenumber.TabIndex = 72;
            this.Phonenumber.Text = "Телефон";
            // 
            // SNP
            // 
            this.SNP.Location = new System.Drawing.Point(147, 12);
            this.SNP.Name = "SNP";
            this.SNP.Size = new System.Drawing.Size(115, 20);
            this.SNP.TabIndex = 71;
            // 
            // adr
            // 
            this.adr.AutoSize = true;
            this.adr.Location = new System.Drawing.Point(15, 12);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(128, 13);
            this.adr.TabIndex = 70;
            this.adr.Text = "ФИО/Название фирмы";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(147, 107);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 44);
            this.CancelButton.TabIndex = 69;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(7, 107);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(129, 44);
            this.OkButton.TabIndex = 68;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(147, 64);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(115, 20);
            this.Email.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "E-mail";
            // 
            // wholesaleBuyersBindingSource
            // 
            this.wholesaleBuyersBindingSource.DataMember = "wholesale_buyers";
            // 
            // wholesale_buyersTableAdapter
            // 
            this.wholesale_buyersTableAdapter.ClearBeforeFill = true;
            // 
            // wholesaleBuyersEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 165);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.SNP);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Name = "wholesaleBuyersEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.wholesaleBuyersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Label Phonenumber;
        private System.Windows.Forms.TextBox SNP;
        private System.Windows.Forms.Label adr;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource wholesaleBuyersBindingSource;
        private shopdbDataSetTableAdapters.wholesale_buyersTableAdapter wholesale_buyersTableAdapter;
    }
}