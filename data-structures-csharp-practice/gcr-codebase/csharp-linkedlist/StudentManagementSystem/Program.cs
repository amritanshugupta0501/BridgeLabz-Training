using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.linkedlist.StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRecordManagement list = new StudentRecordManagement();
            while (true)
            {
                Console.WriteLine("Student Record Management ");
                Console.WriteLine("1. Add at Beginning");
                Console.WriteLine("2. Add at End");
                Console.WriteLine("3. Add at Position");
                Console.WriteLine("4. Delete by Roll Number");
                Console.WriteLine("5. Search by Roll Number");
                Console.WriteLine("6. Display All");
                Console.WriteLine("7. Update Grade");
                Console.WriteLine("8. Back to Main Menu");
                Console.Write("Choice: ");

                string choice = Console.ReadLine();
                if (choice == "8") break;

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Roll: "); 
                        int rollNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Age: "); 
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Grade: "); 
                        string grade = Console.ReadLine();
                        list.AddStudentRecordInTheBeginning(name, rollNumber, age, grade);
                        break;
                    case "2":
                        Console.Write("Enter Roll: "); 
                         rollNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: "); 
                         name = Console.ReadLine();
                        Console.Write("Enter Age: "); 
                         age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Grade: "); 
                         grade = Console.ReadLine();
                        list.AddStudentRecordInTheEnd(name, rollNumber, age, grade);
                        break;
                    case "3":
                        Console.Write("Position: ");
                        int pos = int.Parse(Console.ReadLine());
                        Console.Write("Enter Roll: ");
                        rollNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        age = int.Parse(Console.ReadLine());
                        Console.Write("Enter Grade: ");
                        grade = Console.ReadLine();
                        list.AddStudentRecordInTheMiddle(name, rollNumber, age, grade, pos);
                        break;
                    case "4":
                        Console.Write("Enter Roll to Delete: ");
                        list.DeleteARecord(int.Parse(Console.ReadLine()));
                        break;
                    case "5":
                        Console.Write("Enter Roll to Search: ");
                        rollNumber = int.Parse(Console.ReadLine());
                        var s = list.SearchByRollNumber(rollNumber);
                        if (s != null) Console.WriteLine($"Found: {s.StudentName}, Grade: {s.StudentGrade}");
                        else Console.WriteLine("Not Found.");
                        Console.ReadKey();
                        break;
                    case "6":
                        list.DisplayRecords();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Write("Enter Roll: "); 
                        rollNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter New Grade: "); 
                        grade = Console.ReadLine();
                        list.UpdateGrade(rollNumber, grade);
                        break;
                }
            }
        }
    }
}
