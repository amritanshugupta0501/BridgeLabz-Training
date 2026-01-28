using System;
namespace aero_vigil
{
    [AttributeUsage(AttributeTargets.Property)]
    class FlightNameValidator : Attribute
    {
        public string FlightNamePattern{get;}
        public FlightNameValidator(string pattern)
        {
            FlightNamePattern = pattern;
        }
    }
}