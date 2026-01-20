using System;

public class SoftwareEngineer : JobRole
{
    public override void Screen()
    {
        Console.WriteLine($"Screening {CandidateName} for Coding Skills and System Design.");
    }
}