using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Data.Model;

namespace Data
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("UsersDB")
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
