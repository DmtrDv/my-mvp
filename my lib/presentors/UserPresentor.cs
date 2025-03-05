using my_lib.models;
using my_lib.views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_lib.presentors
{
    public class UserPresentor
    {
        IUsersModel model_;
        IUsersView view_;
        IUserCard card_;
        public UserPresentor(IUsersModel m, IUsersView v, IUserCard c)
        {
            model_ = m;
            view_ = v;
            card_ = c;
            model_.DataIsLoaded += Model__DataIsLoaded;
            model_.LoadDataUsers();

            card_.DataUserChanged += Card__DataUserCnanged;
        }

        private void Card__DataUserCnanged(User obj)
        {
            model_.ChangeUser(obj);
        }

        private void Model__DataIsLoaded()
        {
            view_.ShowUsers(model_.GetUsers());
        }

        public void FilterByName(string  name)
        {
            model_.FilterUsersName(name);
        }
        public void SelectedUser(int row) 
        {
            User u = model_.GetUsers()[row];
            card_.Show(u);
        }

        public void Model__DeleteUser()
        {
            int DeleteIndex = view_.GetSelectedUserIndex();
            if (DeleteIndex < 0 || DeleteIndex >= model_.GetUsers().Count)
            {
                return;
            }
            User u = model_.GetUsers()[DeleteIndex];
            model_.DeleteUser(u.Login);
        }
    }
}
