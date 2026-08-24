using System.Collections.Generic;
using System.Linq;
using FundooNotesApp.Models;

namespace FundooNotesApp.Repository
{
    public class LabelRepositoryImpl : ILabelRepository
    {
        private readonly FundooNotesAppDbContext _dbContext;

        public LabelRepositoryImpl(FundooNotesAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Label CreateLabel(Label label)
        {
            _dbContext.Label.Add(label);
            _dbContext.SaveChanges();
            return label;
        }

        public IEnumerable<Label> GetLabelByUserId(int userId)
        {
            return _dbContext.Label.Where(l => l.UserId == userId).ToList();
        }

        public Label GetLabelById(int labelId, int userId)
        {
            Label label = _dbContext.Label.FirstOrDefault(l => l.UserId == userId && l.LabelId == labelId);
            if(label == null)
            {
                throw new Exception("Label not found");
            }

            return label;
        }

        public Label UpdateLabel(Label label)
        {
            _dbContext.Label.Update(label);
            _dbContext.SaveChanges();
            return label;
        }

        public bool DeleteLabel(int labelId, int userId)
        {
            var label = _dbContext.Label.FirstOrDefault(l => l.UserId == userId && l.LabelId == labelId);
            if (label != null)
            {
                _dbContext.Remove(label);
                _dbContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}

