using System;
using System.Collections.Generic;
using FundooNotesApp.Repository;
using FundooNotesApp.Models;

namespace FundooNotesApp.Business
{
    public class LabelServiceImpl : ILabelService
    {
        private readonly ILabelRepository _labelRepository;

        public LabelServiceImpl(ILabelRepository labelRepository)
        {
            _labelRepository = labelRepository;
        }
        public Label CreateLabel(LabelDTO labelDTO, int userId)
        {
            var label = new Label
            {
                LabelName = labelDTO.LabelName,
                UserId = userId
            };
            return _labelRepository.CreateLabel(label);
        }

        public IEnumerable<Label> GetLabelByUserId(int userId)
        {
            return _labelRepository.GetLabelByUserId(userId);
        }

        public Label UpdateLabel(int labelId, LabelDTO labelDTO, int userId)
        {
            var existingLabel = _labelRepository.GetLabelById(labelId, userId);
            if (existingLabel == null)
            {
                throw new Exception("Label does not exist.");
            }

            existingLabel.LabelName = labelDTO.LabelName;
            return _labelRepository.UpdateLabel(existingLabel);
        }

        public bool DeleteLabel(int labelId, int userId)
        {
            bool isDeleted = _labelRepository.DeleteLabel(labelId, userId);
            if (!isDeleted)
            {
                throw new Exception("Label does not exist.");
            }

            return true;
        }
    }
}