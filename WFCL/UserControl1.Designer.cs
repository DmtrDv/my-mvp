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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_SurName = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edit_Picture_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_first = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRedact = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_first)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(68, 160);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(139, 28);
            this.button_Edit.TabIndex = 0;
            this.button_Edit.Text = "редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(73, 17);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(132, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_SurName
            // 
            this.textBox_SurName.Location = new System.Drawing.Point(73, 62);
            this.textBox_SurName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SurName.Name = "textBox_SurName";
            this.textBox_SurName.Size = new System.Drawing.Size(132, 22);
            this.textBox_SurName.TabIndex = 3;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(73, 109);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(132, 22);
            this.textBox_email.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(28, 21);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(41, 16);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "name";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(10, 65);
            this.label_surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(59, 16);
            this.label_surname.TabIndex = 6;
            this.label_surname.Text = "surname";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(29, 115);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(40, 16);
            this.label_email.TabIndex = 7;
            this.label_email.Text = "email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edit_Picture_button);
            this.groupBox1.Controls.Add(this.button_Edit);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.label_email);
            this.groupBox1.Controls.Add(this.textBox_SurName);
            this.groupBox1.Controls.Add(this.label_surname);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Location = new System.Drawing.Point(226, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 245);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Edit_Picture_button
            // 
            this.Edit_Picture_button.Location = new System.Drawing.Point(68, 207);
            this.Edit_Picture_button.Name = "Edit_Picture_button";
            this.Edit_Picture_button.Size = new System.Drawing.Size(137, 23);
            this.Edit_Picture_button.TabIndex = 8;
            this.Edit_Picture_button.Text = "Сменить фото";
            this.Edit_Picture_button.UseVisualStyleBackColor = true;
            this.Edit_Picture_button.Click += new System.EventHandler(this.Edit_Picture_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_first, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 281);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // pictureBox_first
            // 
            this.pictureBox_first.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_first.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_first.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_first.Name = "pictureBox_first";
            this.pictureBox_first.Size = new System.Drawing.Size(239, 273);
            this.pictureBox_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_first.TabIndex = 0;
            this.pictureBox_first.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.buttonChangeImage);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonRedact);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.textBoxSurname);
            this.groupBox2.Location = new System.Drawing.Point(251, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(192, 273);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование профиля";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(40, 38);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(44, 16);
            this.label.TabIndex = 4;
            this.label.Text = "Name";
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.Location = new System.Drawing.Point(41, 222);
            this.buttonChangeImage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(151, 28);
            this.buttonChangeImage.TabIndex = 8;
            this.buttonChangeImage.Text = "Сменить аватар";
            this.buttonChangeImage.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(42, 55);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Surname";
            // 
            // buttonRedact
            // 
            this.buttonRedact.Location = new System.Drawing.Point(41, 184);
            this.buttonRedact.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRedact.Name = "buttonRedact";
            this.buttonRedact.Size = new System.Drawing.Size(133, 28);
            this.buttonRedact.TabIndex = 5;
            this.buttonRedact.Text = "Редактировать";
            this.buttonRedact.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(39, 127);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(41, 16);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(41, 151);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(133, 22);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(42, 101);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(132, 22);
            this.textBoxSurname.TabIndex = 2;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(447, 281);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_first)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_SurName;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Edit_Picture_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox_first;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonChangeImage;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRedact;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSurname;
    }
}
