using System;

public class ExamCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine($"{CourseName} evaluated by Written Exam.");
    }
}