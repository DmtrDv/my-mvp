using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_lib.models
{
    public interface IUsersModel
    {
        List<User> GetUsers();

        void LoadDataUsers();
        void FilterUsersName(string nametext);
        event Action DataIsLoaded;

        void ChangeUser(User obj);
        void DeleteUser(string DeleteByLogin);
    }
}
