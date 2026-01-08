using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.StudentManagementSystem
{
    internal class StudentNode
    {
        public string StudentName;
        public int StudentId;
        public int StudentAge;
        public string StudentGrade;
        public StudentNode Next;
        public StudentNode(string studentName, int studentId, int studentAge, string studentGrade)
        {
            StudentName = studentName;
            StudentId = studentId;
            StudentAge = studentAge;
            StudentGrade = studentGrade;
            Next = null;
        }

        public override string? ToString()
        {
            return $"Student Name : {StudentName}\nStudent Id : {StudentId}\nStudent Age : {StudentAge}\nStudent Grade : {StudentGrade}";
        }
    }
}
