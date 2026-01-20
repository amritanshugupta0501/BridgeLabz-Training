using System;

public class DataScientist : JobRole
{
    public override void Screen()
    {
        Console.WriteLine($"Screening {CandidateName} for Statistics and Machine Learning.");
    }
}