namespace my_mvp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.button_filtering = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userControl_first = new WFCL.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(12, 12);
            this.DataTable.Name = "DataTable";
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(724, 407);
            this.DataTable.TabIndex = 0;
            this.DataTable.SelectionChanged += new System.EventHandler(this.DataTable_SelectionChanged);
            // 
            // button_filtering
            // 
            this.button_filtering.Location = new System.Drawing.Point(606, 478);
            this.button_filtering.Name = "button_filtering";
            this.button_filtering.Size = new System.Drawing.Size(130, 23);
            this.button_filtering.TabIndex = 1;
            this.button_filtering.Text = "фильтровать";
            this.button_filtering.UseVisualStyleBackColor = true;
            this.button_filtering.Click += new System.EventHandler(this.button_filtering_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 2;
            // 
            // userControl_first
            // 
            this.userControl_first.Location = new System.Drawing.Point(23, 433);
            this.userControl_first.Name = "userControl_first";
            this.userControl_first.Size = new System.Drawing.Size(324, 182);
            this.userControl_first.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 627);
            this.Controls.Add(this.userControl_first);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_filtering);
            this.Controls.Add(this.DataTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button button_filtering;
        private System.Windows.Forms.TextBox textBox1;
        private WFCL.UserControl1 userControl_first;
    }
}

