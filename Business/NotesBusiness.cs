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
    public class NotesBusiness
    {
        private NotesContext notesContext;

        public List<Notes> GetAll()
        {
            using (notesContext = new NotesContext())
            {
                return notesContext.Notes.ToList();
            }
        }

        public Notes Get(int id)
        {
            using (notesContext = new NotesContext())
            {
                return notesContext.Notes.Find(id);

            }
        }

        public void Add(Notes notes)
        {
            using (notesContext = new NotesContext())
            {
                notesContext.Notes.Add(notes);
                notesContext.SaveChanges();

            }
        }

        public void Update(Notes notes)
        {
            using (notesContext = new NotesContext())
            {

                var item = notesContext.Notes.Find(notes.Id);
                if (item != null)
                {
                    notesContext.Entry(item).CurrentValues.SetValues(notes);
                    notesContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (notesContext = new NotesContext())
            {
                var note = notesContext.Notes.Find(id);
                if (note != null)
                {
                    notesContext.Notes.Remove(note);
                    notesContext.SaveChanges();
                }
            }
        }
    }
}
