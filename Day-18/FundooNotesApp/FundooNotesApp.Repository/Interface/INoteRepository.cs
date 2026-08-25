using System.Collections.Generic;
using FundooNotesApp.Models;

namespace FundooNotesApp.Repository
{
    public interface INoteRepository
    {
        Notes CreateNote(Notes note);
        IEnumerable<Notes> GetAllNotes(int userId);
        Notes GetNoteById(int noteId, int userId);
        Notes UpdateNote(Notes note);
        bool DeleteNote(int noteId, int userId);
        bool AddLabelToNote(int noteId, int labelId, int userId);
        bool DeleteLabelFromNote(int noteId, int labelId, int userId);
    }
}

