using System;
using System.Collections.Generic;
using FundooNotesApp.Models;
using FundooNotesApp.Repository;

namespace FundooNotesApp.Business
{
    public class NoteServiceImpl : INoteService
    {
        private readonly INoteRepository _repository;

        public NoteServiceImpl(INoteRepository repository)
        {
            _repository = repository;
        }

        public Notes CreateNote(NotesDTO notesDTO, int userId)
        {
            var note = new Notes
            {
                UserId = userId,
                NoteTitle = notesDTO.NoteTitle,
                Description = notesDTO.Description,
                Created = DateTime.Now
            };
            return _repository.CreateNote(note);
        }

        public IEnumerable<Notes> GetAllNotes(int userId)
        {
            return _repository.GetAllNotes(userId);
        }
        public Notes GetNotesById(int noteId, int userId)
        {
            var note = _repository.GetNoteById(noteId, userId);
            if (note == null)
            {
                throw new Exception("Note not found");
            }

            return note;
        }

        public Notes UpdateNotes(int noteId, NotesDTO notesDTO, int userId)
        {
            var existingNote = _repository.GetNoteById(noteId, userId);
            if (existingNote == null)
            {
                throw new Exception("Note not found.");
            }

            existingNote.NoteTitle = notesDTO.NoteTitle;
            existingNote.Description = notesDTO.Description;
            existingNote.Edited = DateTime.Now;
            return _repository.UpdateNote(existingNote);
        }

        public bool DeleteNote(int noteId, int userId)
        {
            bool isDeleted = _repository.DeleteNote(noteId, userId);
            if (!isDeleted)
            {
                throw new Exception("Note not found.");
            }

            return true;
        }
    }
}

