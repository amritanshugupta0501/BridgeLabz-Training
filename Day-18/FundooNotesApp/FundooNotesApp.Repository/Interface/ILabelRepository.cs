using System.Collections.Generic;
using FundooNotesApp.Models;

namespace FundooNotesApp.Repository
{
    public interface ILabelRepository
    {
        Label CreateLabel(Label label);
        IEnumerable<Label> GetLabelByUserId(int userId);
        Label GetLabelById(int labelId, int userId);
        Label UpdateLabel(Label label);
        bool DeleteLabel(int labelId, int userId);
    }
}