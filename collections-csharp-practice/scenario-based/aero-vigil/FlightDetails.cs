using System;
namespace aero_vigil
{
    class FlightDetails
    {
        [FlightNumberValidator(@"FL-\d{4}")]
        public string FlightNumber{get;set;}
        [FlightNameValidator(@"SpiceJet|Vistara|IndiGo|Air Arabia")]
        public string FlightName{get;set;}
        public int PassengerCount{get;set;}
        public double FlightFuelCapacity{get;set;}
    }
}