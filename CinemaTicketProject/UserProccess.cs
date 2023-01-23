using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketProject
{
    internal class UserProccess : ICrud<User>
    {
        public bool Add(User obj)
        {
            User user = obj;
            if (user != null)
            {
                DbContext.UserList.Add(user);
                return true;
            }
            else return false;
        }

        public bool Delete(int id)
        {
            bool IsDelete = false;
            foreach (var user in DbContext.UserList.ToList())
            {
                if (user.Id == id)
                {
                    DbContext.UserList.Remove(user);
                    IsDelete = true;
                    break;
                }
            }

            return IsDelete;
        }

        public User Detail(int id)
        {
            User userDetail = null;
            foreach (var user in DbContext.UserList.ToList())
            {
                if (user.Id == id)
                {
                    userDetail = user;
                    break;
                }
            }

            return userDetail;
        }

        public List<User> List()
        {
            List<User> users = DbContext.UserList.ToList();
            return users;
        }
    }
}
