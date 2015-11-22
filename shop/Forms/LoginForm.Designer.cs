namespace shop
{
    partial class Авторизация
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Авторизация));
            this.Login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.loginStr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.реестрацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(118, 175);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(155, 48);
            this.Login.TabIndex = 3;
            this.Login.Text = "Войти";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(142, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(59, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Логин:";
            // 
            // passwd
            // 
            this.passwd.Location = new System.Drawing.Point(222, 100);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '*';
            this.passwd.Size = new System.Drawing.Size(150, 20);
            this.passwd.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(142, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(71, 19);
            this.textBox3.TabIndex = 3;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Пароль:";
            // 
            // loginStr
            // 
            this.loginStr.Location = new System.Drawing.Point(222, 51);
            this.loginStr.Name = "loginStr";
            this.loginStr.Size = new System.Drawing.Size(150, 20);
            this.loginStr.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 97);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(398, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реестрацияToolStripMenuItem
            // 
            this.реестрацияToolStripMenuItem.Name = "реестрацияToolStripMenuItem";
            this.реестрацияToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.реестрацияToolStripMenuItem.Text = "Регистрация";
            this.реестрацияToolStripMenuItem.Click += new System.EventHandler(this.реестрацияToolStripMenuItem_Click);
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 235);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginStr);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Авторизация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox loginStr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem реестрацияToolStripMenuItem;
    }
}

