using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Data
{
    public class NotesContext : DbContext
    {
        public NotesContext()
         : base("NotesDB")
        {
        }

        public DbSet<Notes> Notes { get; set; }
    }
}
