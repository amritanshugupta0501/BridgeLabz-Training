using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Constructor
{
    internal class OnlineCourse
    {
        string courseName;
        double duration;
        int fee;
        static string institute = "Technical Solutions";
        public OnlineCourse(string courseName, double duration, int fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }
        public static void UpdateInstitueName(string institute)
        {
            OnlineCourse.institute = institute;
        }
        public void DisplayCourseDetails()
        {
            Console.WriteLine("Institute Name : " + institute);
            Console.WriteLine("Course Name : " + courseName);
            Console.WriteLine("Course Duration : " + duration);
            Console.WriteLine("Course Fee : " + fee);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Give course name : ");
            string name = Console.ReadLine();
            Console.Write("Give course duration : ");
            double duration = double.Parse(Console.ReadLine());
            Console.Write("Give course fee : ");
            int fee = int.Parse(Console.ReadLine());
            Console.WriteLine();
            OnlineCourse course = new OnlineCourse(name, duration, fee);
            Console.Write("Give an institute name : ");
            string institute = Console.ReadLine();
            course.DisplayCourseDetails();
            Console.WriteLine();
            OnlineCourse.UpdateInstitueName(institute);
            course.DisplayCourseDetails();
        }
    }
}
