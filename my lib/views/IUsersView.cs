using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_lib.views
{
    public interface IUsersView
    {
        void ShowUsers(List<User> users);
        int GetSelectedUserIndex();
    }
}
