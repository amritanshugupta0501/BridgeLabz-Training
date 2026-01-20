using System;

public class Program
{
    public static void Main()
    {
        Course<ExamCourse> examCourses = new Course<ExamCourse>();
        examCourses.RegisterCourse(new ExamCourse { CourseName = "Mathematics" });
        examCourses.ConductEvaluations();

        Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();
        assignmentCourses.RegisterCourse(new AssignmentCourse { CourseName = "Software Engineering" });
        assignmentCourses.ConductEvaluations();
    }
}