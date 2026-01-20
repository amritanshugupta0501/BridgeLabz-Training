using System;
using System.Collections.Generic;

public class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    public void SubmitResume(T resume)
    {
        resumes.Add(resume);
    }

    public void ProcessResumes()
    {
        foreach (var resume in resumes)
        {
            resume.Screen();
        }
    }
}