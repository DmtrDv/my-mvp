using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace my_lib.models
{
    public class MemoryUsersModel : IUsersModel
    {
        List<User> Users_ = new List<User>();
        List<User> FilterUsers_ = new List<User>();
        public event Action DataIsLoaded;

        public List<User> GetUsers()
        { 
            return FilterUsers_;
        }

        public void LoadDataUsers()
        {
            Users_.Add(new User {
                Login = "123",
                Password = "123", 
                Name = "Одиндватри", 
                Sername = "Одиндватривов",
                Birrshday = new DateTime(2025, 1, 1),
                avatar_Path = "D:\\\\п 30\\i.jpg"
            }
            );
            Users_.Add(new User
            {
                Login = "111",
                Password = "111",
                Name = "Единица",
                Sername = "Единицев",
                Birrshday = new DateTime(2025, 2, 1),
                avatar_Path = "D:\\\\п 30\\i.jpg"
            }
            );
            Users_.Add(new User
            {
                Login = "333",
                Password = "333",
                Name = "Тройка",
                Sername = "Тройков",
                Birrshday = new DateTime(2025, 1, 2),
                avatar_Path = "D:\\\\п 30\\i.jpg",
                Email = "WWW@Gmail"
            }
            );
            FilterUsers_ = new List<User>(Users_);
            DataIsLoaded.Invoke();
        }

        public void FilterUsersName(string nametext)
        {
            List<User> newUsers = new List<User>();
            foreach (User user in Users_) 
            {
                if (user.Name.ToLower().Contains(nametext.ToLower()))
                {
                    newUsers.Add(user);
                }
                
            }
            FilterUsers_ = newUsers;
            DataIsLoaded.Invoke();
        }
        private void ChangeUser(User obj)
        {
            for (int index = 0; index < Users_.Count; index++)
            {
                User user = Users_.ElementAt(index);
                if(obj.Login == user.Login)
                {
                    Users_[index].Name = obj.Name;
                    Users_[index].Sername = obj.Sername;
                    Users_[index].Email = obj.Email;
                }
            }
            DataIsLoaded.Invoke();
        }
        void IUsersModel.ChangeUser(User obj)
        {
            ChangeUser(obj);
        }        
        public void DeleteUser (string DeleteByLogin)
        {
            User delete = FilterUsers_.FirstOrDefault(u => u.Login == DeleteByLogin);
            if (delete != null)
            {
                Users_.Remove(delete); FilterUsers_.Remove(delete);
                DataIsLoaded.Invoke();
            }
        }
    }
}
