using System;
using System.Collections.Generic;
using FundooNotesApp.Models;
using FundooNotesApp.Repository;

namespace FundooNotesApp.Business
{
    public class ReminderServiceImpl : IReminderService
    {
        private readonly IReminderRepository _reminderRepository;
        private readonly INoteRepository _noteRepository;
        private readonly IRabbitMqProducer _rabbitMqProducer;
        public ReminderServiceImpl(IReminderRepository reminderRepository, INoteRepository noteRepository, IRabbitMqProducer rabbitMqProducer)
        {
            _reminderRepository = reminderRepository;
            _noteRepository = noteRepository;
            _rabbitMqProducer = rabbitMqProducer;
        }

        public Reminder AddReminder(int noteId, ReminderDTO reminderDTO, int userId)
        {
            var note = _noteRepository.GetNoteById(noteId, userId);
            if (note == null)
            {
                throw new Exception("Note not found.");
            }

            if (reminderDTO.ReminderDate <= DateTime.Now)
            {
                throw new Exception("Reminder date must be in future.");
            }

            var reminder = new Reminder
            {
                NoteId = noteId,
                UserId = userId,
                ReminderDate = reminderDTO.ReminderDate,
                IsProcessed = false
            };
            var savedReminder = _reminderRepository.AddReminder(reminder);
            _rabbitMqProducer.SendMessage(savedReminder,"Reminder Queue");
            return savedReminder;
        }
        public IEnumerable<Reminder> GetRemindersByNoteId(int noteId, int userId)
        {
            return _reminderRepository.GetRemindersByNoteId(noteId, userId);
        }

        public Reminder UpdateReminder(int reminderId, ReminderDTO reminderDTO, int userId)
        {
            if (reminderDTO.ReminderDate <= DateTime.Now)
            {
                throw new Exception("Reminder Date must be in future.");
            }

            var existingReminder = _reminderRepository.GetReminderById(reminderId, userId);
            if (existingReminder != null)
            {
                throw new Exception("Reminder not found.");
            }

            existingReminder.ReminderDate = reminderDTO.ReminderDate;
            existingReminder.IsProcessed = false;
            return _reminderRepository.UpdateReminder(existingReminder);
        }

        public bool DeleteReminder(int reminderId, int userId)
        {
            bool isDeleted = _reminderRepository.DeleteReminder(reminderId, userId);
            if (!isDeleted)
            {
                throw new Exception("Reminder not found");
            }
            return true;
        }
    }
}

