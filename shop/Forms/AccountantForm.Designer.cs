namespace shop.Forms
{
    partial class AccountantForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиЗаПоследнийМесяцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продажиЗаГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализПродажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализВыполненияПланаПродажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализДинамикиПродажПоНаправлениямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализСтруктурыПродажToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SeledCount = new System.Windows.Forms.TextBox();
            this.PriceCount = new System.Windows.Forms.TextBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.label = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem,
            this.анализПродажToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.продажиЗаПоследнийМесяцToolStripMenuItem,
            this.продажиЗаГодToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // продажиЗаПоследнийМесяцToolStripMenuItem
            // 
            this.продажиЗаПоследнийМесяцToolStripMenuItem.Name = "продажиЗаПоследнийМесяцToolStripMenuItem";
            this.продажиЗаПоследнийМесяцToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.продажиЗаПоследнийМесяцToolStripMenuItem.Text = "Продажи за последний месяц";
            this.продажиЗаПоследнийМесяцToolStripMenuItem.Click += new System.EventHandler(this.продажиЗаПоследнийМесяцToolStripMenuItem_Click);
            // 
            // продажиЗаГодToolStripMenuItem
            // 
            this.продажиЗаГодToolStripMenuItem.Name = "продажиЗаГодToolStripMenuItem";
            this.продажиЗаГодToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.продажиЗаГодToolStripMenuItem.Text = "Продажи за год";
            this.продажиЗаГодToolStripMenuItem.Click += new System.EventHandler(this.продажиЗаГодToolStripMenuItem_Click);
            // 
            // анализПродажToolStripMenuItem
            // 
            this.анализПродажToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.анализВыполненияПланаПродажToolStripMenuItem,
            this.анализДинамикиПродажПоНаправлениямToolStripMenuItem,
            this.анализСтруктурыПродажToolStripMenuItem});
            this.анализПродажToolStripMenuItem.Name = "анализПродажToolStripMenuItem";
            this.анализПродажToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.анализПродажToolStripMenuItem.Text = "Анализ продаж";
            // 
            // анализВыполненияПланаПродажToolStripMenuItem
            // 
            this.анализВыполненияПланаПродажToolStripMenuItem.Name = "анализВыполненияПланаПродажToolStripMenuItem";
            this.анализВыполненияПланаПродажToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.анализВыполненияПланаПродажToolStripMenuItem.Text = "Анализ выполнения плана продаж";
            // 
            // анализДинамикиПродажПоНаправлениямToolStripMenuItem
            // 
            this.анализДинамикиПродажПоНаправлениямToolStripMenuItem.Name = "анализДинамикиПродажПоНаправлениямToolStripMenuItem";
            this.анализДинамикиПродажПоНаправлениямToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.анализДинамикиПродажПоНаправлениямToolStripMenuItem.Text = "Анализ динамики продаж по направлениям";
            // 
            // анализСтруктурыПродажToolStripMenuItem
            // 
            this.анализСтруктурыПродажToolStripMenuItem.Name = "анализСтруктурыПродажToolStripMenuItem";
            this.анализСтруктурыПродажToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.анализСтруктурыПродажToolStripMenuItem.Text = "Анализ структуры продаж";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 231);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Общее количество проданых товаров:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Месячная выручка с продаж:";
            // 
            // SeledCount
            // 
            this.SeledCount.Location = new System.Drawing.Point(245, 325);
            this.SeledCount.Name = "SeledCount";
            this.SeledCount.Size = new System.Drawing.Size(316, 20);
            this.SeledCount.TabIndex = 4;
            // 
            // PriceCount
            // 
            this.PriceCount.Location = new System.Drawing.Point(245, 356);
            this.PriceCount.Name = "PriceCount";
            this.PriceCount.Size = new System.Drawing.Size(316, 20);
            this.PriceCount.TabIndex = 5;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(589, 69);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(149, 69);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Сохранить отчет";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(589, 144);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(149, 69);
            this.printBtn.TabIndex = 8;
            this.printBtn.Text = "Распечатать отчет";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(589, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Отправить отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PriceCount);
            this.Controls.Add(this.SeledCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AccountantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бухгалтер";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиЗаПоследнийМесяцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продажиЗаГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализПродажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализВыполненияПланаПродажToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализДинамикиПродажПоНаправлениямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализСтруктурыПродажToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SeledCount;
        private System.Windows.Forms.TextBox PriceCount;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button button1;
    }
}