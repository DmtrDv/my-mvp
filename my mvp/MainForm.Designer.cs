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
            this.button_Delete_User = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(16, 15);
            this.DataTable.Margin = new System.Windows.Forms.Padding(4);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(965, 354);
            this.DataTable.TabIndex = 0;
            this.DataTable.SelectionChanged += new System.EventHandler(this.DataTable_SelectionChanged);
            // 
            // button_filtering
            // 
            this.button_filtering.Location = new System.Drawing.Point(808, 406);
            this.button_filtering.Margin = new System.Windows.Forms.Padding(4);
            this.button_filtering.Name = "button_filtering";
            this.button_filtering.Size = new System.Drawing.Size(173, 28);
            this.button_filtering.TabIndex = 1;
            this.button_filtering.Text = "фильтровать";
            this.button_filtering.UseVisualStyleBackColor = true;
            this.button_filtering.Click += new System.EventHandler(this.button_filtering_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 406);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 2;
            // 
            // userControl_first
            // 
            this.userControl_first.Location = new System.Drawing.Point(26, 378);
            this.userControl_first.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_first.Name = "userControl_first";
            this.userControl_first.Size = new System.Drawing.Size(432, 224);
            this.userControl_first.TabIndex = 3;
            // 
            // button_Delete_User
            // 
            this.button_Delete_User.Location = new System.Drawing.Point(808, 493);
            this.button_Delete_User.Name = "button_Delete_User";
            this.button_Delete_User.Size = new System.Drawing.Size(173, 30);
            this.button_Delete_User.TabIndex = 4;
            this.button_Delete_User.Text = "удалить юзера";
            this.button_Delete_User.UseVisualStyleBackColor = true;
            this.button_Delete_User.Click += new System.EventHandler(this.button_Delete_User_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 605);
            this.Controls.Add(this.button_Delete_User);
            this.Controls.Add(this.userControl_first);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_filtering);
            this.Controls.Add(this.DataTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
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
        private System.Windows.Forms.Button button_Delete_User;
    }
}

