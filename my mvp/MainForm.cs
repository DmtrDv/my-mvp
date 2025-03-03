using my_lib;
using my_lib.models;
using my_lib.presentors;
using my_lib.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_mvp
{
    public partial class MainForm : Form, IUsersView
    {
        UserPresentor presentor_;
        public MainForm()
        {
            InitializeComponent();
            presentor_ = new UserPresentor(new MemoryUsersModel(), this, userControl_first);      
        }

        public void ShowUsers(List<User> users)
        {
            DataTable.DataSource = null;
            DataTable.DataSource = users;
        }

        private void button_filtering_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            MessageBox.Show(text);
            presentor_.FilterByName(text);
        }

        private void DataTable_SelectionChanged(object sender, EventArgs e)
        {
            int row = DataTable.CurrentCell.RowIndex;
            presentor_.SelectedUser(row);
        }

        private void button_Delete_User_Click(object sender, EventArgs e)
        {
            
        }
    }
}
