using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_lib.views
{
    public interface IUserCard
    {
        void Show (User u);

        event Action<User> DataUserChanged;
    }
}
