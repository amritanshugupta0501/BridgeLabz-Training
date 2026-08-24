using System.Collections.Generic;
using FundooNotesApp.Models;
using FundooNotesApp.Repository;

namespace FundooNotesApp.Business
{
    public interface IReminderService
    {
        Reminder AddReminder(int noteId, ReminderDTO reminderDTO, int userId);
        IEnumerable<Reminder> GetRemindersByNoteId(int noteId, int userId);
        Reminder UpdateReminder(int reminderId, ReminderDTO reminderDTO, int userId);
        bool DeleteReminder(int reminderId, int userId);
    }
}

