namespace shop.Forms
{
    partial class autorizationEditForm
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
            this.Passwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Job = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PassprtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.SNP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.autorizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorizationTableAdapter = new shop.shopdbDataSetTableAdapters.autorizationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autorizationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Passwd
            // 
            this.Passwd.Location = new System.Drawing.Point(156, 124);
            this.Passwd.Name = "Passwd";
            this.Passwd.Size = new System.Drawing.Size(115, 20);
            this.Passwd.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Пароль";
            // 
            // Job
            // 
            this.Job.Location = new System.Drawing.Point(156, 46);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(115, 20);
            this.Job.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Должность";
            // 
            // PassprtCode
            // 
            this.PassprtCode.Location = new System.Drawing.Point(156, 72);
            this.PassprtCode.Name = "PassprtCode";
            this.PassprtCode.Size = new System.Drawing.Size(115, 20);
            this.PassprtCode.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Код паспорта";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(156, 159);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 44);
            this.CancelButton.TabIndex = 41;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(22, 159);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(129, 44);
            this.OkButton.TabIndex = 40;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(156, 98);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(115, 20);
            this.Login.TabIndex = 39;
            // 
            // SNP
            // 
            this.SNP.Location = new System.Drawing.Point(156, 20);
            this.SNP.Name = "SNP";
            this.SNP.Size = new System.Drawing.Size(115, 20);
            this.SNP.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ФИО";
            // 
            // autorizationBindingSource
            // 
            this.autorizationBindingSource.DataMember = "autorization";
            // 
            // autorizationTableAdapter
            // 
            this.autorizationTableAdapter.ClearBeforeFill = true;
            // 
            // autorizationEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 218);
            this.Controls.Add(this.Passwd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Job);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassprtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.SNP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "autorizationEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.autorizationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Passwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Job;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PassprtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox SNP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource autorizationBindingSource;
        private shopdbDataSetTableAdapters.autorizationTableAdapter autorizationTableAdapter;
    }
}