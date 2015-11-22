namespace shop.Forms
{
    partial class QueryForm
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
            this.textInput = new System.Windows.Forms.RichTextBox();
            this.doSqlBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.shopdbDataSet = new shop.shopdbDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(12, 12);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(503, 156);
            this.textInput.TabIndex = 0;
            this.textInput.Text = "SELECT ";
            // 
            // doSqlBtn
            // 
            this.doSqlBtn.Location = new System.Drawing.Point(521, 13);
            this.doSqlBtn.Name = "doSqlBtn";
            this.doSqlBtn.Size = new System.Drawing.Size(101, 71);
            this.doSqlBtn.TabIndex = 1;
            this.doSqlBtn.Text = "Выполнить";
            this.doSqlBtn.UseVisualStyleBackColor = true;
            this.doSqlBtn.Click += new System.EventHandler(this.doSqlBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(521, 99);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(101, 69);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(13, 188);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(609, 198);
            this.dataGridView.TabIndex = 3;
            // 
            // shopdbDataSet
            // 
            this.shopdbDataSet.DataSetName = "shopdbDataSet";
            this.shopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 398);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.doSqlBtn);
            this.Controls.Add(this.textInput);
            this.Name = "QueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textInput;
        private System.Windows.Forms.Button doSqlBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private shopdbDataSet shopdbDataSet;
    }
}