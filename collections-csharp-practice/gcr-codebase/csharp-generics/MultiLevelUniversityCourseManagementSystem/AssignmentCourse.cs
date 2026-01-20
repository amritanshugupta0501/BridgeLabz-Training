using System;

public class AssignmentCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine($"{CourseName} evaluated by Project Assignment.");
    }
}