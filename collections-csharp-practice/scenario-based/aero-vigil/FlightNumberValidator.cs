using System;
namespace aero_vigil
{
    [AttributeUsage(AttributeTargets.Property)]
    class FlightNumberValidator : Attribute
    {
        public string FlightNumberPattern{get;}
        public FlightNumberValidator(string pattern)
        {
            FlightNumberPattern = pattern;
        }
    }
}