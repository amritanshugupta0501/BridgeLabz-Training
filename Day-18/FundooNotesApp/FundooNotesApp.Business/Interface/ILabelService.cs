using System.Collections.Generic;
using FundooNotesApp.Repository;
using FundooNotesApp.Models;

namespace FundooNotesApp.Business
{
    public interface ILabelService
    {
        Label CreateLabel(LabelDTO labelDTO, int userId);
        IEnumerable<Label> GetLabelByUserId(int userId);
        Label UpdateLabel(int labelId, LabelDTO labelDTO, int userId);
        bool DeleteLabel(int labelId, int userId);
    }
}