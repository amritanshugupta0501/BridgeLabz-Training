using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ranksheetgenerator
{
    internal interface IRankSheetGeneratorSystem
    {
        void AddAStudentInTheRanks();
        void RankGenetorForTheExam();
        StudentInformation[] MergeSorting(StudentInformation[] studentScores, int left, int right);
        StudentInformation[] Merging(StudentInformation[] studentScores, int left, int middle, int right);
        void DisplayTheRankingList();
    }
}
