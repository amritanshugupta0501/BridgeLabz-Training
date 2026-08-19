using System.Collections.Generic;
using System.Linq;
using FundooNotesApp.Models;
using FundooNotesApp.Repository;

namespace FundooNotesApp.Models
{
    public class NoteRepositoryImpl : INoteRepository
    {
        private readonly FundooNotesAppDbContext _context;

        public NoteRepositoryImpl(FundooNotesAppDbContext context)
        {
            _context = context;
        }
        public Notes CreateNote(Notes note)
        {
            _context.Note.Add(note);
            _context.SaveChanges();
            return note;
        }

        public IEnumerable<Notes> GetAllNotes(int userId)
        {
            return _context.Note.Where(n => n.UserId == userId && n.Trash == false).ToList();
        }
        public Notes GetNoteById(int noteId, int userId)
        {
            return _context.Note.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
        }

        public Notes UpdateNote(Notes note)
        {
            _context.Note.Update(note);
            _context.SaveChanges();
            return note;
        }

        public bool DeleteNote(int noteId, int userId)
        {
            var note = _context.Note.FirstOrDefault(n => n.NoteId == noteId && n.UserId == userId);
            if (note != null)
            {
                _context.Remove(note);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}

