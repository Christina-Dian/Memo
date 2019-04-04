using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Data;
using System.Data.SqlClient;
using System.Data;

namespace Business
{
    public class UserBusiness
    {
        private UsersContext userContext;

        public List<User> GetAll()
        {
            using (userContext = new UsersContext())
            {
                return userContext.Users.ToList();
            }
        }

        public User Get(int id)
        {
            using (userContext = new UsersContext())
            {
                return userContext.Users.Find(id);

            }
        }

        public void Add(User user)
        {
            using (userContext = new UsersContext())
            {
                userContext.Users.Add(user);
                userContext.SaveChanges();

            }
        }

        public void Update(User user)
        {
            using (userContext = new UsersContext())
            {

                var item = userContext.Users.Find(user.Id);
                if (item != null)
                {
                    userContext.Entry(item).CurrentValues.SetValues(user);
                    userContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (userContext = new UsersContext())
            {
                var user = userContext.Users.Find(id);
                if (user != null)
                {
                    userContext.Users.Remove(user);
                    userContext.SaveChanges();
                }
            }
        }
    }
}
