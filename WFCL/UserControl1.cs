using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using my_lib.views;
using my_lib;
using my_lib.presentors;

namespace WFCL
{
    public partial class UserControl1: UserControl, IUserCard
    {
        private string Login_;
        public UserControl1()
        {
            InitializeComponent();
        }
        
        public event Action<User> DataUserChanged;

        public void Show(User u)
        {
            textBox_Name.Text = u.Name;
            textBox_SurName.Text = u.Sername;
            textBox_email.Text = u.Email;
            Login_ = u.Login;

            if (!string.IsNullOrEmpty(u.avatar_Path))
            {
                pictureBox_first.Image = Image.FromFile(u.avatar_Path);
            }
            
        }
        
        private void button_Edit_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = textBox_Name.Text;
            u.Sername = textBox_SurName.Text;
            u.Email = textBox_email.Text;
            u.Login = Login_;

            DataUserChanged.Invoke(u);
        }       

        private void Edit_Picture_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Настройки диалога открытия файлов
                openFileDialog.Filter = "Изображения (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Title = "Выбор изображения профиля";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Сохраняем путь к новому изображению
                        User u = new User();
                        u.Name = textBox_Name.Text;
                        u.Sername = textBox_SurName.Text;
                        u.Email = textBox_email.Text;
                        u.Login = Login_;
                        u.avatar_Path = openFileDialog.FileName;

                        // Обновляем изображение в интерфейсе
                        pictureBox_first.Image = Image.FromFile(openFileDialog.FileName);

                        // Вызываем событие Redact с обновленным объектом User
                        DataUserChanged.Invoke(u);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                    }
                }
            }
        }
    }
}
