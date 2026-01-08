using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.StudentManagementSystem
{
    internal class StudentRecordManagement
    {
        StudentNode Head;
        public StudentRecordManagement()
        {
            Head = null;
        }
        int CountNodes()
        {
            int count = 0;
            StudentNode current = Head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        public void AddStudentRecordInTheBeginning(string studentName, int studentId, int studentAge, string studentGrade)
        {
            StudentNode studentNode = new StudentNode(studentName, studentId, studentAge, studentGrade);
            if (Head == null)
            {
                Head = studentNode;
                return;
            }
            studentNode.Next = Head;
            Head = studentNode;
        }
        public void AddStudentRecordInTheEnd(string studentName, int studentId, int studentAge, string studentGrade)
        {
            StudentNode studentNode = new StudentNode(studentName, studentId, studentAge, studentGrade);
            if (Head == null)
            {
                Head = studentNode;
            }
            else
            {
                StudentNode current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = studentNode;
            }
        }
        public void AddStudentRecordInTheMiddle(string studentName, int studentId, int studentAge, string studentGrade, int position)
        {
            StudentNode student = new StudentNode(studentName, studentId, studentAge, studentGrade);
            if (Head == null)
            {
                Head = student;
                return;
            }
            if(position > CountNodes())
            {
                Console.WriteLine("Invalid Position Entered");
                return;
            }
            StudentNode current = Head;
            while(current.Next != null)
            {
                position--;
                if (position == 1)
                {
                    break;
                }
                
                current = current.Next;
            }
            student.Next = current.Next;
            current.Next = student;
        }
        public void DeleteARecord(int studentId)
        {
            StudentNode current = Head;
            while (current.Next != null) 
            {
                if(current.Next.StudentId  == studentId)
                {
                    current.Next = current.Next.Next;
                    break;
                }
                current = current.Next;
            }
        }
        public void DisplayRecords()
        {
            StudentNode current = Head;
            while (current!= null)
            {
                Console.WriteLine(current.ToString());
                current = current.Next;
            }
        }
        public StudentNode SearchByRollNumber(int rollNumber)
        {
            StudentNode current = Head;
            while (current != null)
            {
                if (current.StudentId == rollNumber)
                    return current;
                current = current.Next;
            }
            return null;
        }
        public void UpdateGrade(int rollNumber, string newGrade)
        {
            StudentNode student = SearchByRollNumber(rollNumber);
            if (student != null)
            {
                student.StudentGrade = newGrade;
            }
        }
    }
}
