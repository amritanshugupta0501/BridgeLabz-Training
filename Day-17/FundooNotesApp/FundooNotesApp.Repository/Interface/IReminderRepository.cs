using System.Collections.Generic;
using FundooNotesApp.Models;

namespace FundooNotesApp.Repository
{
    public interface IReminderRepository
    {
        Reminder AddReminder(Reminder reminder);
        IEnumerable<Reminder> GetRemindersByNoteId(int noteId, int userId);
        Reminder GetReminderById(int reminderId, int userId);
        Reminder UpdateReminder(Reminder reminder);
        bool DeleteReminder(int reminderId, int userId);
    }
}