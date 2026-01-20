using System;

public class Program
{
    public static void Main()
    {
        Resume<SoftwareEngineer> seResumes = new Resume<SoftwareEngineer>();
        seResumes.SubmitResume(new SoftwareEngineer { CandidateName = "Alice" });
        seResumes.ProcessResumes();

        Resume<DataScientist> dsResumes = new Resume<DataScientist>();
        dsResumes.SubmitResume(new DataScientist { CandidateName = "Bob" });
        dsResumes.ProcessResumes();
    }
}