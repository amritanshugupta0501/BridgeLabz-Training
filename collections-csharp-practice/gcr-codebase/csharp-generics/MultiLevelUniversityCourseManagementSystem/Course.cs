using System;
using System.Collections.Generic;

public class Course<T> where T : CourseType
{
    private List<T> courses = new List<T>();

    public void RegisterCourse(T course)
    {
        courses.Add(course);
    }

    public void ConductEvaluations()
    {
        foreach (var course in courses)
        {
            course.Evaluate();
        }
    }
}