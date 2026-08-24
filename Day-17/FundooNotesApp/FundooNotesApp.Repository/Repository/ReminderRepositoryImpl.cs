using System.Linq;
using System.Collections.Generic;
using FundooNotesApp.Models;

namespace FundooNotesApp.Repository
{
    public class ReminderRepositoryImpl : IReminderRepository
    {
        private readonly FundooNotesAppDbContext _context;

        public ReminderRepositoryImpl(FundooNotesAppDbContext context)
        {
            _context = context;
        }

        public Reminder AddReminder(Reminder reminder)
        {
            _context.Reminder.Add(reminder);
            _context.SaveChanges();
            return reminder;
        }

        public IEnumerable<Reminder> GetRemindersByNoteId(int noteId, int userId)
        {
            return _context.Reminder.Where(r => r.NoteId == noteId && r.UserId == userId).ToList();
        }
        public Reminder GetReminderById(int reminderId, int userId)
        {
            return _context.Reminder.FirstOrDefault(r => r.UserId == userId && r.ReminderId == reminderId);
        }
        public Reminder UpdateReminder(Reminder reminder)
        {
            _context.Reminder.Update(reminder);
            _context.SaveChanges();
            return reminder;
        }

        public bool DeleteReminder(int reminderId, int userId)
        {
            var reminder = GetReminderById(reminderId, userId);
            if (reminder != null)
            {
                _context.Reminder.Remove(reminder);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}

