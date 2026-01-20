using System;

public abstract class JobRole
{
    public string CandidateName { get; set; }
    public abstract void Screen();
}