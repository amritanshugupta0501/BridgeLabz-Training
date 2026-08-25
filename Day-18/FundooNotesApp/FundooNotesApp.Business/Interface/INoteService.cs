using System.Collections.Generic;
using FundooNotesApp.Business;
using FundooNotesApp.Models;

namespace FundooNotesApp.Business
{
    public interface INoteService
    {
        Notes CreateNote(NotesDTO notesDTO, int userId);
        IEnumerable<Notes> GetAllNotes(int userId);
        Notes GetNotesById(int noteId, int userId);
        Notes UpdateNotes(int noteId, NotesDTO notesDTO, int userId);
        bool DeleteNote(int noteId, int userId);
        bool AddLabelToNote(int noteId, int labelId, int userId);
        bool DeleteLabelFromNote(int noteId, int labelId, int userId);
    }
}

