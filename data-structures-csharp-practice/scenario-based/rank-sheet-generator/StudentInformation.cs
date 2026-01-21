using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scenario_Based.ranksheetgenerator
{
    // Class defined to store Student Information 
    internal class StudentInformation
    {
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public int StudentScore {  get; set; }
        public string StudentState {  get; set; }
        public string StudentCity { get; set; }

        public override string? ToString()
        {
            return $"Student Name : {StudentName}\nStudent Id : {StudentId}\nStudent City : {StudentCity}\n" +
                $"Student State : {StudentState}\nStudent Score : {StudentScore}\n";
        }
    }
}
