namespace WFCL
{
    partial class UserControl1
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Edit = new System.Windows.Forms.Button();
            this.pictureBox_first = new System.Windows.Forms.PictureBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_SurName = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_first)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(33, 172);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(139, 28);
            this.button_Edit.TabIndex = 0;
            this.button_Edit.Text = "редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // pictureBox_first
            // 
            this.pictureBox_first.Location = new System.Drawing.Point(33, 26);
            this.pictureBox_first.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_first.Name = "pictureBox_first";
            this.pictureBox_first.Size = new System.Drawing.Size(133, 95);
            this.pictureBox_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_first.TabIndex = 1;
            this.pictureBox_first.TabStop = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(284, 26);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(132, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_SurName
            // 
            this.textBox_SurName.Location = new System.Drawing.Point(284, 71);
            this.textBox_SurName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_SurName.Name = "textBox_SurName";
            this.textBox_SurName.Size = new System.Drawing.Size(132, 22);
            this.textBox_SurName.TabIndex = 3;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(284, 118);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(132, 22);
            this.textBox_email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_SurName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.pictureBox_first);
            this.Controls.Add(this.button_Edit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(432, 224);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_first)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.PictureBox pictureBox_first;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_SurName;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label1;
    }
}
