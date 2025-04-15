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
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_first)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(209, 137);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(104, 23);
            this.button_Edit.TabIndex = 0;
            this.button_Edit.Text = "редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // pictureBox_first
            // 
            this.pictureBox_first.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_first.Location = new System.Drawing.Point(25, 21);
            this.pictureBox_first.Name = "pictureBox_first";
            this.pictureBox_first.Size = new System.Drawing.Size(100, 77);
            this.pictureBox_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_first.TabIndex = 1;
            this.pictureBox_first.TabStop = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(213, 21);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_SurName
            // 
            this.textBox_SurName.Location = new System.Drawing.Point(213, 58);
            this.textBox_SurName.Name = "textBox_SurName";
            this.textBox_SurName.Size = new System.Drawing.Size(100, 20);
            this.textBox_SurName.TabIndex = 3;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(213, 96);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(179, 24);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(33, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "name";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(166, 60);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(47, 13);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "surname";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(180, 101);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(31, 13);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "email";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_SurName);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.pictureBox_first);
            this.Controls.Add(this.button_Edit);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(324, 182);
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
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_email;
    }
}
