using System;
namespace aero_vigil
{
    class InvalidFlightException : Exception
    {
        public InvalidFlightException(string message) : base(message) { }
    }
}